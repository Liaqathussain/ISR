Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.IO
Imports System.Net

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class ISR_Service
    Inherits System.Web.Services.WebService
    Dim objISR As New clsDBAccess(My.Settings.conISR, DBEngineType.SQL)
    Dim Smtp_Server As SmtpClient

    <WebMethod()> _
    Public Function HelloWorld() As String
       Return "Hello World"
    End Function

    <WebMethod()> _
    Public Function AuthenticateUser(ByVal LoginName As String, ByVal Password As String) As DataTable
        Dim dt As New DataTable
        Try

            Dim para As String(,) = {{"@LoginName", LoginName}, {"@Password", Password}}
            dt = objISR.SP_Datatable("sp_AuthenticateUser", para)
            dt.TableName = "sp_AuthenticateUser"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally

        End Try
        Return dt
    End Function

    <WebMethod()> _
    Public Function GetAppUsers() As DataTable
        Dim dt As New DataTable

        Try

            dt = objISR.SP_Datatable("sp_GetAppUsers")
            dt.TableName = "sp_GetAppUsers"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    <WebMethod()> _
    Public Function GetQueryType(ByVal QueryMainTypeID As Integer) As DataTable
        Dim dt As New DataTable

        Try

            Dim para As String(,) = {{"@QueryMainTypeID", QueryMainTypeID}}
            dt = objISR.SP_Datatable("sp_GetQueryType", para)
            dt.TableName = "sp_GetQueryType"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    <WebMethod()> _
    Public Function GetMainQueryType() As DataTable
        Dim dt As New DataTable

        Try

            dt = objISR.SP_Datatable("sp_GetMainQueryType")
            dt.TableName = "sp_GetMainQueryType"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    <WebMethod()> _
    Public Function GetRecivedFrom() As DataTable
        Dim dt As New DataTable

        Try

            dt = objISR.SP_Datatable("sp_GetRecivedFrom")
            dt.TableName = "sp_GetRecivedFrom"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    <WebMethod()> _
    Public Function GetStatus() As DataTable
        Dim dt As New DataTable

        Try

            dt = objISR.SP_Datatable("sp_GetStatus")
            dt.TableName = "sp_GetStatus"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    <WebMethod()> _
    Public Function GetComplainMode() As DataTable
        Dim dt As New DataTable

        Try

            dt = objISR.SP_Datatable("sp_GetComplainMode")
            dt.TableName = "sp_GetComplainMode"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    <WebMethod()> _
    Public Function InsertIncident(ByVal IncidentID As Integer, _
                                   ByVal StartDateTime As DateTime, _
                                   ByVal ComplainModeID As Integer, _
                                   ByVal QueryTypeID As Integer, _
                                   ByVal Category As String, _
                                   ByVal Initiator As String, _
                                   ByVal RecivedFromID As Integer, _
                                   ByVal StatusID As Integer, _
                                   ByVal ClosedByID As Integer, _
                                   ByVal CloseDateTime As DateTime, _
                                   ByVal Aging As String, _
                                   ByVal Remarks As String, _
                                   ByVal TransactionBy As Integer, _
                                   ByVal TransactionDateTime As DateTime) As Integer
        Try


            Dim para As String(,) = {{"@StartDateTime", StartDateTime}, _
                                    {"@ComplainModeID", ComplainModeID}, _
                                    {"@QueryTypeID", QueryTypeID}, _
                                    {"@Category", Category}, _
                                    {"@Initiator", Initiator}, _
                                    {"@RecivedFromID", RecivedFromID}, _
                                    {"@StatusID", StatusID}, _
                                    {"@ClosedByID", ClosedByID}, _
                                    {"@CloseDateTime", CloseDateTime}, _
                                    {"@Aging", Aging}, _
                                    {"@Remarks", Remarks}, _
                                    {"@TransactionBy", TransactionBy}, _
                                    {"@TransactionDateTime", TransactionDateTime}}



            Dim LastID = objISR.InsertProc_GetLastIncidentID("sp_InsertIncident", para)
            If LastID > 0 Then
                Return LastID
            Else
                Return 0
            End If

        Catch ex As Exception

            Throw ex
        Finally

        End Try
    End Function

    <WebMethod()> _
    Public Function GetIncidentReport(ByVal ClosedByID As Integer, _
                                        ByVal ComplainModeID As Integer, _
                                        ByVal QueryTypeID As Integer, _
                                        ByVal RecivedFromID As Integer, _
                                        ByVal StatusID As Integer, _
                                        ByVal CloseDateTimeFrom As DateTime, _
                                        ByVal CloseDateTimeTO As DateTime) As DataTable

        Try
            Dim dt As New DataTable
            Dim para As String(,) = {{"@ClosedByID", ClosedByID}, _
                                     {"@ComplainModeID", ComplainModeID}, _
                                     {"@QueryTypeID", QueryTypeID}, _
                                     {"@RecivedFromID", RecivedFromID}, _
                                     {"@StatusID", StatusID}, _
                                     {"@CloseDateTimeFrom", CloseDateTimeFrom}, _
                                     {"@CloseDateTimeTO", CloseDateTimeTO}}

            dt = objISR.SP_Datatable("sp_GetIncidentReport", para)
            dt.TableName = "sp_GetIncidentReport"
            Return dt

        Catch ex As Exception

            Throw ex
        Finally

        End Try
    End Function

    <WebMethod()> _
    Public Function GetIncidentDetailByIncidentID(ByVal IncidentID As Integer) As DataTable
        Dim dt As New DataTable

        Try
            Dim para As String(,) = {{"@IncidentID", IncidentID}}
            dt = objISR.SP_Datatable("sp_GetIncidentDetailByIncidentID", para)
            dt.TableName = "sp_GetIncidentDetailByIncidentID"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    <WebMethod()> _
    Public Function UpdateIncident(ByVal IncidentID As Integer, _
                                   ByVal StartDateTime As DateTime, _
                                   ByVal ComplainModeID As Integer, _
                                   ByVal QueryTypeID As Integer, _
                                   ByVal Category As String, _
                                   ByVal Initiator As String, _
                                   ByVal RecivedFromID As Integer, _
                                   ByVal StatusID As Integer, _
                                   ByVal ClosedByID As Integer, _
                                   ByVal CloseDateTime As DateTime, _
                                   ByVal Aging As String, _
                                   ByVal Remarks As String, _
                                   ByVal TransactionBy As Integer, _
                                   ByVal TransactionDateTime As DateTime) As Integer
        Try


            Dim para As String(,) = {{"@IncidentID", IncidentID}, _
                                    {"@StartDateTime", StartDateTime}, _
                                    {"@ComplainModeID", ComplainModeID}, _
                                    {"@QueryTypeID", QueryTypeID}, _
                                    {"@Category", Category}, _
                                    {"@Initiator", Initiator}, _
                                    {"@RecivedFromID", RecivedFromID}, _
                                    {"@StatusID", StatusID}, _
                                    {"@ClosedByID", ClosedByID}, _
                                    {"@CloseDateTime", CloseDateTime}, _
                                    {"@Aging", Aging}, _
                                    {"@Remarks", Remarks}, _
                                    {"@TransactionBy", TransactionBy}, _
                                    {"@TransactionDateTime", TransactionDateTime}}


            If objISR.executeProc("sp_UpdateIncident", para) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    <WebMethod()> _
    Public Function GetRemarksHistoryByIncidentID(ByVal IncidentID As Integer) As DataTable
        Dim dt As New DataTable

        Try
            Dim para As String(,) = {{"@IncidentID", IncidentID}}
            dt = objISR.SP_Datatable("sp_GetRemarksHistoryByIncidentID", para)
            dt.TableName = "sp_GetRemarksHistoryByIncidentID"
            Return dt

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

End Class