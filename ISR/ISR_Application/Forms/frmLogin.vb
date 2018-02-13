Imports Novell.Directory
Imports Novell.Directory.Ldap
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Public Class frmLogin

    Dim ObjMain As New frmMainForm
    Dim objISR As New ISR_Application.ServiceReference1.SR_ServiceSoapClient
    Dim IsADAuthenticate As Integer

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            btnLogin.Enabled = False
            If tbLoginName.Text = "" Or tbPassword.Text = "" Then
                MsgBox("Enter User Name or Password", MsgBoxStyle.Critical, "Notification")
                tbPassword.Text = ""
                tbLoginName.SelectAll()
                tbLoginName.Focus()
                btnLogin.Enabled = True
                Exit Sub
            End If

            Me.tbLoginName.Enabled = False
            Me.tbPassword.Enabled = False

            Dim dt = objISR.AuthenticateUser(tbLoginName.Text.Trim, tbPassword.Text.Trim)

            If dt.Rows.Count > 0 Then
                AppDomain.CurrentDomain.SetData("UserID", dt.Rows(0)("UserID"))
                AppDomain.CurrentDomain.SetData("Name", dt.Rows(0)("Name"))
                IsADAuthenticate = dt.Rows(0)("IsADAuthenticate")
            Else
                MsgBox("Invalid User Name or Password", MsgBoxStyle.Critical, "ISR Administrator")
                Me.tbLoginName.Enabled = True
                Me.tbPassword.Enabled = True
                btnLogin.Enabled = True
                Exit Sub
            End If

            If IsADAuthenticate = 1 Then
                If ValidateActiveDirectoryLogin(tbLoginName.Text.Trim, tbPassword.Text.Trim) Then
                    btnLogin.Enabled = True
                    ObjMain.Show()
                    Me.Hide()
                Else
                    MsgBox("You are Not Authenticate from Domain", MsgBoxStyle.Critical, "BSS Administrator")
                    Me.tbLoginName.Enabled = True
                    Me.tbPassword.Enabled = True
                    btnLogin.Enabled = True
                    Exit Sub
                End If

            ElseIf IsADAuthenticate = 0 Then
                btnLogin.Enabled = True
                ObjMain.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "ISR Administrator")
            Me.tbLoginName.Enabled = True
            Me.tbPassword.Enabled = True
            btnLogin.Enabled = True
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Function ValidateActiveDirectoryLogin(ByVal Username As String, ByVal Password As String) As Boolean

        Try
            Dim ldapConn As New LdapConnection()
            ldapConn.Connect("103.31.81.82", 389)
            ldapConn.Bind("cn=administrator,dc=multinet,dc=com,dc=pk", "Zim2017Dep!@#")
            Password = GetBase64EncodedSHA1Hash(Password)
            Dim Filters As String = "(&(uid=" + Username + ")(userPassword=" + Password + "))"
            Dim queue As LdapSearchQueue = ldapConn.Search("ou=people,dc=multinet,dc=com,dc=pk", LdapConnection.SCOPE_ONE, Filters, Nothing, False, DirectCast(Nothing, LdapSearchQueue), _
            DirectCast(Nothing, LdapSearchConstraints))
            Dim message As LdapMessage
            message = queue.getResponse()
            If TypeOf message Is LdapSearchResult Then
                ldapConn.Disconnect()
                Return True
            Else
                ldapConn.Disconnect()
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    'Private Function ValidateActiveDirectoryLogin(ByVal Username As String, ByVal Password As String) As Boolean
    '    Dim Success As Boolean = False
    '    Dim Entry As New System.DirectoryServices.DirectoryEntry("LDAP://multinet.com.pk", Username, Password)
    '    Dim Searcher As New System.DirectoryServices.DirectorySearcher(Entry)
    '    Searcher.SearchScope = DirectoryServices.SearchScope.OneLevel
    '    Try
    '        Dim Results As System.DirectoryServices.SearchResult = Searcher.FindOne
    '        Success = Not (Results Is Nothing)
    '    Catch
    '        Success = False
    '    End Try
    '    Return Success
    'End Function

    Private Function GetBase64EncodedSHA1Hash(filename As String) As String
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(filename)
        Using sha1 As New SHA1Managed()
            Return "{SHA}" + Convert.ToBase64String(sha1.ComputeHash(bytes))
        End Using
    End Function

    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

   
End Class