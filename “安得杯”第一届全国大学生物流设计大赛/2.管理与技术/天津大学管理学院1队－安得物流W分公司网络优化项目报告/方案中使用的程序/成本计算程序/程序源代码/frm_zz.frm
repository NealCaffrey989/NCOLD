VERSION 5.00
Begin VB.Form frm_zz 
   Caption         =   "��ת�ɱ�"
   ClientHeight    =   6525
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   8235
   LinkTopic       =   "Form1"
   ScaleHeight     =   6525
   ScaleWidth      =   8235
   StartUpPosition =   3  '����ȱʡ
   Begin VB.CommandButton Command1 
      Caption         =   "��תվ�ɱ�����"
      Height          =   375
      Left            =   5520
      TabIndex        =   21
      Top             =   5880
      Width           =   2175
   End
   Begin VB.TextBox Text10 
      Height          =   375
      Left            =   3120
      TabIndex        =   20
      Text            =   "Text10"
      Top             =   5880
      Width           =   2175
   End
   Begin VB.ComboBox Combo1 
      Height          =   300
      Left            =   240
      TabIndex        =   18
      Text            =   "Combo1"
      Top             =   4440
      Width           =   1815
   End
   Begin VB.TextBox Text9 
      Height          =   270
      Left            =   240
      TabIndex        =   16
      Text            =   "Text9"
      Top             =   3960
      Width           =   1815
   End
   Begin VB.TextBox Text8 
      Height          =   270
      Left            =   240
      TabIndex        =   7
      Text            =   "Text8"
      Top             =   3480
      Width           =   1815
   End
   Begin VB.TextBox Text7 
      Height          =   270
      Left            =   240
      TabIndex        =   6
      Text            =   "Text7"
      Top             =   3000
      Width           =   1815
   End
   Begin VB.TextBox Text6 
      Height          =   270
      Left            =   240
      TabIndex        =   5
      Text            =   "Text6"
      Top             =   2520
      Width           =   1815
   End
   Begin VB.TextBox Text5 
      Height          =   270
      Left            =   240
      TabIndex        =   4
      Text            =   "Text5"
      Top             =   2040
      Width           =   1815
   End
   Begin VB.TextBox Text4 
      Height          =   270
      Left            =   240
      TabIndex        =   3
      Text            =   "Text4"
      Top             =   1560
      Width           =   1815
   End
   Begin VB.TextBox Text3 
      Height          =   270
      Left            =   240
      TabIndex        =   2
      Text            =   "Text3"
      Top             =   1080
      Width           =   1815
   End
   Begin VB.TextBox Text2 
      Height          =   270
      Left            =   240
      TabIndex        =   1
      Text            =   "Text2"
      Top             =   600
      Width           =   1815
   End
   Begin VB.TextBox Text1 
      Height          =   270
      Left            =   240
      TabIndex        =   0
      Text            =   "Text1"
      Top             =   120
      Width           =   1815
   End
   Begin VB.Label Label10 
      Caption         =   "�Ƿ���������гɱ�"
      Height          =   255
      Left            =   2280
      TabIndex        =   19
      Top             =   4440
      Width           =   4335
   End
   Begin VB.Label Label9 
      Caption         =   "�ֿ��޸ߣ��ף�"
      Height          =   255
      Left            =   2280
      TabIndex        =   17
      Top             =   3960
      Width           =   4335
   End
   Begin VB.Label Label8 
      Caption         =   "������ת������������ף�"
      Height          =   255
      Left            =   2280
      TabIndex        =   15
      Top             =   3480
      Width           =   5295
   End
   Begin VB.Label Label7 
      Caption         =   "���Ƶ��"
      Height          =   255
      Left            =   2280
      TabIndex        =   14
      Top             =   3000
      Width           =   4935
   End
   Begin VB.Label Label6 
      Caption         =   "������ڣ��죩"
      Height          =   255
      Left            =   2280
      TabIndex        =   13
      Top             =   2520
      Width           =   4935
   End
   Begin VB.Label Label5 
      Caption         =   "������гɱ�ռ��λ��Ʒ��ֵ�ı���"
      Height          =   255
      Left            =   2280
      TabIndex        =   12
      Top             =   2040
      Width           =   5175
   End
   Begin VB.Label Label4 
      Caption         =   "��λ��Ʒ�ļ�ֵ"
      Height          =   255
      Left            =   2280
      TabIndex        =   11
      Top             =   1560
      Width           =   5055
   End
   Begin VB.Label Label3 
      Caption         =   "�ֿ����Ԫ / ƽ���ס��죩"
      Height          =   255
      Left            =   2280
      TabIndex        =   10
      Top             =   1080
      Width           =   4575
   End
   Begin VB.Label Label2 
      Caption         =   "װж�ѣ�Ԫ / ����"
      Height          =   255
      Left            =   2280
      TabIndex        =   9
      Top             =   600
      Width           =   4455
   End
   Begin VB.Label Label1 
      Caption         =   "�̲���ת�ѣ�Ԫ / ����"
      Height          =   255
      Left            =   2280
      TabIndex        =   8
      Top             =   120
      Width           =   3375
   End
End
Attribute VB_Name = "frm_zz"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()

zz_d0 = Text1.Text
zz_d1 = Text2.Text
zz_d2 = Text3.Text
zz_uc = Text4.Text
zz_i = Text5.Text
zz_d3 = zz_uc * zz_i
zz_t = Text6.Text
zz_f = Text7.Text
zz_v = Text8.Text
zz_h = Text9.Text

If Combo1.Text = "�ִ��������Ҫ�Ʒ�" Then
 zz_y = 1
 ElseIf Combo1.Text = "�ִ����С������Ʒ�" Then
 zz_y = 0
End If

zz_c0 = zz_v * (zz_d0 + zz_d1) + zz_y * zz_d2 * zz_v / zz_h * zz_t + zz_uc * zz_i * zz_v

Text10.Text = zz_c0




End Sub

Private Sub Form_Load()
Dim aq, aq_1$

For aq = 1 To 10
 aq_1 = "text" & aq
 Controls(aq_1).Text = ""
Next aq

Combo1.AddItem "�ִ��������Ҫ�Ʒ�"
Combo1.AddItem "�ִ����С������Ʒ�"

End Sub
