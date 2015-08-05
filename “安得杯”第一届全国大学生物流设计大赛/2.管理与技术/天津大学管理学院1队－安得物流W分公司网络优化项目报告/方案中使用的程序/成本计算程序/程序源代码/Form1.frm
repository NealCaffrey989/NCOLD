VERSION 5.00
Begin VB.Form frm_start 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "总成本计算"
   ClientHeight    =   7515
   ClientLeft      =   150
   ClientTop       =   840
   ClientWidth     =   8040
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7515
   ScaleWidth      =   8040
   StartUpPosition =   3  '窗口缺省
   Begin VB.Menu mnu_start 
      Caption         =   "文件"
      Index           =   1
   End
   Begin VB.Menu mnu_former 
      Caption         =   "原有成本"
      Index           =   2
   End
   Begin VB.Menu mnu_improved 
      Caption         =   "改进后成本"
      Index           =   3
      Begin VB.Menu mnu_g2m 
         Caption         =   "从广州到M城运输成本"
         Index           =   4
      End
      Begin VB.Menu mnu_trasfer 
         Caption         =   "中转成本"
         Index           =   6
      End
      Begin VB.Menu mnu_m2j 
         Caption         =   "从M城到第j个城市运输成本"
         Index           =   5
      End
      Begin VB.Menu mnu_imp_sum 
         Caption         =   "总计"
         Index           =   7
      End
   End
   Begin VB.Menu mnu_compared 
      Caption         =   "综合比较"
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
