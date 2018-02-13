
Public Class cls_Methods
    Dim objISR As New ISR_Application.ServiceReference1.SR_ServiceSoapClient

    Public Sub loadAppUsers(ByVal ddP As ComboBox)
        Try
            Dim dt = objISR.GetAppUsers
            If dt.Rows.Count > 0 Then
                ddP.DisplayMember = "Name"
                ddP.ValueMember = "UserID"
                Dim dr As DataRow = dt.NewRow
                dr(0) = 0
                dr(1) = "Please-Select"
                dt.Rows.InsertAt(dr, 0)
                ddP.DataSource = dt
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub loadStatus(ByVal ddP As ComboBox)
        Try
            Dim dt = objISR.GetStatus
            If dt.Rows.Count > 0 Then
                ddP.DisplayMember = "Status"
                ddP.ValueMember = "StatusID"
                Dim dr As DataRow = dt.NewRow
                dr(0) = 0
                dr(1) = "Please-Select"
                dt.Rows.InsertAt(dr, 0)
                ddP.DataSource = dt
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub loadRecivedForm(ByVal ddP As ComboBox)
        Try
            Dim dt = objISR.GetRecivedFrom
            If dt.Rows.Count > 0 Then
                ddP.DisplayMember = "RecivedFrom"
                ddP.ValueMember = "RecivedFromID"
                Dim dr As DataRow = dt.NewRow
                dr(0) = 0
                dr(1) = "Please-Select"
                dt.Rows.InsertAt(dr, 0)
                ddP.DataSource = dt
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub loadComplainMode(ByVal ddP As ComboBox)
        Try
            Dim dt = objISR.GetComplainMode
            If dt.Rows.Count > 0 Then
                ddP.DisplayMember = "ComplainMode"
                ddP.ValueMember = "ComplainModeID"
                Dim dr As DataRow = dt.NewRow
                dr(0) = 0
                dr(1) = "Please-Select"
                dt.Rows.InsertAt(dr, 0)
                ddP.DataSource = dt
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub loadMainQueryType(ByVal ddP As ComboBox)
        Try
            Dim dt = objISR.GetMainQueryType
            If dt.Rows.Count > 0 Then
                ddP.DisplayMember = "QueryMainType"
                ddP.ValueMember = "QueryMainTypeID"
                Dim dr As DataRow = dt.NewRow
                dr(0) = 0
                dr(1) = "Please-Select"
                dt.Rows.InsertAt(dr, 0)
                ddP.DataSource = dt
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub loadQueryType(ByVal ddP As ComboBox, ByVal QueryMainTypeID As Integer)
        Try
            Dim dt = objISR.GetQueryType(QueryMainTypeID)
            If dt.Rows.Count > 0 Then
                ddP.DisplayMember = "QueryType"
                ddP.ValueMember = "QueryTypeID"
                Dim dr As DataRow = dt.NewRow
                dr(0) = 0
                dr(1) = "Please-Select"
                dt.Rows.InsertAt(dr, 0)
                ddP.DataSource = dt
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



End Class
