VERSION 5.00
Begin VB.Form frm_start 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "�ܳɱ�����"
   ClientHeight    =   7515
   ClientLeft      =   150
   ClientTop       =   840
   ClientWidth     =   8040
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7515
   ScaleWidth      =   8040
   StartUpPosition =   3  '����ȱʡ
   Begin VB.Menu mnu_start 
      Caption         =   "�ļ�"
      Index           =   1
   End
   Begin VB.Menu mnu_former 
      Caption         =   "ԭ�гɱ�"
      Index           =   2
   End
   Begin VB.Menu mnu_improved 
      Caption         =   "�Ľ���ɱ�"
      Index           =   3
      Begin VB.Menu mnu_g2m 
         Caption         =   "�ӹ��ݵ�M������ɱ�"
         Index           =   4
      End
      Begin VB.Menu mnu_trasfer 
         Caption         =   "��ת�ɱ�"
         Index           =   6
      End
      Begin VB.Menu mnu_m2j 
         Caption         =   "��M�ǵ���j����������ɱ�"
         Index           =   5
      End
      Begin VB.Menu mnu_imp_sum 
         Caption         =   "�ܼ�"
         Index           =   7
      End
   End
   Begin VB.Menu mnu_compared 
      Caption         =   "�ۺϱȽ�"
      Index           =   8
   End
End
Attribute VB_Name = "frm_start"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub mnu_compared_Click(Index As Integer)
frm_sum.Show
End Sub

Private Sub mnu_former_Click(Index As Integer)
frm_former.Show
End Sub

Private Sub mnu_g2m_Click(Index As Integer)
frm_g2m.Show
End Sub

Private Sub mnu_m2j_Click(Index As Integer)
frm_m2j.Show
End Sub

Private Sub mnu_trasfer_Click(Index As Integer)
frm_zz.Show
End Sub
