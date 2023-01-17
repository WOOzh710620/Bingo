Imports System.IO
Imports System.Text

Public Class frmMain
    Private _gstrTmp As String = ""   '�O����J�Ʀr�Ȧs���ƭ�
    Private _isSort As Boolean = False
    Private tmpColor As Color
    Private _TotalNumbertmpColor As Color
    Private _numRenge As Integer = 0
    Private _intSize As Integer = 48
    Private _intTime As Integer = 200

    Private _lstNumber As New List(Of Integer)  ''��l�}������
    Private _lstSortNumber As New List(Of Integer) ''�Ѥj��p�Ƨ�
    Private _tmpGetNumber As Integer    '���üƮɼȦs����,����ɶ�����,�̫᪺�Ȥ~�|�Q�g�J List ��

    Private _logFile As String = "Bingo.log"


    Private Sub btnGetNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetNumber.Click

        _numRenge = CInt(txtEnd.Text.Trim) - CInt(txtStart.Text.Trim)
        If Not Me._lstNumber Is Nothing AndAlso _numRenge <= Me._lstNumber.Count - 1 Then
            MsgBox("�Ҧ��Ƥw����")
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

        Randomize(Now.Millisecond)  ''��s�üƺؤl
        rndNumber = Int((rndMax - rndMin + 1) * Rnd()) + rndMin   '�]�w��ƫ�q�n�g�J�h�֭Ӷü�

        If CheckNumberTheSame(rndNumber, Me._lstNumber) Then
            rndNumber = GetNumber()
        End If
        Return rndNumber

    End Function

    Private Function CheckNumberTheSame(ByVal strNumber As Integer, ByRef lstNumber As List(Of Integer)) As Boolean
        ''�ˬd���X�O�_����
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
        ''�ˬd���X�O�_����
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
            ''�P�_�O�_���Ʀr,�Y���O�h��Ȧs���e�ȶ�J
            Dim myTxtBox As TextBox = Nothing
            myTxtBox = sender
            If myTxtBox.Text.Trim.Length > 0 Then
                ''����u���J����,���]�t�p��,���঳","
                ''�]��IsNumeric ���"," �|�����Ʀr���@��
                ''�Y�n�����t���h��InStr(myTxtBox.Text, "-") > 0 �o�ӱ���R��
                If IsNumeric(myTxtBox.Text) = False _
                        Or InStr(myTxtBox.Text, " ") > 0 _
                        Or InStr(myTxtBox.Text, ",") > 0 _
                        Or InStr(myTxtBox.Text, ".") > 0 _
                        Or InStr(myTxtBox.Text, "-") > 0 Then
                    myTxtBox.Text = _gstrTmp '�Y�䤤�@�ӱ��󤣦X,�N��Ȧs���ȶ�^TextBox��
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
        Me.txtTotalNumber.Font = New System.Drawing.Font("�s�ө���", Me._intSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
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
    ''' ���s�}�l
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRestart.Click
        frmMain_Load(sender, e)
    End Sub

    ''' <summary>
    ''' �}���°O��
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
            ReadEndLine = ReadNLine2End(opfDialog.FileName)  '���X�̫�@��

            splString = ReadEndLine.Split(",")
            For intI As Integer = 0 To splString.GetUpperBound(0)
                tmpStr = splString(intI).Trim
                If tmpStr <> "" Then
                    Me._lstNumber.Add(tmpStr)
                    Me._lstSortNumber.Add(tmpStr)
                End If

            Next
            Me.lblNumber.Text = tmpStr  '�̫�@�ӼƦr��J�}����줤
            ShowNumbers()   '���s��ܶ}�����G
        End If
    End Sub

    Private Function ReadNLine2End(ByVal FileName As String) As String
        '' Ū���̫�@��
        Dim tmpStr() As String
        Dim ret As String = ""
        tmpStr = System.IO.File.ReadAllLines(opfDialog.FileName)

        ret = tmpStr(tmpStr.GetUpperBound(0))
        Return ret

    End Function


    Private Sub lblNumber_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblNumber.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            '���U�ƹ��k���,�I�s�U�Կ��
            ContextMenuStrip1.Show()
        End If
    End Sub
End Class
