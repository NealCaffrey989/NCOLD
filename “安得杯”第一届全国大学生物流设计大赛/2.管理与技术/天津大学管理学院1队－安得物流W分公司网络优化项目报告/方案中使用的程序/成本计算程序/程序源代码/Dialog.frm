VERSION 5.00
Begin VB.Form dlg_i_car 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "相关输入第i种车辆的相关参数"
   ClientHeight    =   5880
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   5325
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5880
   ScaleWidth      =   5325
   Begin VB.TextBox Text9 
      Height          =   375
      Left            =   5400
      TabIndex        =   17
      Text            =   "Text9"
      Top             =   6120
      Visible         =   0   'False
      Width           =   1695
   End
   Begin VB.TextBox Text8 
      Height          =   375
      Left            =   240
      TabIndex        =   16
      Text            =   "Text8"
      Top             =   4440
      Width           =   1695
   End
   Begin VB.TextBox Text7 
      Height          =   375
      Left            =   240
      TabIndex        =   8
      Text            =   "Text7"
      Top             =   3840
      Width           =   1695
   End
   Begin VB.TextBox Text6 
      Height          =   375
      Left            =   240
      TabIndex        =   7
      Text            =   "Text6"
      Top             =   3240
      Width           =   1695
   End
   Begin VB.TextBox Text5 
      Height          =   375
      Left            =   240
      TabIndex        =   6
      Text            =   "Text5"
      Top             =   2640
      Width           =   1695
   End
   Begin VB.TextBox Text4 
      Height          =   375
      Left            =   240
      TabIndex        =   5
      Text            =   "Text4"
      Top             =   2040
      Width           =   1695
   End
   Begin VB.TextBox Text3 
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Text            =   "Text3"
      Top             =   1440
      Width           =   1695
   End
   Begin VB.TextBox Text2 
      Height          =   375
      Left            =   240
      TabIndex        =   3
      Text            =   "Text2"
      Top             =   840
      Width           =   1695
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   2
      Text            =   "Text1"
      Top             =   240
      Width           =   1695
   End
   Begin VB.CommandButton CancelButton 
      Caption         =   "完成"
      Height          =   375
      Left            =   2880
      TabIndex        =   1
      Top             =   5160
      Width           =   1215
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "载入"
      Height          =   375
      Left            =   720
      TabIndex        =   0
      Top             =   5160
      Width           =   1215
   End
   Begin VB.Label Label8 
      Caption         =   "每次运送派出第i种车的数量"
      Height          =   375
      Left            =   2160
      TabIndex        =   18
      Top             =   4560
      Width           =   3975
   End
   Begin VB.Label Label7 
      Caption         =   "每个月第i种车的运送次数"
      Height          =   255
      Left            =   2160
      TabIndex        =   15
      Top             =   3960
      Width           =   3375
   End
   Begin VB.Label Label6 
      Caption         =   "第i种车辆的车货总重量（吨）"
      Height          =   255
      Left            =   2160
      TabIndex        =   14
      Top             =   3360
      Width           =   3375
   End
   Begin VB.Label Label5 
      Caption         =   "第i种车辆的载货体积（立方米）"
      Height          =   255
      Left            =   2160
      TabIndex        =   13
      Top             =   2760
      Width           =   3375
   End
   Begin VB.Label Label4 
      Caption         =   "第i种车辆的路桥费（元 / 车公里）"
      Height          =   255
      Left            =   2160
      TabIndex        =   12
      Top             =   2160
      Width           =   3375
   End
   Begin VB.Label Label3 
      Caption         =   "第i种车辆的固定费用（元 / 公里）"
      Height          =   255
      Left            =   2160
      TabIndex        =   11
      Top             =   1560
      Width           =   3375
   End
   Begin VB.Label Label2 
      Caption         =   "第i种车辆的保险费（元 / 年）"
      Height          =   255
      Left            =   2160
      TabIndex        =   10
      Top             =   960
      Width           =   3375
   End
   Begin VB.Label Label1 
      Caption         =   "第i种车辆的月固定费用（元 / 月）"
      Height          =   255
      Left            =   2160
      TabIndex        =   9
      Top             =   360
      Width           =   3375
   End
End
Attribute VB_Name = "dlg_i_car"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub CancelButton_Click()

For t = 1 To fm_carno
frm_former.Combo1.AddItem "第" & t & "种车辆"
Next t

dlg_i_car.Hide
End Sub

Private Sub Form_Load()
Text1(0).Text = ""
Text2.Text = ""
Text3.Text = ""
Text4.Text = ""
Text5.Text = ""
Text6.Text = ""
Text7.Text = ""
Text8.Text = ""
End Sub

Private Sub OKButton_Click()

Static count%

count = count + 1
fm_carno = count

'----------------------------


ReDim fm_i_fmc(1 To fm_carno)
ReDim fm_i_ic(1 To fm_carno)
ReDim fm_i_fc(1 To fm_carno)
ReDim fm_i_rc(1 To fm_carno)
ReDim fm_i_lv(1 To fm_carno)
ReDim fm_i_tw(1 To fm_carno)
ReDim fm_i_cno(1 To fm_carno)
ReDim fm_i_tno(1 To fm_carno)



fm_i_fmc(count) = Text1(0).Text
fm_i_ic(count) = Text2.Text
fm_i_fc(count) = Text3.Text
fm_i_rc(count) = Text4.Text
fm_i_lv(count) = Text5.Text
fm_i_tw(count) = Text6.Text
fm_i_cno(count) = Text7.Text
fm_i_tno(count) = Text8.Text


'-------------------------



Print fm_carno   '测试是否有效


Text1(0).Text = ""
Text2.Text = ""
Text3.Text = ""
Text4.Text = ""
Text5.Text = ""
Text6.Text = ""
Text7.Text = ""
Text8.Text = ""
Text9.Text = ""

End Sub
