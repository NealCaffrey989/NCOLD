       ;差接收PC查询命令后，打开GPS接收中断以及GPS中断初始化设置//////////////2007-3-27！！！1
       ;启动无按键版无线版无地址码4位命令序号;延时1S
		; JIKA 集卡控制器   AT89C52+AM2970           2000A版
        ;命令最长为32位
	; 功能描述:
	; 接收到数据判断是否为本机地址01H,输出继电器闭合,声响4声
	; 确认后,回应主机
	; 干扰复位，不清数据，不变状态
	; 按键:请求,确认,对讲

        ; 40H41H ---------- 判断RAM数据已破坏?
	; 42H ------------- LED闪亮/B-B 响计时
	; 43H ------------- 继电器跳动计时
	; 45H ------------- T0辅助计时单元
        ; 4AH ------------- 响铃5秒钟计数单元
;						起始符 地址 表请求  结束符
	; 70H-77H---------- 请求帧单元组  格式：  #    01H   AA     $
	; 78H-7FH---------- 确认帧单元组  格式：  #    01H   BB     $
           ;80H-A5H------------存储单元
        ;2007 GPS 80H--BEH, GPS存储单元
        ; 50H-6FH --------- 16X2_LCD 显示镜象单元
        ; 52H53H----------- 地址单元
        ; 54F55H------------命令类型
        ; E0H-EFH --------- 堆栈

	;00HB
	;01HB
	;02HB
	;03HB
	;04HB		消声
	;05HB
	;06HB
	;07HB          申请显示


        ;RI1     EQU     SCON1.0
        ;TI1     EQU     SCON1.1
        ;
        RB81    EQU     SCON1.2
        ;
        TB81    EQU     SCON1.3
        ;
        REN1    EQU     SCON1.4
        ;
        SM21    EQU     SCON1.5
        ;
        SM11    EQU     SCON1.6
        ;
        SM01    EQU     SCON1.7
        SOUND_FG BIT    04H
        LED_R    BIT    03H     ;3-22  亮灯信号
        SHOW_FG  BIT    07H
        START_SOUND BIT  08H    ; 5秒钟响铃开始标志
        LCD_RS   BIT    P2.5    ; 寄存器选择:   1-数据  0-指令
        LCD_RW   BIT    P2.6    ; 读写操作选择: 1-读    0-写
        LCD_CE   BIT    P2.7    ; 使能信号
        LCD_DB   EQU    P0      ; 8位数据
	LED_O	 BIT	P1.7
	TXD_J	 BIT	P1.0
	BBOUT	 BIT	P1.1
	NUMB	 EQU	45H    ; 响叫次数
	COM	 EQU	4EH    ; LCD 控制字
 	DAT	 EQU	4FH    ; LCD 数据

        M_CD     BIT    P3.2    ; 0--检测到信号                           `
        M_DTR    BIT    P3.3    ; 数据终端就绪
        M_CTS    BIT    P3.4    ; 允许发送:     0-发送
        M_RTS    BIT    P3.5    ; 发送使能:     0-发送

        ORG     0000H
        LJMP    MAIN
        ORG     000BH
        LJMP    TIMER_0
        ORG     0023H
        LJMP    SIO_0
        ORG     003BH
        LJMP    SIO_1      ;2007---添加gps接收端


MAIN:   MOV     IE,#0   ;DISABLE ALL INTERRUPT
        MOV     R7,#20      ;等待外围器件复位
LOP:    LCALL   T5MS
        LCALL   T5MS
	DJNZ    R7,LOP
        MOV 	SP,#0E0H
        MOV 	P1,#0FCH ;#0ECH   ;#0ECH;3-12
	MOV 	P2,#66H	; LCD不使能;MODEM用模式6  01100110B
        MOV 	PSW,#00H
	;CLR 	TXD_J	; MODEM 接收初始化
        ;SETB 	M_RTS	; 回到接收模式
        LCALL 	LDSTAT    ; 传送启始显示数据
        LCALL 	STRDIP    ; 启始屏显示
        LCALL   T_3S
        LCALL   T_2S
        MOV     R2, #100
DELY:   LCALL   T5MS
        DJNZ    R2, DELY
        MOV 	A,40H
        CJNE 	A,#0AAH,YCRR   ; RAM数据已破坏?
	MOV 	A,41H
	CJNE 	A,#0AAH,YCRR
YCRR:	MOV 	40H,#0AAH
	MOV 	41H,#0AAH
        MOV     4AH,#0
        MOV     4BH,#0
	CLR 	A
        MOV 	R0,#20H     ; 20H-3FH单元清0
        MOV 	R2,#40H
CLR0:   MOV 	@R0,A
        INC 	R0
        DJNZ 	R2,CLR0
        ACALL   QIN0
        MOV	32H, #30H		;///////////////////////////
	MOV	33H, #30H;赋本机地址  01////////////////////////BCD码

        MOV 	76H,#0FFH
        MOV 	7CH,#80H	; 一直显示“启始屏”
        MOV 	2DH,#01H

LOPST:  CLR 	LED_O
        SETB     LED_R
TSTRT:	NOP
        ;ACALL 	KENY
        ;JNC 	TSTRT
        ;ACALL 	T5MS
       ACALL 	T5MS

        MOV 	08H,#60H
INIT:
	MOV 	TMOD,#21H
	MOV	TH0,#3CH    ; T0--50MS中断
	MOV 	TL0,#0B0H
	MOV 	SCON,#50H   ;////RXD-10 TXD-11与PC

        MOV 	SCON1,#50H  ;/////////////////2007GPS改为W77E58,其中RXD1-3  TXD1-4与GPS
        MOV 	TH1,#0FDH   ; T1--作口1波特率发生器
        MOV 	TL1,#0FDH   ; 12MHZ --- 1200BPS 2-27-4800BPS-0FAH 2400-F3H
        ANL     PCON,#07FH  ;CLEAR SMOD BIT FOR SIO0
         ;/////////////////////////W77E58 2007 GPS////////

       ANL     WDCON,#07CH ;CLEAR SMOD BIT FOR SIO1 W77E58 2007GPS/////////////////
        ANL     CKCON,#0D0H ;T0,T1,T2十二分频     W77E58 2007 GPS////////
       ; MOV     T2MOD,#00H ;T0,T1,T2十二分频     W77E58 2007 GPS////////
     ; MOV     TH2,#0FDH     ; T2--作口0波特率发生器  ;T0,T1,T2十二分频     W77E58 2007 GPS////////
      ;MOV     TL2,#0FDH       ;T0,T1,T2十二分频     W77E58 2007 GPS////////
      ;  MOV     RCAP2H,#0E6H    ;T0,T1,T2十二分频     W77E58 2007 GPS////////
      ;  MOV     RCAP2L,#0E6H    ;T0,T1,T2十二分频     W77E58 2007 GPS////////
       ;ORL     T2CON,#34H      ;;T0,T1,T2十二分频     W77E58 2007 GPS////////启动T2, RCLK,TCLK置1
      ;////////////////////////////////  W77E58 2007 GPS////////
        MOV     TCON,#55H   ;启动T0、T1
        CLR     ET1
        CLR     ET2         ;W77E58 2007GPS////////////////
                                ;原来位置
;CAZZ:                     ;////////////////////////////////整行删除
        CLR     25H        ;默认不亮 3-12
        CLR     05H
        SETB    ES ;///////TEST DEL
         CLR    ES1       ;W77E58串口1中断关////////W77E58 2007GPS////////  TEST
        SETB    ET0
        SETB    EA

        SETB    SOUND_FG
        MOV     A,#20H
        MOV     R0,#50H     ; 50H-9FH单元置#20H
        MOV     R2,#50H      ;20H///////////////////////
CLR1:   MOV     @R0,A
        INC     R0
        DJNZ    R2,CLR1
        MOV     54H,#52H    ; 显示 Ready!
        MOV     55H,#65H
        MOV     56H,#61H
        MOV     57H,#64H
        MOV     58H,#79H
        MOV     59H,#21H

;	LCALL 	FLASH_DT    ; 调入闪存中的数据到70H-7FH单元组中（未完）


       ;CLR     M_DTR       ; 微机准备就绪
        LCALL     T_3S
        ;LCALL     T_10S
          ;查询指令的指针数子程序ZZ////////////////////////////////////////////////////////////
        ;SETB    25H     ;置25H位地址，作为标记
        NOP
        NOP
        NOP
        SETB    SHOW_FG
        ;SETB    LED_R
LOOP:   JNB     SHOW_FG,NDISP   ; 07HB--申请显示
        ;CLR     EA
        LCALL   DISPLY    ; 全屏显示
        ;SETB    EA
        CLR     SHOW_FG
       ; JNB     OVER_FG,NDISP
        ;CLR     SOUND_FG
NDISP:  LCALL   KENT
	MOV     R7,#05H
MLOP:   LCALL   T5MS
        LCALL   T5MS
	DJNZ    R7,MLOP
        AJMP    LOOP
MEND:   NOP		; MAIN END
        NOP
        NOP
        LJMP    MAIN
;*******************
QIN0:   CLR 	A
        MOV 	R0,#70H     ; 20H-3FH单元清0
        MOV 	R2,#70H
QI_0:   MOV 	@R0,A
        INC 	R0
        DJNZ 	R2,QI_0
        RET

;***********************串行口中断*************************************
SIO_0:
        CLR     EA
        PUSH    ACC	; 串行口0中断
	PUSH    PSW
	SETB    RS0	; 接收格式:  "#OK$"
	SETB    RS1
	JNB     TI,S0_R
        CLR     TI
        NOP
        LJMP    S0_RET
S0_R:
       CLR     RI
        MOV     A,SBUF
        NOP

RD0:	CJNE    A,#23H,RD1  ; 接收到起始符#
	MOV     R0,#80H      ;50H//////////////////////\\\\\\\\\\\\\\\\\\\\\\
	LJMP    S0_RET
RD1:	CJNE    A,#24H,SAV1  ; 接收到结束符%25h, 原程序为24h！！！！！！！！！！！！1
        		      ; 接收数据处理
        MOV     A,#20H       ;未用显示单元置空格
        SJMP    LOP0
SAV1:   AJMP    SAVE0
LOP0:   MOV     @R0,A
        INC     R0
        CJNE    R0,#0A7H,LOP0   ;A42-17修改预留2位校验码0A7H////////////////////////\\\\\\\\\\\\\\\\\\\\\
;2-17DELETE******************************/////////////
       ;MOV R1, #80H
        ;MOV R0, #30H
;S_X2:    ;MOV A, @R1
       ; MOV @R0, A
        ;INC R0
        ;INC R1
        ;CJNE R1, #84H, S_X2
         ;1223地址判别DELETE////////////
;2-17DELETE******************************/////////////

        MOV     R1,#80H  ;2-17#84H  /////////////////////
        MOV     A,@R1            ;54H////////////////\\\\\\\\\\\\\\\\\\\\\\

BJ1:    CJNE    A,#4FH,NEXT   ;是O吗？
        INC     R1
        MOV     A, @R1
        CJNE    A, #4BH,S0_RET   ;K?
        INC R1;MOV     R0, #0A0H  2007GPS
        MOV A, @R1;@R0    2007GPS
        CJNE   A, #00H, JYE            ;04H 2007GPS
        INC    R1;R0  2007GPS
        MOV    A,@R1 ;@R0  2007GPS
        CJNE   A, #9AH,JYE             ;5AH 2007GPS
        AJMP   PJR
        ;CLR     F0
        ;MOV     R0, #80H
        ;LCALL   PJYM; 2-17预留判断校验位是否正确的子程序
        ;JB     F0, PJR                             ;F0=0校验不正确
JYE:        LJMP   S0_RET

PJR:	;/////2007GPS   LCALL     T_1S
        ;/////2007GPS   MOV       30H, #30H
        ;//////2007GPS  MOV       31H, #30H
        ;///////2007GPS MOV       7AH, #4FH
        ;///////2007GPS MOV       7BH, #4BH     ;发送存储00OK
        ;///////2007GPS  LCALL   SEND_TY		;是O的话，发送PC应答YY////////////////!!!!!!!!!!!!!!
        ;SETB    SOUND_FG
        ;2-17预留亮显示灯等
        SETB    EA     ;////////2007GPS 开中断
          ;/////2007GPS  打开串口1中断接收GPS数据
        ;LCALL  T5MS   ;/////2007GPS
        ;LCALL  T5MS   ;/////2007GPS
        SETB LED_R
        LJMP    R0_FH ;S0_RET
NEXT:    MOV     R1,#80H  ;2-17#增加的两条指令 /////////////////////
        MOV     A,@R1

	CJNE	A, #4DH,S0_RET		;不是O，继续判断,是命令么以M作为命令标志///////////////////////!!!!!!!!!
        MOV R1, #81H
        MOV     A, @R1                ;55H///////////////////\\\\\\\\\\\\\\\\\\\\\\\
        CJNE    A, #30H, S0_RET            ;A中如果不是0，继续判断是不是1///////////////////XXXXXXXXXX
                               ;是0把命令保存到70-79H
        ;MOV     R0, #82H
        CLR     F0
        LCALL   PJYM; 2-17预留判断校验位是否正确的子程序
        JB     F0, SE_M0
         LJMP   S0_RET
        ;2-17除掉LCALL   SAM0                    ;保存命令56H-5FH到70H-79H
SE_M0:  MOV     30H, #4DH
        MOV     31H, #30H               ;发送M0OK表示第一条命令已经收到
        MOV     7AH, #4FH
        MOV     7BH, #4BH
        SETB    LED_R
        LCALL     T_1S
        LCALL   SEND_TY                 ;调用发送给PCM0子程序

;//////////////////2-17///////////////////////////////////\\\\\\\\\\\\\\\\\\
        SETB    SOUND_FG	  ; 申请鸣"滴..滴.."
        SETB    SHOW_FG
       LCALL STOD                  ;2-17调用将命令送显示存储区域的子程序
 ;/////////////////////////////////////////////////// \\\\\\\\\\\\\\\\\\\\\\\\\\

       AJMP     S0_RET

SAVE0:  MOV     @R0,A
	INC     R0
	CJNE    R0,#0A7H,S0_RET  ;70H\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\/////////////////
	DEC     R0
S0_RET:
        POP PSW
	POP ACC
        SETB    EA
        RETI
R0_FH:  POP PSW
        POP ACC
        SETB EA
        SETB    ES1
        RETI
;*******************************************************************
STOD:    SETB RS0                    ;调用存储单元存入显示单元的子程序
         SETB RS1
         MOV R0, #50H
         MOV R1, #82H                 ;2-1786H
SD1:     MOV A,  @R1
         MOV @R0,  A
         INC R0
         INC R1
         CJNE  R0, #70H ,SD1
         RET

PJYM:    SETB   RS0                     ;判断校验码的子程序2-17
         SETB   RS1

         MOV    32H, #0               ;和的低位
         MOV    33H, #0                ;和的高位
         MOV    R0,#80H                 ;计入M0
         MOV    A, @R0
         MOV    32H, A
PJ_L0:   MOV    A, 32H
         CLR    C
         INC    R0
         ADD   A, @R0
         MOV   32H, A
         MOV   A, 33H
         ADDC  A, #0
         MOV   33H, A
         CJNE  R0,#0A1H,PJ_L0
         INC   R0
         MOV    A, @R0
         CJNE   A, 33H, N_PJ
         INC    R0
         MOV    A, @R0
         CJNE   A, 32H, N_PJ
         SETB     F0       ;      校验正确
         RET
N_PJ:    CLR    F0         ;     校验不对
         RET
;******************************************************************
 ;************************应答程序*****************************************************
 SEND_TY:CLR       REN           ; 请求键
	CLR       ES
  	;SETB      TXD_J     	; MODEM 发送初始化
        LCALL     T5MS
        ;CLR       M_RTS	        ; 进入发送模式
        LCALL     T5MS
       ;JB        M_CTS,$


KK1:	MOV	A, #23H		;发送#
	MOV C, PSW.0		;校验位
	MOV TB8, C
        MOV       SBUF,A
	JNB       TI,$
	CLR       TI
        MOV A,30H
	MOV C, PSW.0
	MOV TB8, C
	MOV SBUF, A
	JNB TI, $
	CLR TI

	MOV A, 31H
	MOV C, PSW.0
	MOV TB8, C
	MOV SBUF, A
	JNB TI, $
	CLR TI

;2-17DLEETE发送32H,33H

	MOV A, 7AH		;
	MOV C, PSW.0
	MOV TB8, C
	MOV SBUF, A		;
	JNB TI, $
	CLR TI

	MOV A, 7BH
	MOV C, PSW.0
	MOV TB8, C
	MOV SBUF, A		;
	JNB TI, $
	CLR TI
        LCALL TJJY                       ;2-17添加校验码子程序

        MOV A, 35H             ; 2-17校验位高位
	MOV C, PSW.0
	MOV TB8, C
	MOV SBUF, A		;
	JNB TI, $
	CLR TI

        MOV A, 34H
	MOV C, PSW.0
	MOV TB8, C
	MOV SBUF, A		;
	JNB TI, $
	CLR TI

	MOV A, #24H		;发送结束符%24h！！！！！！！！！！！！！！
	MOV C, PSW.0
	MOV TB8, C
	MOV SBUF, A
	JNB TI, $
	CLR TI

        LCALL     T5MS
        LCALL     T5MS
        LCALL     T5MS
        ;CLR       TXD_J	; MODEM 接收初始化
       ;SETB      M_RTS	; 回到接收模式
        SETB      ES

	SETB      REN
        CLR       RI
        RET

TJJY:   MOV     35H, #0
        MOV     A, 30H
        CLR     C
        ADD     A, 31H
        MOV     34H,A     ;DIWEI  <-30H+31HDIWEI
        MOV     A, 35H
        ADDC    A, #0      ;35H<-30H+31H H
        MOV     35H,A
        MOV     A, 34H
        CLR     C
        ADD     A, 7AH     ;<-30H+31H+7AH D
        MOV     34H, A
        MOV     A, 35H
        ADDC    A, #0
        MOV     35H, A    ;<-30H+31H+7AH  H
        MOV    A, 34H
        CLR    C
        ADD    A, 7BH
        MOV    34H,A
        MOV    A,35H
        ADDC   A, #0
        MOV    35H,A
        RET

;******************************************************************
T5MS:   PUSH    ACC        ; 延时 5ms
        MOV      A,R6
        PUSH ACC
        MOV R6,#08H
T5M1:   MOV A,#20H
T5M2:   DEC A
        CJNE A,#01H,T5M2
        DJNZ R6,T5M1
        POP ACC
        MOV R6,A
        POP ACC
        RET
T_1S:   MOV    R5,#03H;1秒延时子程序
D0:     MOV    R6,#0FFH
D1:     MOV    R7,#0FFH
        DJNZ   R7,$
        DJNZ   R6,D1
        DJNZ   R5,D0
        RET
T_10S:  MOV    R5,#30;10秒延时子程序
D60:    MOV    R6,#0FFH
D61:    MOV    R7,#0FFH
        DJNZ   R7,$
        DJNZ   R6,D1
        DJNZ   R5,D0
        RET
T_3S:  MOV    R5,#09H;3秒延时子程序
D3:   MOV    R6,#0FFH
D4:   MOV    R7,#0FFH
      DJNZ   R7,$
      DJNZ   R6,D4
      DJNZ   R5,D3
      RET

T_2S:  MOV    R5,#06H;2秒延时子程序
D5:   MOV    R6,#0FFH
D6:   MOV    R7,#0FFH
      DJNZ   R7,$
      DJNZ   R6,D6
      DJNZ   R5,D5
      RET
;******************************键盘********************************
KENY:   ;MOV C,P1.4
	MOV C,P1.5
	ANL C,P1.6
	RET


KENT:	ACALL KENY
	JC KENR
	ACALL T5MS
	ACALL T5MS
        ACALL T5MS
        ACALL T5MS
	ACALL KENY
	JC KENR
	JNB P1.6,KEN1
	JNB P1.5,KEN3       ;3-12
	;JNB P1.4,KEN3
KENR:	ACALL T5MS
	;ACALL KENY
	;JNC KENR
	LCALL T5MS
	LCALL T5MS
        LCALL T5MS
	RET
;*********************************按键处理******************
KEN1:	CLR       REN           ; 请求键///////////改成确认一//////////请求发送本条指令
	CLR       ES
  	;SETB      TXD_J     	; MODEM 发送初始化
        LCALL     T5MS
        ;CLR       M_RTS	        ; 进入发送模式
        LCALL     T5MS
        ;JB        M_CTS,$
        MOV        30H, #30H
        MOV        31H, #30H
        MOV       7AH, #4DH     ;发送00M1
        MOV       7BH, #31H
        LCALL     T_3S
        ;LCALL     T_2S
        LCALL     SEND_TY     ;调用发送通用子程序
        SETB      SOUND_FG
        SETB      LED_R
	LJMP      KENR

KEN2:	CLR       REN		; 对讲键
	CLR       ES
LOP2:  	;SETB      TXD_J     	; MODEM 发送初始化
K2_RET: ;JNB       P1.4,LOP2
        JB        25H, KE_1     ;3-12
        SETB       P1.4                        ;25H=0
        SETB      25H
       LCALL     T_3S
       AJMP      KE_FH
KE_1:  CLR      P1.4
       ;LCALL T_10S
       LCALL T_3S
       CLR     25H
        ;LCALL     CAXZ   ;////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\
        ;CLR       TXD_J
KE_FH:  SETB      ES
	SETB      REN
        AJMP      KENR


KEN3:   JB        05H, LGM      ;25H=1
        CLR       P1.4
        ;SETB      P1.4          ;3-28
        LCALL     T_1S
        SETB      05H

	LJMP       KENR
LGM:    ;CLR        P1.4        ;3-28
        SETB        P1.4
        CLR        05H
        LCALL      T_1S
        LJMP       KENR


SHOWC:	MOV       DPTR,#CTAB
        LCALL     STRDIP
        RET

SHOWG:	MOV       DPTR,#GTAB
        LCALL     STRDIP
        RET


SHOWYES: MOV       DPTR,#YESTAB
        LCALL     STRDIP
        RET
SHOWASK:MOV       DPTR,#ASKTAB
        LCALL     STRDIP        ;双屏显示
        RET
SHOWAUTO_CC:
        MOV       DPTR,#AUTO_CCTAB
        LCALL     STRDIP        ;双屏显示
        RET


CTAB:	DB '     C          '
        DB '                '

GTAB:	DB '     G          '
        DB '                '


YESTAB:	DB '     Yes !      '
        DB '                '

ASKTAB: DB '   ASK ... OK!  '
        DB '                '

AUTO_CCTAB:
        DB 'AUTO ANSWER TEST'
        DB '    ...OK!      '
;*******************各种表格*********************************
STRTAB:     DB '   Jika--Main   '
            DB '  Made by SMU   '



;**********************定时器0*************************


TIMER_0:
        PUSH ACC        ; 时钟 77H
        PUSH PSW
        SETB RS1        ; 区2
        CLR  RS0
        MOV TH0,#3CH
        MOV TL0,#0B0H   ; 50MS

TT1:	MOV A,43H
	ADD A,#10H
	MOV 43H,A       ; 继电器跳动计时
	JNB SOUND_FG,TLEDO
TT0:	MOV C,ACC.7
	MOV BBOUT,C
        ;CPL LED_O
        MOV A,4AH       ;计时5秒钟
        ADD A,#01H
        MOV 4AH,A
        CJNE A,#10,TLEDO     ;2-1760;20
        MOV 4AH,#0
        CLR     BBOUT
        ;CLR     LED_O
	CLR     SOUND_FG
TLEDO:  MOV A,42H
        ADD A,#20H      ; 闪亮计时
        MOV 42H,A
        JNB  LED_R, TF0RT
        JNC TF0RT
        CPL   LED_O
	MOV A,4BH       ;计时5秒钟
        ADD A,#01H
        MOV 4BH,A
        CJNE A,#5,TF0RT    ;2-1760;20
        MOV 4BH,#0
TF_L :   CLR LED_R
        CLR LED_O
TF0RT:  POP PSW
        POP ACC
        RETI  ;

;//////////////////////////////2007 gps接收////////////////////
SIO_1:                  ;接收GPS发来的数据
        CLR     EA
        PUSH	ACC	;串行口1中断接收
	PUSH 	PSW
	SETB 	RS0	; 发送格式:  "#OK$"
	CLR 	RS1        ; 接收格式:  "$BIN1...<CR><LF>"    共计64字节
        MOV 	3FH,#33H
        JNB     TI1,S1_R
        CLR     TI1
        NOP
        SJMP    S1_RET
S1_R:   CLR     RI1
        MOV     A,SBUF1

JUGE0:	CJNE 	A,#24H,JUDGE2; 接收到起始符 $
	MOV 	R0,#80H           ;50H              80,90,A0,B0,
	SJMP 	S1_RET
;JUDGE1:	CJNE 	A,#0DH,JUDGE2 ; 接收到结束符   0DH0AH
	;SJMP SAVE1	    ; 接收数据处理
JUDGE2: CJNE    A, #0AH, SAVE1
       ; CLR     ES1          ;/////2007GPS  数据接收完毕关GPS串行口1中断
       ; MOV     A,#20H       ;未用显示单元置空格
;LOP1:   MOV     @R0,A
       ; INC     R0
        ;CJNE    R0,#0BEH,LOP1   ;
        SETB 	SOUND_FG      ; 申请鸣"滴..滴.."
        MOV     R0,#80H
        MOV     A,@R0
        CJNE    A,#42H, S1_RET
        INC R0
        MOV  A,@R0
        CJNE    A, #49H, S1_RET
        INC R0
        MOV A, @R0
        CJNE  A, #4EH, S1_RET
        INC  R0
        MOV A,@R0
        CJNE A, #01H, S1_RET
        CLR ES1
        LCALL   SEND_PC     ; 发送数据到PC      /////
SJMP 	S1_RET
SAVE1:  MOV 	@R0,A
	INC	R0
	CJNE	R0,#0BEH,S1_RET
	;MOV 	R0,#80H           ;50H
        NOP
S1_RET:
        POP	PSW
	POP 	ACC
        SETB    EA
        RETI

; //////////////////2007 GPS/////////////////////////////////
SEND_PC: CLR       REN           ; 请求键
	CLR       ES
  	;SETB      TXD_J     	; MODEM 发送初始化
        LCALL     T5MS
        ;CLR       M_RTS	        ; 进入发送模式
        LCALL     T5MS
       ;JB        M_CTS,$
	MOV	A, #24H		;发送$
	MOV C, PSW.0		;校验位
	MOV TB8, C
        MOV       SBUF,A
	JNB       TI,$
	CLR       TI
        MOV R0,#80H
JXF1:   MOV A,@R0
	MOV C, PSW.0
	MOV TB8, C
	MOV SBUF, A
	JNB TI, $
	CLR TI
        INC R0
        CJNE R0,#0BEH, JXF1

	MOV A, #0AH
	MOV C, PSW.0
	MOV TB8, C
	MOV SBUF, A
	JNB TI, $
	CLR TI

        LCALL     T5MS
        LCALL     T5MS
        LCALL     T5MS
        ;CLR       TXD_J	; MODEM 接收初始化
       ;SETB      M_RTS	; 回到接收模式
        SETB      ES
	SETB      REN
        CLR       RI
        RET


;***************************************************************
		; LMB162G  16X2_LCD字符显示器

STRDIP:		; 通用整屏 16X2 字符显示(用于启始屏)
     	LCALL 	LCDRST		; LCD 复位
        MOV 	COM,#80H      	; 设置显示位置为第一行第0位
     	LCALL 	LCDWC
	MOV	R3,#00H
SHOW1:  MOV 	A,R3
        MOVC 	A,@A+DPTR	; 查表法显示第一行数据
        MOV 	DAT,A
        LCALL 	LCDWD
        INC 	R3
        CJNE	R3,#10H,SHOW1
        MOV 	COM,#0C0H      	; 设置显示位置为第二行第0位
     	LCALL 	LCDWC
SHOW2:  MOV 	A,R3
        MOVC 	A,@A+DPTR	; 查表法显示第二行数据
        MOV 	DAT,A
        LCALL 	LCDWD
        INC 	R3
        CJNE	R3,#20H,SHOW2
        RET

DISPLY:		; 通用整屏 16X2 字符显示(用于数据显示)
     	LCALL 	LCDRST		; LCD 复位
        MOV 	COM,#80H      	; 设置显示位置为第一行第0位
     	LCALL 	LCDWC
	MOV	R0,#50H
SDHOW1:  MOV	A,@R0		; 查表法显示第一行数据
        MOV 	DAT,A
        LCALL 	LCDWD
        INC 	R0
        CJNE	R0,#60H,SDHOW1
        MOV 	COM,#0C0H      	; 设置显示位置为第二行第0位
     	LCALL 	LCDWC
SDHOW2:  MOV 	A,@R0		; 查表法显示第二行数据
        MOV 	DAT,A
        LCALL 	LCDWD
        INC 	R0
        CJNE	R0,#70H,SDHOW2
        RET


LDSTAT:	MOV R2,#00H	; 传送启始界面显示数据
	MOV R0,#50H
	MOV DPTR,#STRTAB
LPSTA:	MOV A,R2
	MOVC A,@A+DPTR
	MOV @R0,A
	INC R0
	INC R2
	CJNE R2,#20H,LPSTA
	RET

LCDRST:               	; LCD初始化程序
        CLR 	LCD_RS
        CLR 	LCD_RW
        MOV 	LCD_DB,#38H	; 显示模式设置(不检测忙信号) 共三次
        MOV 	R2,#03H
LCD1:   SETB 	LCD_CE
        CLR 	LCD_CE
        LCALL 	T5MS
        DJNZ 	R2,LCD1
        MOV 	COM,#38H    	; 功能设置(以后均检测忙信号)
				; DL=1（8位数据）N=1（2行）F=0（5X7）
        LCALL 	LCDWC
        MOV 	COM,#08H      	;关显示
        LCALL 	LCDWC
        MOV 	COM,#01H      	;清屏
        LCALL 	LCDWC
        MOV 	COM,#06H      	;设置输入方式：I/D=1（增量方式）S=0（不移位）
        LCALL 	LCDWC
        MOV 	COM,#0CH        ;显示开,光标关,不闪烁
        LCALL 	LCDWC
        RET

LCDWC:	PUSH 	ACC		; 写 LCD 命令子程序
	LCALL 	LCDBUSY  	; 检测忙信号
        CLR 	LCD_RS      	; RS=0,RW=0,CE下降沿
        CLR 	LCD_RW
        MOV 	LCD_DB,COM  	; 写指令
        SETB 	LCD_CE     	; 使能指令
        LCALL 	T5MS
        CLR 	LCD_CE
        LCALL 	T5MS
        POP 	ACC
	RET
LCDWD:	PUSH 	ACC		; 写 LCD 显示数据子程序
	LCALL 	LCDBUSY  	; 检测忙信号
        SETB 	LCD_RS
        CLR 	LCD_RW
        MOV 	LCD_DB,DAT	; 写数据
        SETB	LCD_CE		; 使能指令
        LCALL 	T5MS
        CLR 	LCD_CE
        LCALL 	T5MS
        POP ACC
	RET
LCDBUSY:PUSH    ACC		;检测LCD控制器忙状态
        CLR     LCD_RS		;RS=0 RW=1 E=高电平
        SETB    LCD_RW
        CLR     LCD_CE
WTD_PA: MOV     LCD_DB,#0FFH
        SETB    LCD_CE
        LCALL   T5MS
        MOV 	A,LCD_DB
        CLR     LCD_CE		;DB7:    0  LCD控制器空闲
        JB     	ACC.7,WTD_PA	;        1  LCD控制器忙
        POP     ACC
        RET

DRYL:  	MOV COM,#0DH       	; 显示开，光标关，闪耀开
        LCALL LCDWC
        MOV COM,A		; A=#8XH--第一行X位（闪耀）
				; A=#CYH--第二行Y位（闪耀）
        LCALL LCDWC
	RET



END
DT_ASC:	MOV A,@R0	; 把@R0的BCD码转换成ASCII码
	ANL A,#0FH	; 送显示缓冲单元--XX.X
	ORL A,#30H
	MOV @R1,A
	INC R0
	INC R1
	MOV A,@R0
	ANL A,#0F0H
	SWAP A
	ORL A,#30H
	MOV @R1,A
	INC R1
	MOV @R1,#2EH
	INC R1
	MOV A,@R0
	ANL A,#0FH
	ORL A,#30H
	MOV @R1,A
	RET
