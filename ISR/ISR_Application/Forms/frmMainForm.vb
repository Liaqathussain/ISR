Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Reflection

Public Class frmMainForm
    Dim frm As Object
    Dim ObjCls As New cls_Methods
    Dim SecondsAging As Integer
    Dim objISR As New ISR_Application.ServiceReference1.SR_ServiceSoapClient
    Dim UserID As Integer
    Dim CloseByID As Integer
    Dim ComplainModeID As Integer
    Dim QueryTypeID As Integer
    Dim RecivedFromID As Integer
    Dim StatusID As Integer

    Dim StartDateTime As DateTime
    Dim CloseDateTime As DateTime

    Dim TabFlag As Integer ''1 for insert and 0 for Update
    Dim IncidenetID As Integer = 0

    Dim objRemarksHistory As frmRemarksHistory

    Dim AgingCount As Integer

    Private Sub frmMainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ObjCls.loadAppUsers(cmbClosedBy)
            ObjCls.loadComplainMode(cmbComplainMode)
            ObjCls.loadRecivedForm(cmbRecivedFrom)
            ObjCls.loadStatus(cmbStatus)
            ObjCls.loadMainQueryType(cmbMainQuery)
            cmbAging.SelectedIndex = 0
            ObjCls.loadAppUsers(cmbSClosedBy)
            ObjCls.loadComplainMode(cmbSComplainMode)
            ObjCls.loadRecivedForm(cmbSRecivedFrom)
            ObjCls.loadStatus(cmbSStaus)
            ObjCls.loadQueryType(cmbSQueryType, 0)
            dtClosetime.Value = DateTime.Now
            dtStartDatetime.Value = DateTime.Now
            UserID = AppDomain.CurrentDomain.GetData("UserID")

        Catch ex As Exception
            MsgBox("frmMainForm_Load" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
        End Try
    End Sub

    Private Sub btnLogOut_Click(sender As System.Object, e As System.EventArgs) Handles btnLogOut.Click
        Try
            Dim result = MsgBox("Do you want to logout your Account ?", MessageBoxButtons.OKCancel, "ISR Administrator")
            If result = Windows.Forms.DialogResult.OK Then
                Dim objLogin As New frmLogin
                objLogin.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("btnLogOut_Click" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
        End Try

    End Sub

    Public Sub CalculatAging()
        Try
            Dim h, m, s As String
            Dim date1 As DateTime = dtStartDatetime.Value
            Dim date2 As DateTime = dtClosetime.Value
            If date1 > date2 Then
                SecondsAging = DateDiff("s", date2, date1)
            Else
                SecondsAging = DateDiff("s", date1, date2)
            End If

            Dim Sec As Integer = SecondsAging Mod 60
            Dim MinutsRemander As Integer = ((SecondsAging - (SecondsAging Mod 60)) / 60) Mod 60
            Dim ActualMinuts As Integer = ((SecondsAging - (SecondsAging Mod 60)) / 60) - MinutsRemander
            Dim Hours As Integer = ActualMinuts / 60
            If Hours < 10 Then
                h = "0" & Hours
            Else
                h = Hours
            End If
            If MinutsRemander < 10 Then
                m = "0" & MinutsRemander
            Else
                m = MinutsRemander
            End If
            If Sec < 10 Then
                s = "0" & Sec
            Else
                s = Sec
            End If

            tbAging.Text = h & ":" & m & ":" & s

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ClearControls_Insert()
        Try
            cmbClosedBy.SelectedValue = 0
            cmbComplainMode.SelectedValue = 0
            cmbquery.SelectedValue = 0
            cmbRecivedFrom.SelectedValue = 0
            cmbStatus.SelectedValue = 0
            tbCategory.Text = String.Empty
            tbInitiator.Text = String.Empty
            tbRemarks.Text = String.Empty
            dtStartDatetime.Value = DateTime.Now
            dtClosetime.Value = DateTime.Now
            tbAging.Text = String.Empty
            lbl1.Visible = False
            lbl2.Visible = False
            btnHistory.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ClearControls_Search()
        Try
            cmbSClosedBy.SelectedValue = 0
            cmbSComplainMode.SelectedValue = 0
            cmbSQueryType.SelectedValue = 0
            cmbSRecivedFrom.SelectedValue = 0
            cmbSStaus.SelectedValue = 0
            cmbAging.SelectedIndex = 0
            dtStartDatetime.Value = DateTime.Now
            dtClosetime.Value = DateTime.Now
            dgView.DataSource = Nothing
            dgView.Rows.Clear()
            dgView.Columns("coledit").Visible = False
            lblCount.Text = "0"
            dtFrom.Value = "1/1/1900"
            dtTo.Value = "1/1/1900"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        Try
            btnSubmit.Enabled = False
            btnSubmit.Cursor = Cursors.WaitCursor
            Dim dgresult As DialogResult = MessageBox.Show("Are you sure to save the record?", "ISR Admistrator System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dgresult = Windows.Forms.DialogResult.No Then
                btnSubmit.Enabled = True
                btnSubmit.Cursor = Cursors.Hand
                Exit Sub
            End If

            If cmbComplainMode.SelectedValue = 0 Or cmbMainQuery.SelectedValue = 0 Or cmbquery.SelectedValue = 0 Or cmbRecivedFrom.SelectedValue = 0 Or cmbStatus.SelectedValue = 0 Then
                MsgBox("Please Select all Validates Field", MsgBoxStyle.Information, "ISR Administrator")
                btnSubmit.Enabled = True
                btnSubmit.Cursor = Cursors.Hand
                Exit Sub
            End If

            Dim CloseByID As Integer
            If cmbClosedBy.SelectedValue = 0 Then
                CloseByID = 28
            Else
                CloseByID = cmbClosedBy.SelectedValue
            End If

            Dim LastIncidentId As Integer = objISR.InsertIncident(0, dtStartDatetime.Value, _
                                                                  cmbComplainMode.SelectedValue, _
                                                                  cmbquery.SelectedValue, _
                                                                  tbCategory.Text, _
                                                                  tbInitiator.Text, _
                                                                  cmbRecivedFrom.SelectedValue, _
                                                                  cmbStatus.SelectedValue, _
                                                                  CloseByID, _
                                                                  dtClosetime.Value, _
                                                                  tbAging.Text, _
                                                                  tbRemarks.Text, _
                                                                  UserID, _
                                                                  DateTime.Now)
            If LastIncidentId > 0 Then
                MsgBox("Record Insert Sucessfully", MsgBoxStyle.Information, "ISR Administrator")
                btnSubmit.Enabled = True
                btnSubmit.Cursor = Cursors.Hand
                ClearControls_Insert()
            Else
                MsgBox("Record Not Insert", MsgBoxStyle.Information, "ISR Administrator")
                btnSubmit.Enabled = True
                btnSubmit.Cursor = Cursors.Hand
            End If

        Catch ex As Exception
            MsgBox("btnSubmit_Click" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Try
            ClearControls_Insert()
            EnableFieldforInsert()
        Catch ex As Exception
            MsgBox("btnClear_Click" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
        End Try
    End Sub

    Private Sub ClearToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripButton.Click
        Try
            ClearControls_Search()
        Catch ex As Exception
            MsgBox("ClearToolStripButton_Click" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
        End Try
    End Sub

    Private Sub SearchToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchToolStripButton.Click
        Try

            Dim dt = objISR.GetIncidentReport(cmbSClosedBy.SelectedValue, cmbSComplainMode.SelectedValue, _
                                              cmbSQueryType.SelectedValue, cmbSRecivedFrom.SelectedValue, cmbSStaus.SelectedValue, dtFrom.Value, dtTo.Value)

            lblCount.Text = Convert.ToString(dt.Rows.Count)
            'AgingCount = dt.Rows.Count
            If dt.Rows.Count > 0 Then

                dgView.DataSource = dt
                dgView.Columns("coledit").Visible = True
                dgView.Columns("StatusID").Visible = True
                'For i As Integer = 0 To dt.Rows.Count - 1
                '    list.Add(dgView.Rows(i).Cells("Aging").Value)
                'Next

            End If
        Catch ex As Exception
            MsgBox("SearchToolStripButton_Click" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
        End Try
    End Sub

    Private Sub ReportToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles ReportToolStripButton.Click
        Try

            ReportToolStripButton.Enabled = False
            Dim dgresult As DialogResult = MessageBox.Show("Are you sure to Extract Report to Excel?", "Business Support System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dgresult = Windows.Forms.DialogResult.No Then
                ReportToolStripButton.Enabled = True
                Exit Sub
            End If
            Dim objDlg As New SaveFileDialog
            objDlg.Filter = "Excel File|*.xls"
            objDlg.OverwritePrompt = False
            If objDlg.ShowDialog = DialogResult.OK Then
                Dim filepath As String = objDlg.FileName
                ExportToExcel(dgView.DataSource, filepath)
                ReportToolStripButton.Enabled = True
            End If

        Catch ex As Exception
            MsgBox("ReportToolStripButton_Click" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
            ReportToolStripButton.Enabled = True

        End Try
    End Sub

    Private Sub dgView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellClick
        Try
            TabFlag = 0
            Dim Check As Integer = e.ColumnIndex
            If Check = 0 Then
                DisableFieldforEdit()
                IncidenetID = dgView.Rows(e.RowIndex).Cells("IncidentID").Value
                GetIncidentDetailByIncidentID(IncidenetID)
                TabControl1.SelectTab("tabCreateIncident")
                btnUpdate.Enabled = True
                btnSubmit.Enabled = False
            End If

        Catch ex As Exception
            MsgBox("dgView_CellClick" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
        End Try
    End Sub

    Private Sub DisableFieldforEdit()
        Try
            cmbComplainMode.Enabled = False
            cmbquery.Enabled = False
            cmbRecivedFrom.Enabled = False
            tbCategory.Enabled = False
            tbInitiator.Enabled = False
            dtStartDatetime.Enabled = False

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EnableFieldforInsert()
        Try
            cmbComplainMode.Enabled = True
            cmbquery.Enabled = True
            cmbRecivedFrom.Enabled = True
            tbCategory.Enabled = True
            tbInitiator.Enabled = True
            dtStartDatetime.Enabled = True
            btnSubmit.Enabled = True
            btnUpdate.Enabled = False
            cmbClosedBy.Enabled = True
            dtClosetime.Enabled = True
            tbRemarks.Enabled = True
            cmbStatus.Enabled = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GetIncidentDetailByIncidentID(ByVal ID As Integer)
        Try
            Dim dt = objISR.GetIncidentDetailByIncidentID(ID)

            If dt.Rows.Count > 0 Then
                cmbComplainMode.SelectedValue = dt.Rows(0)("ComplainModeID")
                cmbStatus.SelectedValue = dt.Rows(0)("StatusID")
                cmbRecivedFrom.SelectedValue = dt.Rows(0)("RecivedFromID")
                cmbquery.SelectedValue = dt.Rows(0)("QueryTypeID")
                cmbClosedBy.SelectedValue = dt.Rows(0)("ClosedByID")
                Dim StatusID As Integer = dt.Rows(0)("StatusID")

                If StatusID = 2 Then
                    cmbClosedBy.Enabled = False
                    dtClosetime.Enabled = False
                    tbRemarks.Enabled = False
                    cmbStatus.Enabled = False
                    btnUpdate.Enabled = False
                    btnSubmit.Enabled = False
                Else
                    cmbClosedBy.Enabled = True
                    dtClosetime.Enabled = True
                    tbRemarks.Enabled = True
                    cmbStatus.Enabled = True
                    btnUpdate.Enabled = True
                    btnSubmit.Enabled = True
                    cmbClosedBy.SelectedValue = 0
                End If
                tbCategory.Text = dt.Rows(0)("Category")
                tbInitiator.Text = dt.Rows(0)("Initiator")
                tbRemarks.Text = dt.Rows(0)("Remarks")
                tbAging.Text = dt.Rows(0)("Aging")
                dtStartDatetime.Value = dt.Rows(0)("StartDateTime")
                dtClosetime.Value = dt.Rows(0)("CloseDateTime")
                lbl1.Visible = True
                lbl2.Visible = True
                lbl2.Text = dt.Rows(0)("TransactionName")
                btnHistory.Visible = True

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExportToExcel(ByVal dtTemp As DataTable, ByVal filepath As String)

        Try
            Dim strFileName As String = filepath

            If System.IO.File.Exists(strFileName) Then

                If (MessageBox.Show("Do you want to replace from the existing file?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then
                    System.IO.File.Delete(strFileName)
                Else
                    Return
                End If

            End If
            Dim _excel As New Excel.Application
            Dim wBook As Excel.Workbook
            Dim wSheet As Excel.Worksheet

            wBook = _excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dtTemp
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            ' export the Columns 
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                wSheet.Cells(1, colIndex) = dc.ColumnName
            Next

            'export the rows 
            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    wSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next
            wSheet.Columns.AutoFit()
            wBook.SaveAs(strFileName)

            'release the objects
            ReleaseObject(wSheet)
            wBook.Close(False)
            ReleaseObject(wBook)
            _excel.Quit()
            ReleaseObject(_excel)
            ' some time Office application does not quit after automation: so i am calling GC.Collect method.
            GC.Collect()

            MsgBox("Report Extract Sucessfully to Excel", MsgBoxStyle.Information, "BSS Administrator")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Try
            If IncidenetID <> 0 Then

                btnUpdate.Enabled = False
                btnUpdate.Cursor = Cursors.WaitCursor
                Dim dgresult As DialogResult = MessageBox.Show("Are you sure to save the record?", "ISR Admistrator System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dgresult = Windows.Forms.DialogResult.No Then
                    btnUpdate.Enabled = True
                    btnUpdate.Cursor = Cursors.Hand
                    Exit Sub
                End If

                If cmbComplainMode.SelectedValue = 0 Or cmbquery.SelectedValue = 0 Or cmbRecivedFrom.SelectedValue = 0 Or cmbStatus.SelectedValue = 0 Then
                    MsgBox("Please Select all Validates Field", MsgBoxStyle.Information, "ISR Administrator")
                    btnSubmit.Enabled = True
                    btnSubmit.Cursor = Cursors.Hand
                    Exit Sub
                End If

                Dim CloseByID As Integer
                If cmbClosedBy.SelectedValue = 0 Then
                    CloseByID = 28
                Else
                    CloseByID = cmbClosedBy.SelectedValue
                End If

                If objISR.UpdateIncident(IncidenetID, dtStartDatetime.Value, _
                                            cmbComplainMode.SelectedValue, _
                                            cmbquery.SelectedValue, _
                                            tbCategory.Text, _
                                            tbInitiator.Text, _
                                            cmbRecivedFrom.SelectedValue, _
                                            cmbStatus.SelectedValue, _
                                            CloseByID, _
                                            dtClosetime.Value, _
                                            tbAging.Text, _
                                            tbRemarks.Text, _
                                            UserID, _
                                            DateTime.Now) Then

                    MsgBox("Record Update Sucessfully", MsgBoxStyle.Information, "ISR Administrator")
                    btnUpdate.Enabled = True
                    btnUpdate.Cursor = Cursors.Hand
                    ClearControls_Insert()
                    ClearControls_Search()
                    EnableFieldforInsert()

                Else
                    MsgBox("Record Not Update", MsgBoxStyle.Information, "ISR Administrator")
                    btnUpdate.Enabled = True
                    btnUpdate.Cursor = Cursors.Hand

                End If

            End If




        Catch ex As Exception
            MsgBox("btnUpdate_Click" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
            btnUpdate.Enabled = True
            btnUpdate.Cursor = Cursors.Hand
        End Try
    End Sub

    Private Sub btnHistory_Click(sender As System.Object, e As System.EventArgs) Handles btnHistory.Click
        Try
            If IncidenetID <> 0 Then
                Dim dt = objISR.GetRemarksHistoryByIncidentID(IncidenetID)
                If dt.Rows.Count > 0 Then
                    If objRemarksHistory Is Nothing Then
                        objRemarksHistory = New frmRemarksHistory
                    ElseIf objRemarksHistory.IsDisposed Then
                        objRemarksHistory = frmRemarksHistory
                    End If
                    objRemarksHistory.GVRemarksList.DataSource = dt
                    objRemarksHistory.MdiParent = Me.ParentForm
                    btnHistory.Cursor = Cursors.Arrow
                    btnHistory.Enabled = True
                    objRemarksHistory.Show()
                    objRemarksHistory.BringToFront()

                End If

              
            End If
        Catch ex As Exception
            MsgBox("btnHistory_Click" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Try
            If dtClosetime.Text <> String.Empty And dtStartDatetime.Text <> String.Empty Then
                CalculatAging()
            End If
        Catch ex As Exception
            MsgBox("PictureBox1_Click" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
        End Try
    End Sub

    Private Sub cmbMainQuery_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMainQuery.SelectedIndexChanged
        Try
            If cmbMainQuery.SelectedValue <> 0 Then
                ObjCls.loadQueryType(cmbquery, cmbMainQuery.SelectedValue)
            End If
        Catch ex As Exception
            MsgBox("cmbMainQuery_SelectedIndexChanged" + ex.Message, MsgBoxStyle.Critical, "ISR Administration")
        End Try
    End Sub

End Class