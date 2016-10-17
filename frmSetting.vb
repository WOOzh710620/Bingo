Public Class frmSetting

    Private Sub tbSpeed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSpeed.Scroll
        lblSpeed.Text = tbSpeed.Value
    End Sub

    Private Sub tbSize_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSize.Scroll
        lblSize.Text = tbSize.Value
    End Sub

    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblSpeed.Text = tbSpeed.Value
        lblSize.Text = tbSize.Value
    End Sub
End Class