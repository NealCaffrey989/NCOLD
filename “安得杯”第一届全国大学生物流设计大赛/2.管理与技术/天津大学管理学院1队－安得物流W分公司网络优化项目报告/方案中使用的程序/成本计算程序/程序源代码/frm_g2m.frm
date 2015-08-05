VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frm_g2m 
   Caption         =   "改进后成本"
   ClientHeight    =   7545
   ClientLeft      =   2385
   ClientTop       =   1605
   ClientWidth     =   7005
   LinkTopic       =   "Form1"
   ScaleHeight     =   7545
   ScaleWidth      =   7005
   Visible         =   0   'False
   Begin VB.Frame Frame3 
      BorderStyle     =   0  'None
      Caption         =   "Frame3"
      Height          =   7815
      Left            =   0
      TabIndex        =   54
      Top             =   360
      Width           =   7215
      Begin VB.CommandButton Command6 
         Caption         =   "需要拥有的第i种车的数量"
         Height          =   375
         Left            =   360
         TabIndex        =   61
         Top             =   1200
         Width           =   2295
      End
      Begin VB.TextBox Text24 
         Height          =   390
         Left            =   360
         TabIndex        =   58
         Text            =   "Text24"
         Top             =   465
         Width           =   1815
      End
      Begin VB.TextBox Text25 
         Height          =   270
         Left            =   360
         TabIndex        =   57
         Text            =   "Text25"
         Top             =   3840
         Visible         =   0   'False
         Width           =   1815
      End
      Begin VB.TextBox Text26 
         Height          =   375
         Left            =   1800
         TabIndex        =   56
         Text            =   "Text26"
         Top             =   6600
         Width           =   2055
      End
      Begin VB.CommandButton Command5 
         Caption         =   "计算公路运输成本"
         Height          =   375
         Left            =   4080
         TabIndex        =   55
         Top             =   6600
         Width           =   2055
      End
      Begin VB.Label Label19 
         Caption         =   "从广州到M城市的公路距离（公里）"
         Height          =   255
         Left            =   2400
         TabIndex        =   60
         Top             =   600
         Width           =   3015
      End
      Begin VB.Label Label24 
         Caption         =   "需要拥有的第i种车的数量"
         Height          =   255
         Left            =   2160
         TabIndex        =   59
         Top             =   3840
         Visible         =   0   'False
         Width           =   3255
      End
   End
   Begin MSComctlLib.TabStrip TabStrip1 
      Height          =   6735
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   7215
      _ExtentX        =   12726
      _ExtentY        =   11880
      MultiRow        =   -1  'True
      _Version        =   393216
      BeginProperty Tabs {1EFB6598-857C-11D1-B16A-00C0F0283628} 
         NumTabs         =   4
         BeginProperty Tab1 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "海路运输"
            Key             =   "海路运输"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab2 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "铁路运输"
            Key             =   "铁路运输"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab3 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "公路运输"
            Key             =   "公路运输"
            ImageVarType    =   2
         EndProperty
         BeginProperty Tab4 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "三种方式比较"
            Key             =   "三种方式比较"
            ImageVarType    =   2
         EndProperty
      EndProperty
   End
   Begin VB.Frame Frame2 
      BorderStyle     =   0  'None
      Caption         =   "Frame2"
      Height          =   7455
      Left            =   0
      TabIndex        =   10
      Top             =   240
      Width           =   7215
      Begin VB.TextBox Text19 
         Height          =   270
         Left            =   5160
         TabIndex        =   53
         Text            =   "Text19"
         Top             =   240
         Visible         =   0   'False
         Width           =   1575
      End
      Begin VB.TextBox Text23 
         Height          =   375
         Left            =   2520
         TabIndex        =   52
         Text            =   "Text23"
         Top             =   6720
         Width           =   1935
      End
      Begin VB.CommandButton Command4 
         Caption         =   "计算铁路运输成本"
         Height          =   375
         Left            =   4800
         TabIndex        =   51
         Top             =   6720
         Width           =   1935
      End
      Begin VB.ComboBox Combo2 
         Height          =   300
         Left            =   120
         TabIndex        =   49
         Text            =   "Combo2"
         Top             =   6360
         Width           =   1335
      End
      Begin VB.TextBox Text22 
         Height          =   270
         Left            =   120
         TabIndex        =   47
         Text            =   "Text22"
         Top             =   6000
         Width           =   1335
      End
      Begin VB.TextBox Text21 
         Height          =   270
         Left            =   120
         TabIndex        =   45
         Text            =   "Text21"
         Top             =   5640
         Width           =   1335
      End
      Begin VB.TextBox Text20 
         Height          =   270
         Left            =   120
         TabIndex        =   43
         Text            =   "Text20"
         Top             =   5280
         Width           =   1335
      End
      Begin VB.TextBox Text18 
         Height          =   270
         Left            =   120
         TabIndex        =   41
         Text            =   "Text18"
         Top             =   4920
         Width           =   1335
      End
      Begin VB.TextBox Text17 
         Height          =   270
         Left            =   120
         TabIndex        =   39
         Text            =   "Text17"
         Top             =   4560
         Width           =   1335
      End
      Begin VB.TextBox Text16 
         Height          =   270
         Left            =   120
         TabIndex        =   37
         Text            =   "Text16"
         Top             =   4200
         Width           =   1335
      End
      Begin VB.TextBox Text15 
         Height          =   270
         Left            =   120
         TabIndex        =   35
         Text            =   "Text15"
         Top             =   3840
         Width           =   1335
      End
      Begin VB.TextBox Text14 
         Height          =   270
         Left            =   120
         TabIndex        =   33
         Text            =   "Text14"
         Top             =   3480
         Width           =   1335
      End
      Begin VB.TextBox Text13 
         Height          =   270
         Left            =   120
         TabIndex        =   31
         Text            =   "Text13"
         Top             =   3120
         Width           =   1335
      End
      Begin VB.TextBox Text12 
         Height          =   270
         Left            =   120
         TabIndex        =   29
         Text            =   "Text12"
         Top             =   2760
         Width           =   1335
      End
      Begin VB.TextBox Text11 
         Height          =   270
         Left            =   120
         TabIndex        =   27
         Text            =   "Text11"
         Top             =   2400
         Width           =   1335
      End
      Begin VB.TextBox Text10 
         Height          =   270
         Left            =   120
         TabIndex        =   25
         Text            =   "Text10"
         Top             =   2040
         Width           =   1335
      End
      Begin VB.ComboBox Combo1 
         Height          =   300
         Left            =   120
         TabIndex        =   23
         Text            =   "Combo1"
         Top             =   1680
         Width           =   1335
      End
      Begin VB.TextBox Text9 
         Height          =   270
         Left            =   120
         TabIndex        =   21
         Text            =   "Text9"
         Top             =   1320
         Width           =   1335
      End
      Begin VB.TextBox Text8 
         Height          =   270
         Left            =   120
         TabIndex        =   19
         Text            =   "Text8"
         Top             =   960
         Width           =   1335
      End
      Begin VB.TextBox Text7 
         Height          =   270
         Left            =   120
         TabIndex        =   17
         Text            =   "Text7"
         Top             =   600
         Width           =   1335
      End
      Begin VB.TextBox Text6 
         Height          =   270
         Left            =   120
         TabIndex        =   15
         Text            =   "Text6"
         Top             =   240
         Width           =   1335
      End
      Begin VB.Label Label8 
         Caption         =   "货物总体积（立方米）"
         Height          =   255
         Left            =   1560
         TabIndex        =   22
         Top             =   1320
         Width           =   3015
      End
      Begin VB.Label Label9 
         Caption         =   "所采用的集装箱"
         Height          =   255
         Left            =   1560
         TabIndex        =   24
         Top             =   1680
         Width           =   3375
      End
      Begin VB.Label Label23 
         Caption         =   "是否保价"
         Height          =   255
         Left            =   1560
         TabIndex        =   50
         Top             =   6360
         Width           =   2895
      End
      Begin VB.Label Label22 
         Caption         =   "货物总价值"
         Height          =   255
         Left            =   1560
         TabIndex        =   48
         Top             =   6000
         Width           =   3495
      End
      Begin VB.Label Label21 
         Caption         =   "货物保价费率"
         Height          =   255
         Left            =   1560
         TabIndex        =   46
         Top             =   5640
         Width           =   2535
      End
      Begin VB.Label Label20 
         Caption         =   "货物作业装卸费（元 / 立方米）"
         Height          =   255
         Left            =   1560
         TabIndex        =   44
         Top             =   5280
         Width           =   3615
      End
      Begin VB.Label Label18 
         Caption         =   "押运人个数（个）"
         Height          =   255
         Left            =   1560
         TabIndex        =   42
         Top             =   4920
         Width           =   4575
      End
      Begin VB.Label Label17 
         Caption         =   "押运人乘车费（元 / 人百公里）"
         Height          =   255
         Left            =   1560
         TabIndex        =   40
         Top             =   4560
         Width           =   4215
      End
      Begin VB.Label Label16 
         Caption         =   "货车中转技术作业费（元/吨，每满250公里）"
         Height          =   255
         Left            =   1560
         TabIndex        =   38
         Top             =   4200
         Width           =   4215
      End
      Begin VB.Label Label15 
         Caption         =   "机车作业时间（小时）"
         Height          =   255
         Left            =   1560
         TabIndex        =   36
         Top             =   3840
         Width           =   3375
      End
      Begin VB.Label Label14 
         Caption         =   "机车作业费（元/半小时）"
         Height          =   255
         Left            =   1560
         TabIndex        =   34
         Top             =   3480
         Width           =   3135
      End
      Begin VB.Label Label13 
         Caption         =   "取送车辆的承载量（立方米）"
         Height          =   255
         Left            =   1560
         TabIndex        =   32
         Top             =   3120
         Width           =   3495
      End
      Begin VB.Label Label7 
         Caption         =   "发到基价 （元 / 箱）"
         Height          =   255
         Left            =   1560
         TabIndex        =   20
         Top             =   960
         Width           =   2775
      End
      Begin VB.Label Label6 
         Caption         =   "运行基价（元 / 吨公里）"
         Height          =   255
         Left            =   1560
         TabIndex        =   18
         Top             =   600
         Width           =   2655
      End
      Begin VB.Label Label5 
         Caption         =   "从广州到M城市的铁路距离（公里）"
         Height          =   255
         Left            =   1560
         TabIndex        =   16
         Top             =   240
         Width           =   2895
      End
      Begin VB.Label Label10 
         Caption         =   "表格材料费（元 / 个）"
         Height          =   255
         Left            =   1560
         TabIndex        =   26
         Top             =   2040
         Width           =   3615
      End
      Begin VB.Label Label11 
         Caption         =   "取送车费（元 / 车公里）"
         Height          =   255
         Left            =   1560
         TabIndex        =   28
         Top             =   2400
         Width           =   2895
      End
      Begin VB.Label Label12 
         Caption         =   "火车站到中转点的距离（公里）"
         Height          =   255
         Left            =   1560
         TabIndex        =   30
         Top             =   2760
         Width           =   2895
      End
   End
   Begin VB.Frame Frame1 
      BorderStyle     =   0  'None
      Caption         =   "Frame1"
      Height          =   7575
      Left            =   0
      TabIndex        =   1
      Top             =   240
      Width           =   7215
      Begin VB.TextBox Text5 
         Height          =   375
         Left            =   480
         TabIndex        =   13
         Text            =   "Text5"
         Top             =   3840
         Width           =   2295
      End
      Begin VB.CommandButton Command3 
         Caption         =   "计算海路运输成本"
         Height          =   375
         Left            =   4320
         TabIndex        =   12
         Top             =   6720
         Width           =   2295
      End
      Begin VB.TextBox Text4 
         Height          =   375
         Left            =   1920
         TabIndex        =   11
         Text            =   "Text4"
         Top             =   6720
         Width           =   2055
      End
      Begin VB.CommandButton Command2 
         Caption         =   "输入第j种尺柜的相关参数"
         Height          =   375
         Left            =   480
         TabIndex        =   6
         Top             =   960
         Width           =   2295
      End
      Begin VB.CommandButton Command1 
         Caption         =   "输入第i种船只的相关参数"
         Height          =   375
         Left            =   480
         TabIndex        =   5
         Top             =   240
         Width           =   2295
      End
      Begin VB.TextBox Text3 
         Height          =   375
         Left            =   480
         TabIndex        =   4
         Text            =   "Text3"
         Top             =   3120
         Width           =   2295
      End
      Begin VB.TextBox Text2 
         Height          =   375
         Left            =   480
         TabIndex        =   3
         Text            =   "Text2"
         Top             =   2400
         Width           =   2295
      End
      Begin VB.TextBox Text1 
         Height          =   375
         Left            =   480
         TabIndex        =   2
         Text            =   "Text1"
         Top             =   1680
         Width           =   2295
      End
      Begin VB.Label Label2 
         Caption         =   "装卸费（元 /立方米）"
         Height          =   375
         Left            =   3000
         TabIndex        =   8
         Top             =   2400
         Width           =   2895
      End
      Begin VB.Label Label4 
         Caption         =   "运输货物总体积（立方米）"
         Height          =   375
         Left            =   3000
         TabIndex        =   14
         Top             =   3840
         Width           =   2895
      End
      Begin VB.Label Label3 
         Caption         =   "从广州到M城市的海运距离（公里）"
         Height          =   375
         Left            =   3000
         TabIndex        =   9
         Top             =   3120
         Width           =   3495
      End
      Begin VB.Label Label1 
         Caption         =   "拖车短拨费（元）"
         Height          =   375
         Left            =   3000
         TabIndex        =   7
         Top             =   1680
         Width           =   2655
      End
   End
   Begin VB.Frame Frame4 
      BorderStyle     =   0  'None
      Caption         =   "Frame4"
      Height          =   7575
      Left            =   0
      TabIndex        =   62
      Top             =   240
      Width           =   7215
   End
End
Attribute VB_Name = "frm_g2m"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
dlg_i_sea.Show
End Sub

Private Sub Command2_Click()
dlg_j_container.Show
End Sub

Private Sub Command3_Click()

sea_trailerc = Text1.Text
sea_zxc = Text2.Text
sea_g2md = Text3.Text
sea_totalv = Text5.Text

'--------------------------------------

'For i = 1 To sea_i_shipno
'sea_c_1 = sea_c_1 + sea_i_unitc(i) * sea_i_loadv(i)
'Next i

For j = 1 To con_j_no
sea_c_2 = sea_c_2 + con_j_unitc(j) * con_j_conno(j)
Next j

For i = 1 To sea_i_shipno
sea_c_3 = sea_c_3 + sea_i_insurec(i)
Next i

sea_c = sea_c_2 + sea_c_3 + sea_zxc * sea_totalv + sea_trailerc

Text4.Text = sea_c

End Sub

Private Sub Command4_Click()

tr_g2md = Text6.Text
tr_p = Text7.Text
tr_q = Text8.Text
tr_v = Text9.Text

If Combo1.Text = "1吨位集装箱" Then
 tr_vi = 1.21
 ElseIf Combo1.Text = "5吨位集装箱" Then
 tr_vi = 9.5
End If

tr_n = tr_v / tr_vi + 1

If Combo1.Text = "1吨位集装箱" Then
 tr_mi = 1000
 ElseIf Combo1.Text = "5吨位集装箱" Then
 tr_mi = 5000
End If

If Combo1.Text = "1吨位集装箱" Then
 tr_gi = 1.5
 ElseIf Combo1.Text = "5吨位集装箱" Then
 tr_gi = 7.5
End If

tr_b = Text10.Text
tr_qc = Text11.Text
tr_s = Text12.Text
tr_e = Text13.Text

tr_cheno = tr_v / tr_e

tr_j = Text14.Text
tr_t = Text15.Text

Dim tr_h250!
tr_h250 = Text16.Text
tr_h = tr_h250 * (tr_g2md \ 250)

tr_y = Text17.Text
tr_m = Text18.Text

If tr_g2md <= 500 Then
 tr_buc = 50
 ElseIf tr_g2md > 500 Then
 tr_buc = 70
End If

tr_z = Text20.Text
tr_f = Text21.Text
tr_d = Text22.Text
tr_a = tr_f * tr_d

If Combo2.Text = "保价" Then
 tr_w = 1
 ElseIf Combo2.Text = "不保价" Then
 tr_w = 0
End If


'集装箱使用费计算tr_u：   SM3  tr_g2md

If Combo1.Text = "1吨位集装箱" And tr_g2md <= 500 Then
tr_u = 5
ElseIf Combo1.Text = "1吨位集装箱" And tr_g2md > 500 And tr_g2md <= 2000 Then
tr_u = 5 + (tr_g2md - 500) / 100 * 0.4
ElseIf Combo1.Text = "1吨位集装箱" And tr_g2md > 2000 And tr_g2md <= 3000 Then
tr_u = 5 + 1500 / 100 * 0.4 + (tr_g2md - 2000) / 100 * 0.2
ElseIf Combo1.Text = "1吨位集装箱" And tr_g2md > 3000 Then
tr_u = 13
ElseIf Combo1.Text = "5吨位集装箱" And tr_g2md <= 500 Then
tr_u = 30
ElseIf Combo1.Text = "5吨位集装箱" And tr_g2md > 500 And tr_g2md <= 2000 Then
tr_u = 30 + (tr_g2md - 500) / 100 * 3
ElseIf Combo1.Text = "5吨位集装箱" And tr_g2md > 2000 And tr_g2md <= 3000 Then
tr_u = 30 + 1500 / 100 * 3 + (tr_g2md - 2000) / 100 * 1.5
ElseIf Combo1.Text = "5吨位集装箱" And tr_g2md > 3000 Then
tr_u = 90
End If


'直接计算最终结果，关于i的几个值已经确定
tr_c = (tr_g2md * tr_p + tr_q) * tr_n + tr_gi * tr_n + tr_b * tr_n + tr_qc * tr_cheno * 2 * tr_s + 2 * tr_j * tr_t + tr_h * tr_n * tr_mi + tr_y * tr_m * tr_g2md / 100 + tr_buc * tr_n + tr_u * tr_n + tr_z * tr_v + tr_a * tr_w

Text23.Text = tr_c


End Sub

Private Sub Command5_Click()

qc_g2md = Text24.Text

Dim sum_2!, sum_3!, qc_c1!, qc_c2!
ReDim qc_xi(1 To fm_carno)
For opt = 1 To fm_carno
 sum_2 = sum_2 + qc_xi(opt) * (fm_i_fmc(opt) + 1 / 12 * fm_i_ic(opt))
Next opt

For opo = 1 To fm_carno
 sum_3 = sum_3 + fm_i_tno(opo) * (fm_i_cno(opo) * fm_i_fc(opo) * qc_g2md + fm_i_cno(opo) * fm_pp * fm_i_tw(opo) * qc_g2md + fm_i_cno(opo) * fm_i_rc(opo) * qc_g2md)
Next opo

qc_c = sum_2 + sum_3

Text26.Text = qc_c








End Sub

Private Sub Command6_Click()

ReDim qc_xi(1 To fm_carno)
For no1 = 1 To fm_carno
qc_xi(no1) = InputBox("需要拥有第i种车的数量")
Next no1




End Sub

Private Sub Form_Load()

Frame1.ZOrder 0

Combo1.AddItem "1吨位集装箱"
Combo1.AddItem "5吨位集装箱"

Combo2.AddItem "保价"
Combo2.AddItem "不保价"

Dim sss%, text_no$
For sss = 1 To 25
 text_no = "text" & sss
 Controls(text_no).Text = ""
Next sss

'不用控件数组，如何使控件名用变量操作


End Sub

Private Sub TabStrip1_Click()
qq = TabStrip1.SelectedItem.Key

Select Case qq
Case "海路运输"
Frame1.ZOrder 0
Case "铁路运输"
Frame2.ZOrder 0
Case "公路运输"
Frame3.ZOrder 0
Case "总计"
Frame4.ZOrder 0
End Select

End Sub

