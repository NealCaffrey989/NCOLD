Module mMapPoints
    Public Class CMappoints '动态添加节点类
        Public Event Click(ByVal ItemNumber As Int16)
        Private ReadOnly ParentForm As System.Windows.Forms.Form
        Private btnItem(7) As System.Windows.Forms.Button
        Private intBtnNumber As Int16
        Public Sub New(ByVal Form As System.Windows.Forms.Form)
            Dim i As Int16
            ParentForm = Form
            intBtnNumber = 0
            For i = 0 To 7
                btnItem(i) = New System.Windows.Forms.Button
                btnItem(i).Visible = False
                ParentForm.Controls.Add(btnItem(i))
            Next
        End Sub
        Default Public ReadOnly Property Item(ByVal index As Int16) As System.Windows.Forms.Button
            Get
                Return btnItem(index)
            End Get
        End Property
        Public Sub AddItem(ByVal x As Int16, ByVal y As Int16)
            btnItem(intBtnNumber).Tag = intBtnNumber
            btnItem(intBtnNumber).Top = y - 20
            btnItem(intBtnNumber).Left = x - 20
            btnItem(intBtnNumber).Height = 40
            btnItem(intBtnNumber).Width = 40
            btnItem(intBtnNumber).Text = (intBtnNumber).ToString
            btnItem(intBtnNumber).Visible = True
            btnItem(intBtnNumber).SendToBack()
            AddHandler btnItem(intBtnNumber).Click, AddressOf btnItem_Click '绑定事件处理程序
            intBtnNumber += 1
        End Sub
        Public Sub RemoveItem()
            If intBtnNumber > 0 Then
                btnItem(intBtnNumber - 1).Visible = False
                intBtnNumber -= 1
            End If
        End Sub
        Public Sub ClearAll()
            Do
                RemoveItem()
            Loop Until intBtnNumber = 0
        End Sub
        Public Sub btnItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            RaiseEvent Click(CType(CType(sender, Button).Tag, Int16))
        End Sub
    End Class
End Module