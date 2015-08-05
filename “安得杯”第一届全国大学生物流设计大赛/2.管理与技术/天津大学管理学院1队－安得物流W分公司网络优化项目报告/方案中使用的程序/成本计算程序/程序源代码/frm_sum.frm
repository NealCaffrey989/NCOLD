VERSION 5.00
Begin VB.Form frm_sum 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "综合比较"
   ClientHeight    =   3705
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5685
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3705
   ScaleWidth      =   5685
   StartUpPosition =   3  '窗口缺省
   Begin VB.CommandButton Command1 
      Caption         =   "显示结果"
      Height          =   375
      Left            =   240
      TabIndex        =   6
      Top             =   120
      Width           =   2055
   End
   Begin VB.TextBox Text3 
      Height          =   375
      Left            =   3120
      TabIndex        =   5
      Text            =   "Text3"
      Top             =   2040
      Width           =   2295
   End
   Begin VB.TextBox Text2 
      Height          =   375
      Left            =   3120
      TabIndex        =   4
      Text            =   "Text2"
      Top             =   1440
      Width           =   2295
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   3120
      TabIndex        =   3
      Text            =   "Text1"
      Top             =   840
      Width           =   2295
   End
   Begin VB.Label Label5 
      Height          =   495
      Left            =   2040
      TabIndex        =   8
      Top             =   2880
      Width           =   2895
   End
   Begin VB.Label Label4 
      Caption         =   "成本最小的是"
      Height          =   375
      Left            =   240
      TabIndex        =   7
      Top             =   2880
      Width           =   1455
   End
   Begin VB.Label Label3 
      Caption         =   "铁路-陆运联运的总成本："
      Height          =   255
      Left            =   240
      TabIndex        =   2
      Top             =   2040
      Width           =   2295
   End
   Begin VB.Label Label2 
      Caption         =   "只采用陆运的总成本："
      Height          =   255
      Left            =   240
      TabIndex        =   1
      Top             =   1440
      Width           =   2295
   End
   Begin VB.Label Label1 
      Caption         =   "海运-陆运联运的总成本："
      Height          =   255
      Left            =   240
      TabIndex        =   0
      Top             =   840
      Width           =   2295
   End
End
Attribute VB_Name = "frm_sum"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()

sum_hlc = sea_c + zz_c0 + mj_tc
sum_llc = qc_c + zz_c0 + mj_tc
sum_tlc = tr_c + zz_c0 + mj_tc

Text1.Text = sum_hlc
Text2.Text = sum_llc
Text3.Text = sum_tlc

Dim bijiao
If sum_hlc < sum_llc Then
bijiao = sum_hlc
Else
bijiao = sum_llc
End If
If bijiao < sum_tlc Then
bijiao = bijiao
Else
bijiao = sum_tlc
End If

sum_least = bijiao
Label5.Caption = sum_least

End Sub

Private Sub Form_Load()
Text1.Text = ""
Text2.Text = ""
Text3.Text = ""

End Sub
