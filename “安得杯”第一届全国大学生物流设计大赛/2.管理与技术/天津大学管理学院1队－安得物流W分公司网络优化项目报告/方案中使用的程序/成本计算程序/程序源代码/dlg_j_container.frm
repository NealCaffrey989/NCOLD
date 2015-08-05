VERSION 5.00
Begin VB.Form dlg_j_container 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "输入第j种尺柜的相关参数"
   ClientHeight    =   2955
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   5625
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2955
   ScaleWidth      =   5625
   Begin VB.TextBox Text3 
      Height          =   375
      Left            =   360
      TabIndex        =   4
      Text            =   "Text3"
      Top             =   1560
      Width           =   2055
   End
   Begin VB.TextBox Text2 
      Height          =   375
      Left            =   360
      TabIndex        =   3
      Text            =   "Text2"
      Top             =   840
      Width           =   2055
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   360
      TabIndex        =   2
      Text            =   "Text1"
      Top             =   120
      Width           =   2055
   End
   Begin VB.CommandButton CancelButton 
      Caption         =   "完成"
      Height          =   375
      Left            =   2880
      TabIndex        =   1
      Top             =   2280
      Width           =   1215
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "载入"
      Height          =   375
      Left            =   960
      TabIndex        =   0
      Top             =   2280
      Width           =   1215
   End
   Begin VB.Label Label3 
      Caption         =   "第j种尺柜的数量"
      Height          =   375
      Left            =   2640
      TabIndex        =   7
      Top             =   1560
      Width           =   2895
   End
   Begin VB.Label Label2 
      Caption         =   "第j种尺柜的载货体积（立方米）"
      Height          =   375
      Left            =   2640
      TabIndex        =   6
      Top             =   840
      Width           =   2895
   End
   Begin VB.Label Label1 
      Caption         =   "第j种尺柜的单位运费（元 / 个）"
      Height          =   375
      Left            =   2640
      TabIndex        =   5
      Top             =   120
      Width           =   2775
   End
End
Attribute VB_Name = "dlg_j_container"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CancelButton_Click()
dlg_j_container.Hide

End Sub

Private Sub Form_Load()
Text1.Text = ""
Text2.Text = ""
Text3.Text = ""
End Sub

Private Sub OKButton_Click()


Static count_3%

count_3 = count_3 + 1
con_j_no = count_3

'----------------------------


ReDim con_j_unitc(1 To con_j_no)
ReDim con_j_loadv(1 To con_j_no)
ReDim con_j_conno(1 To con_j_no)

'-------------------------
con_j_unitc(count_3) = Text1.Text
con_j_loadv(count_3) = Text2.Text
con_j_conno(count_3) = Text3.Text

Print con_j_no


Text1.Text = ""
Text2.Text = ""
Text3.Text = ""



End Sub
