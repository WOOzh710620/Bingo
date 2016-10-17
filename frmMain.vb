Public Class frmMain

    Private _gstrTmp As String = ""   '記錄輸入數字暫存的數值
    Private _aryNumber() As String
    Private _arySortNumber() As String
    Private _isSort As Boolean = False
    Private tmpColor As Color
    Private _TotalNumbertmpColor As Color
    Private _numRenge As Integer = 0
    Private _intSize As Integer = 48
    Private _intTime As Integer = 200

    Private Sub btnGetNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetNumber.Click

        _numRenge = txtEnd.Text.Trim - txtStart.Text.Trim
        If Not Me._aryNumber Is Nothing AndAlso _numRenge <= Me._aryNumber.GetUpperBound(0) Then
            MsgBox("所有數已取完")
            txtTotalNumber.BackColor = Color.Gray
            Exit Sub
        End If

        lblNumber.BackColor = Color.Gray
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim tmieInterval As Integer = 15

        If Timer1.Interval + tmieInterval > Me._intTime Then
            Timer1.Enabled = False
            Timer1.Interval = 50
            If Me._aryNumber Is Nothing Then
                ReDim Me._aryNumber(0)
            Else
                ReDim Preserve _aryNumber(UBound(_aryNumber) + 1)
            End If
            _aryNumber(UBound(_aryNumber)) = lblNumber.Text
            ShowNumbers(Me._aryNumber)
            lblNumber.BackColor = tmpColor
        Else
            Timer1.Interval = Timer1.Interval + tmieInterval
            lblNumber.Text = GetNumber().ToString
        End If
    End Sub
    Private Sub ShowNumbers(ByVal aryNumber() As String)
        Dim i As Integer
        Dim tmpString As String = ""
        Dim insertString As String = " , "

        For i = 0 To aryNumber.GetUpperBound(0)
            tmpString = tmpString & aryNumber(i).Trim & insertString
        Next
        tmpString = Microsoft.VisualBasic.Left(tmpString, tmpString.Length - insertString.Length)
        txtTotalNumber.Text = tmpString
    End Sub
    Private Function GetNumber() As Integer
        Dim rndNumber As Integer = 0
        Dim rndMax As Integer = CInt(txtEnd.Text.Trim)
        Dim rndMin As Integer = CInt(txtStart.Text.Trim)

        Randomize(Now.Millisecond)  ''更新亂數種子
        rndNumber = Int((rndMax - rndMin + 1) * Rnd()) + rndMin   '設定資料後段要寫入多少個亂數
        If CheckNumberTheSame(rndNumber.ToString, _aryNumber) Then
            rndNumber = GetNumber()
        End If

        Return rndNumber

    End Function
    Private Function CheckNumberTheSame(ByVal strNumber As String, ByRef aryNumber() As String) As Boolean
        ''檢查號碼是否重覆
        Dim i As Integer
        If aryNumber Is Nothing Then
            Return False
        End If
        For i = 0 To UBound(aryNumber)
            If strNumber = aryNumber(i) Then Return True
        Next
        Return False
    End Function


    Private Sub txtEnd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEnd.KeyDown, txtStart.KeyDown
        Dim myTxtBox As TextBox = Nothing
        myTxtBox = sender
        _gstrTmp = myTxtBox.Text
    End Sub

    Private Sub txtStart_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStart.TextChanged, txtEnd.TextChanged
        Try
            ''判斷是否為數字,若不是則把暫存內容值填入
            Dim myTxtBox As TextBox = Nothing
            myTxtBox = sender
            If myTxtBox.Text.Trim.Length > 0 Then
                ''限制只能輸入正數,不包含小數,不能有","
                ''因為IsNumeric 對於"," 會視為數字的一種
                ''若要有正負號則把InStr(myTxtBox.Text, "-") > 0 這個條件刪除
                If IsNumeric(myTxtBox.Text) = False _
                        Or InStr(myTxtBox.Text, " ") > 0 _
                        Or InStr(myTxtBox.Text, ",") > 0 _
                        Or InStr(myTxtBox.Text, ".") > 0 _
                        Or InStr(myTxtBox.Text, "-") > 0 Then
                    myTxtBox.Text = _gstrTmp '若其中一個條件不合,就把暫存的值填回TextBox中
                    myTxtBox.SelectionStart = myTxtBox.Text.Length
                Else
                    _gstrTmp = myTxtBox.Text.Trim
                End If
            Else
                _gstrTmp = "0"
            End If
            ' _numRenge = txtEnd.Text.Trim - txtStart.Text.Trim
            txtTotalNumber.BackColor = Me._TotalNumbertmpColor
            txtTotalNumber.Text = ""
            _aryNumber = Nothing

        Catch ex As Exception

        End Try

    End Sub


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = False
        _TotalNumbertmpColor = txtTotalNumber.BackColor
        tmpColor = lblNumber.BackColor
    End Sub


    Private Sub txtTotalNumber_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalNumber.DoubleClick
        If Me._isSort = False Then
            _arySortNumber = _aryNumber.Clone
            Array.Sort(Me._arySortNumber)
            ShowNumbers(Me._arySortNumber)
            Me._isSort = True
        Else
            Me._isSort = False
            ShowNumbers(Me._aryNumber)
        End If

    End Sub

    Private Sub lblNumber_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNumber.DoubleClick
        frmSetting.ShowDialog()
        Me._intSize = frmSetting.tbSize.Value
        Me._intTime = frmSetting.tbSpeed.Value
        'txtTotalNumber.f = Me._intSize
        Me.txtTotalNumber.Font = New System.Drawing.Font("新細明體", Me._intSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
    End Sub
End Class
