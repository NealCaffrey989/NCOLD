VERSION 5.00
Begin VB.Form frm_m2j 
   Caption         =   "Form1"
   ClientHeight    =   3390
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6960
   LinkTopic       =   "Form1"
   ScaleHeight     =   3390
   ScaleWidth      =   6960
   StartUpPosition =   3  '����ȱʡ
   Begin VB.CommandButton Command2 
      Caption         =   "�������תվM�ǵ�����j���еľ���"
      Height          =   375
      Left            =   360
      TabIndex        =   3
      Top             =   840
      Width           =   3015
   End
   Begin VB.CommandButton Command1 
      Caption         =   "����תվM�ǵ�����j���еĳɱ�����"
      Height          =   375
      Left            =   3720
      TabIndex        =   2
      Top             =   2280
      Width           =   3015
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   960
      TabIndex        =   1
      Text            =   "Text1"
      Top             =   2280
      Width           =   2535
   End
   Begin VB.Label Label1 
      Caption         =   "��������ʹ�øĽ�ǰ�ɱ�����Ĳ���"
      Height          =   375
      Left            =   360
      TabIndex        =   0
      Top             =   240
      Width           =   4455
   End
End
Attribute VB_Name = "frm_m2j"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()

Dim sum
sum = 0

For j = 1 To fm_cityno
 For i = 1 To fm_carno
  sum = sum + fm_i_tno(i) * (fm_i_fmc(i) + 1 / 12 * fm_i_ic(i) + fm_i_cno(i) * fm_i_fc(i) * mj_sj(j) + (fm_i_cno(i) * fm_pp * fm_i_tw(i) * mj_sj(j) + fm_i_cno(i) * fm_i_rc(i) * mj_sj(j)) * fm_xij(i, j))
 Next i
Next j

mj_tc = sum

Text1.Text = mj_tc


End Sub

Private Sub Command2_Click()
ReDim mj_sj(1 To fm_cityno)
For x9 = 1 To fm_cityno
 mj_sj(x9) = InputBox("������M������j���еľ���")
 
Next x9
 

End Sub
