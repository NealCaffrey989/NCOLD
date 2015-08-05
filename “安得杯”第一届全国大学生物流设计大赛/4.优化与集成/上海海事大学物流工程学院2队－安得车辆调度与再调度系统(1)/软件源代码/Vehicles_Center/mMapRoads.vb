Module mMapRoads
    Public Class CMapRoads '动态添加道路类
        Public Event Click(ByVal ItemNumber As Int16)
        Private ReadOnly ParentForm As System.Windows.Forms.Form
        Private LabelItem(31) As System.Windows.Forms.Label
        Private intBtnNumber As Int16
        Public Sub New(ByVal Form As System.Windows.Forms.Form)
            Dim i As Int16
            ParentForm = Form
            intBtnNumber = 0
            For i = 0 To 31
                LabelItem(i) = New System.Windows.Forms.Label
                LabelItem(i).Visible = False
                ParentForm.Controls.Add(LabelItem(i))
            Next
        End Sub
        Default Public ReadOnly Property Item(ByVal index As Int16) As System.Windows.Forms.Label
            Get
                Return LabelItem(index)
            End Get
        End Property
        Public Sub AddItem(ByVal x As Int16, ByVal y As Int16, ByVal Text As String)
            LabelItem(intBtnNumber).Tag = intBtnNumber
            LabelItem(intBtnNumber).Top = y
            LabelItem(intBtnNumber).Left = x
            LabelItem(intBtnNumber).Height = 20
            LabelItem(intBtnNumber).AutoSize = True
            LabelItem(intBtnNumber).Text = Text
            LabelItem(intBtnNumber).Visible = True
            LabelItem(intBtnNumber).SendToBack()
            AddHandler LabelItem(intBtnNumber).Click, AddressOf LabelItem_Click '绑定事件处理程序
            intBtnNumber += 1
        End Sub
        Public Sub RemoveItem()
            If intBtnNumber > 0 Then
                LabelItem(intBtnNumber - 1).Visible = False
                intBtnNumber -= 1
            End If
        End Sub
        Public Sub ClearAll()
            Do
                RemoveItem()
            Loop Until intBtnNumber = 0
        End Sub
        Public Sub LabelItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            RaiseEvent Click(CType(CType(sender, Label).Tag, Int16))
        End Sub
    End Class
End Module
