VERSION 5.00
Begin VB.Form frm_former 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "ԭ�гɱ�����"
   ClientHeight    =   6735
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6255
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6735
   ScaleWidth      =   6255
   StartUpPosition =   3  '����ȱʡ
   Begin VB.TextBox Text4 
      Height          =   375
      Left            =   120
      TabIndex        =   14
      Text            =   "Text4"
      Top             =   6000
      Width           =   2775
   End
   Begin VB.CommandButton Command5 
      Caption         =   "����ԭ�гɱ�"
      Height          =   375
      Left            =   3240
      TabIndex        =   13
      Top             =   6000
      Width           =   2775
   End
   Begin VB.Frame Frame1 
      Height          =   1935
      Left            =   120
      TabIndex        =   9
      Top             =   3720
      Width           =   6015
      Begin VB.CommandButton Command4 
         Caption         =   "ȷ��Xij"
         Height          =   375
         Left            =   3120
         TabIndex        =   12
         Top             =   1320
         Width           =   2775
      End
      Begin VB.ListBox List1 
         Height          =   1140
         ItemData        =   "frm_former.frx":0000
         Left            =   240
         List            =   "frm_former.frx":0002
         MultiSelect     =   1  'Simple
         TabIndex        =   11
         Top             =   600
         Width           =   2775
      End
      Begin VB.ComboBox Combo1 
         Height          =   300
         Left            =   240
         TabIndex        =   10
         Text            =   "Combo1"
         Top             =   240
         Width           =   2775
      End
   End
   Begin VB.CommandButton Command3 
      Caption         =   "����ӹ��ݵ�����Ŀ�ĵصľ���"
      Height          =   375
      Left            =   120
      TabIndex        =   8
      Top             =   3120
      Width           =   2775
   End
   Begin VB.CommandButton Command2 
      Caption         =   "����"
      Height          =   375
      Left            =   120
      TabIndex        =   7
      Top             =   2520
      Width           =   2775
   End
   Begin VB.TextBox Text3 
      Height          =   375
      Left            =   120
      TabIndex        =   3
      Text            =   "Text3"
      Top             =   1920
      Width           =   1575
   End
   Begin VB.TextBox Text2 
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Text            =   "Text2"
      Top             =   1320
      Width           =   1575
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Text            =   "Text1"
      Top             =   720
      Width           =   1575
   End
   Begin VB.CommandButton Command1 
      Caption         =   "�����i�ֳ�������ز���"
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2775
   End
   Begin VB.Label Label4 
      Caption         =   "Ŀ�ĳ��е���Ŀ"
      Height          =   375
      Left            =   1800
      TabIndex        =   6
      Top             =   2040
      Width           =   3375
   End
   Begin VB.Label Label3 
      Caption         =   "�������������������ף�"
      Height          =   375
      Left            =   1800
      TabIndex        =   5
      Top             =   1440
      Width           =   3255
   End
   Begin VB.Label Label2 
      Caption         =   "���ͼ۸�Ԫ/ �ֹ��"
      Height          =   375
      Left            =   1800
      TabIndex        =   4
      Top             =   840
      Width           =   3135
   End
End
Attribute VB_Name = "frm_former"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public fm_pp!, fm_tv!, fm_cityno




Private Sub Combo1_Click()
List1.Clear

For r = 1 To fm_carno
 If Combo1.Text = "��" & r & "�ֳ���" Then
  For q = 1 To fm_cityno
   List1.AddItem "ȥ��" & q & "������"
  Next q
 End If
Next r


End Sub

Private Sub Command1_Click()
dlg_i_car.Show
End Sub


Private Sub Command2_Click()
fm_pp = Text1.Text
fm_tv = Text2.Text
fm_cityno = Text3.Text


End Sub

Private Sub Command3_Click()

Dim i%, j%
Dim tocityd() As Integer
ReDim tocityd(1 To fm_cityno)      '����ط��ǹؼ�����������͹���

For i = 1 To fm_cityno
 tocityd(i) = InputBox("��������ݵ�����Ŀ�ĵصľ���")
Next i

ReDim fm_j_g2jd(1 To fm_cityno)

For j = 1 To fm_cityno
 fm_j_g2jd(j) = tocityd(j)
Next j
 



End Sub

Private Sub Command4_Click()

ReDim fm_xij(1 To fm_carno, 1 To fm_cityno)

For o = 1 To fm_carno
 If Combo1.Text = "��" & o & "�ֳ���" Then
  For p = 0 To (fm_cityno - 1)
   If List1.Selected(p) = True Then
    fm_xij(o, p + 1) = 1
   End If
  Next p
 End If
Next o

'���ü�����XIJ�Ƿ�ȷʵ����ȷ��ֵ

End Sub

Private Sub Command5_Click()

Dim sum
sum = 0

For j = 1 To fm_cityno
 For i = 1 To fm_carno
  sum = sum + fm_i_tno(i) * (fm_i_fmc(i) + 1 / 12 * fm_i_ic(i) + fm_i_cno(i) * fm_i_fc(i) * fm_j_g2jd(j) + (fm_i_cno(i) * fm_pp * fm_i_tw(i) * fm_j_g2jd(j) + fm_i_cno(i) * fm_i_rc(i) * fm_j_g2jd(j)) * fm_xij(i, j))
 Next i
Next j

fm_totalc = sum

Text4.Text = fm_totalc

End Sub


Private Sub Form_Load()

Text1.Text = ""
Text2.Text = ""
Text3.Text = ""
Text4.Text = ""
Combo1.Text = ""


End Sub
