VERSION 5.00
Begin VB.Form dlg_i_sea 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "输入第i种船只的相关参数"
   ClientHeight    =   3465
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   5910
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3465
   ScaleWidth      =   5910
   Begin VB.TextBox Text3 
      Height          =   375
      Left            =   360
      TabIndex        =   6
      Text            =   "Text3"
      Top             =   1560
      Width           =   2055
   End
   Begin VB.TextBox Text2 
      Height          =   375
      Left            =   360
      TabIndex        =   3
      Text            =   "Text2"
      Top             =   960
      Width           =   2055
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   360
      TabIndex        =   2
      Text            =   "Text1"
      Top             =   360
      Width           =   2055
   End
   Begin VB.CommandButton CancelButton 
      Caption         =   "完成"
      Height          =   375
      Left            =   3000
      TabIndex        =   1
      Top             =   2640
      Width           =   1215
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "载入"
      Height          =   375
      Left            =   840
      TabIndex        =   0
      Top             =   2640
      Width           =   1215
   End
   Begin VB.Label Label3 
      Caption         =   "第i种船只的单位运费（元 / 立方米）"
      Height          =   495
      Left            =   2640
      TabIndex        =   7
      Top             =   1680
      Width           =   3135
   End
   Begin VB.Label Label2 
      Caption         =   "第i种船只的载货体积（立方米）"
      Height          =   615
      Left            =   2640
      TabIndex        =   5
      Top             =   1080
      Width           =   2775
   End
   Begin VB.Label Label1 
      Caption         =   "第i种船只的保险费（元 / 次）"
      Height          =   495
      Left            =   2640
      TabIndex        =   4
      Top             =   480
      Width           =   2655
   End
End
Attribute VB_Name = "dlg_i_sea"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit



Private Sub CancelButton_Click()
dlg_i_sea.Hide

End Sub

Private Sub Form_Load()
Text1.Text = ""
Text2.Text = ""
Text3.Text = ""
End Sub

Private Sub OKButton_Click()
Static count_2%

count_2 = count_2 + 1
sea_i_shipno = count_2

'----------------------------


ReDim sea_i_insurec(1 To sea_i_shipno)
ReDim sea_i_loadv(1 To sea_i_shipno)
ReDim sea_i_unitc(1 To sea_i_shipno)

'-------------------------
sea_i_insurec(count_2) = Text1.Text
sea_i_loadv(count_2) = Text2.Text
sea_i_unitc(count_2) = Text3.Text





Text1.Text = ""
Text2.Text = ""
Text3.Text = ""

End Sub
