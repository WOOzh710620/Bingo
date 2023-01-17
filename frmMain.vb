Imports System.IO
Imports System.Text

Public Class frmMain
    Private _gstrTmp As String = ""   '記錄輸入數字暫存的數值
    Private _isSort As Boolean = False
    Private tmpColor As Color
    Private _TotalNumbertmpColor As Color
    Private _numRenge As Integer = 0
    Private _intSize As Integer = 48
    Private _intTime As Integer = 200

    Private _lstNumber As New List(Of Integer)  ''原始開獎順序
    Private _lstSortNumber As New List(Of Integer) ''由大到小排序
    Private _tmpGetNumber As Integer    '跳亂數時暫存的值,直到時間停止,最後的值才會被寫入 List 中

    Private _logFile As String = "Bingo.log"


    Private Sub btnGetNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetNumber.Click

        _numRenge = CInt(txtEnd.Text.Trim) - CInt(txtStart.Text.Trim)
        If Not Me._lstNumber Is Nothing AndAlso _numRenge <= Me._lstNumber.Count - 1 Then
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

            If Me._lstNumber Is Nothing Then
                Me._lstNumber = New List(Of Integer)
                Me._lstSortNumber = New List(Of Integer)
                Me._lstSortNumber.Sort()
            End If

            Me._lstNumber.Add(Me._tmpGetNumber)
            Me._lstSortNumber.Add(Me._tmpGetNumber)
            ShowNumbers()
            lblNumber.BackColor = tmpColor
        Else
            Timer1.Interval = Timer1.Interval + tmieInterval
            Me._tmpGetNumber = GetNumber()

            lblNumber.Text = Me._tmpGetNumber.ToString
        End If
    End Sub

    Private Sub ShowNumbers()
        If Me._isSort = False Then
            ShowNumbers(Me._lstNumber)
        Else
            ShowNumbers(Me._lstSortNumber)
        End If
    End Sub
    Private Sub ShowNumbers(ByVal lstNumber As List(Of Integer))
        Dim i As Integer
        Dim tmpString As String = ""
        Dim insertString As String = " , "

        For i = 0 To lstNumber.Count - 1
            tmpString = tmpString & lstNumber.Item(i).ToString.Trim & insertString
        Next
        If tmpString.Trim <> "" Then
            tmpString = Microsoft.VisualBasic.Left(tmpString, tmpString.Length - insertString.Length)
        End If

        txtTotalNumber.Text = tmpString
        Me.writeLog(tmpString)

    End Sub

    Private Function GetNumber() As Integer
        Dim rndNumber As Integer = 0
        Dim rndMax As Integer = CInt(txtEnd.Text.Trim)
        Dim rndMin As Integer = CInt(txtStart.Text.Trim)

        Randomize(Now.Millisecond)  ''更新亂數種子
        rndNumber = Int((rndMax - rndMin + 1) * Rnd()) + rndMin   '設定資料後段要寫入多少個亂數

        If CheckNumberTheSame(rndNumber, Me._lstNumber) Then
            rndNumber = GetNumber()
        End If
        Return rndNumber

    End Function

    Private Function CheckNumberTheSame(ByVal strNumber As Integer, ByRef lstNumber As List(Of Integer)) As Boolean
        ''檢查號碼是否重覆
        'Dim i As Integer
        If lstNumber Is Nothing Then
            Return False
        End If
        If lstNumber.Contains(strNumber) = True Then
            Return True
        End If
        Return False
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
            txtTotalNumber.BackColor = Me._TotalNumbertmpColor
            txtTotalNumber.Text = ""

            If Not _lstNumber Is Nothing Then Me._lstNumber.Clear()
            If Not _lstSortNumber Is Nothing Then Me._lstSortNumber.Clear()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = False
        If Not _lstNumber Is Nothing Then Me._lstNumber.Clear()
        If Not _lstSortNumber Is Nothing Then Me._lstSortNumber.Clear()
        _TotalNumbertmpColor = txtTotalNumber.BackColor
        tmpColor = lblNumber.BackColor
        lblNumber.Text = "99"
        txtTotalNumber.Text = ""
        Me._logFile = "Bingo_" & Format(Now, "yyyyMMdd_hhmmss") & ".Log"
    End Sub


    Private Sub txtTotalNumber_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalNumber.DoubleClick
        If Me._isSort = False Then
            Me._lstSortNumber.Sort()
            ShowNumbers(Me._lstSortNumber)
            Me._isSort = True
        Else
            Me._isSort = False
            ShowNumbers(Me._lstNumber)
        End If

    End Sub

    Private Sub lblNumber_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNumber.DoubleClick
        frmSetting.ShowDialog()
        Me._intSize = frmSetting.tbSize.Value
        Me._intTime = frmSetting.tbSpeed.Value
        Me.txtTotalNumber.Font = New System.Drawing.Font("新細明體", Me._intSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
    End Sub

    Private Sub writeLog(ByVal msg As String)
        Try
            Dim swWriter As System.IO.StreamWriter = New System.IO.StreamWriter(Me._logFile, True, System.Text.Encoding.Default)
            swWriter.Write(msg & vbCrLf)
            swWriter.Close()
        Catch ex As Exception
            Dim strErrMsg As String = "ERROR FROM [SaveFile]" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace
            Trace.WriteLine(strErrMsg)
        End Try

    End Sub

    ''' <summary>
    ''' 重新開始
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRestart.Click
        frmMain_Load(sender, e)
    End Sub

    ''' <summary>
    ''' 開啟舊記錄
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        Dim ReadEndLine As String = ""
        Dim splString() As String
        Dim tmpStr As String = ""

        opfDialog.InitialDirectory = My.Application.Info.DirectoryPath
        opfDialog.Filter = "log files (*.log)|*.log|All files (*.*)|*.*"
        opfDialog.FilterIndex = 1
        If opfDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Not _lstNumber Is Nothing Then Me._lstNumber.Clear()
            If Not _lstSortNumber Is Nothing Then Me._lstSortNumber.Clear()
            _logFile = opfDialog.FileName
            ReadEndLine = ReadNLine2End(opfDialog.FileName)  '取出最後一行

            splString = ReadEndLine.Split(",")
            For intI As Integer = 0 To splString.GetUpperBound(0)
                tmpStr = splString(intI).Trim
                If tmpStr <> "" Then
                    Me._lstNumber.Add(tmpStr)
                    Me._lstSortNumber.Add(tmpStr)
                End If

            Next
            Me.lblNumber.Text = tmpStr  '最後一個數字放入開獎欄位中
            ShowNumbers()   '重新顯示開獎結果
        End If
    End Sub

    Private Function ReadNLine2End(ByVal FileName As String) As String
        '' 讀取最後一行
        Dim tmpStr() As String
        Dim ret As String = ""
        tmpStr = System.IO.File.ReadAllLines(opfDialog.FileName)

        ret = tmpStr(tmpStr.GetUpperBound(0))
        Return ret

    End Function


    Private Sub lblNumber_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblNumber.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            '按下滑鼠右鍵時,呼叫下拉選單
            ContextMenuStrip1.Show()
        End If
    End Sub
End Class
