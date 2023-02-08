Imports System.DirectoryServices.ActiveDirectory
Imports System.Net.Http
Imports System.Text.Json

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Clear_Form()

    End Sub
    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click

        If txtURL.Text.Trim.Length = 0 Then Exit Sub

        Dim tkn As New AzureToken()

        Try
            Dim strResponse As String
            tkn = Generate_Token(strResponse)
            If strResponse = "" Or tkn Is Nothing Then Exit Sub
            txtRawOutput.Text = Replace(strResponse.Trim, "https://1ac25458-542c-4ecb-8105-36c15005b656/session:role-any", "https://1ab23456-789c-0def-1234-56a78901b234/session:role-any")
            txtTokenType.Text = IIf(tkn.token_type IsNot Nothing, tkn.token_type, "")
            txtTokenScope.Text = IIf(tkn.scope IsNot Nothing, tkn.scope, "")
            txtTokenExpires.Text = IIf(tkn.expires_in > 0, tkn.expires_in.ToString, "")
            lblTokenExpiresHMS.Text = IIf(tkn.expires_in > 0, Seconds_to_HMS(CDbl(tkn.expires_in)), "")
            txtTokenExt.Text = (tkn.ext_expires_in).ToString
            lblTokenExtHMS.Text = IIf(tkn.ext_expires_in > 0, Seconds_to_HMS(CDbl(tkn.ext_expires_in)), "")
            txtToken.Text = IIf(tkn.access_token IsNot Nothing, tkn.access_token, "")
        Catch ex As Exception
            Dim strException As String = ex.Message
        Finally
            tkn = Nothing
        End Try

    End Sub
    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click

        Clear_Form()

    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        Me.Close()

    End Sub
    Private Function Generate_Token(ByRef strResponse As String) As AzureToken

        Dim httpClient As New HttpClient()
        Dim fuecContent As FormUrlEncodedContent
        Dim httpResponse As HttpResponseMessage

        Try
            Using httpClient
                Dim strURL As String = txtURL.Text.Trim
                Dim lstValues As New List(Of KeyValuePair(Of String, String))
                If txtClientId.Text.Trim.Length > 0 Then lstValues.Add(New KeyValuePair(Of String, String)("client_id", txtClientId.Text.Trim))
                If txtClientSecret.Text.Trim.Length > 0 Then lstValues.Add(New KeyValuePair(Of String, String)("client_secret", txtClientSecret.Text.Trim))
                If txtGrantType.Text.Trim.Length > 0 Then lstValues.Add(New KeyValuePair(Of String, String)("grant_type", txtGrantType.Text.Trim))
                If txtUserName.Text.Trim.Length > 0 Then lstValues.Add(New KeyValuePair(Of String, String)("username", txtUserName.Text.Trim))
                If txtPassword.Text.Trim.Length > 0 Then lstValues.Add(New KeyValuePair(Of String, String)("password", txtPassword.Text.Trim))
                If txtScope.Text.Trim.Length > 0 Then lstValues.Add(New KeyValuePair(Of String, String)("scope", txtScope.Text.Trim))
                fuecContent = New FormUrlEncodedContent(lstValues)
                httpResponse = httpClient.PostAsync(strURL, fuecContent).Result
                strResponse = httpResponse.Content.ReadAsStringAsync().Result
                Generate_Token = JsonSerializer.Deserialize(Of AzureToken)(strResponse)
            End Using
        Catch ex As Exception
            strResponse = ""
            Dim strException As String = ex.Message
        Finally
            If httpResponse IsNot Nothing Then httpResponse.Dispose()
            If fuecContent IsNot Nothing Then fuecContent.Dispose()
        End Try

    End Function
    Private Function Seconds_to_HMS(ByVal dblSeconds As Double) As String

        Try
            Dim tspHMS As TimeSpan = TimeSpan.FromSeconds(dblSeconds)
            If tspHMS.Hours = 1 Then
                Seconds_to_HMS += tspHMS.Hours.ToString.PadLeft(1, "0"c) & " hour, "
            Else
                Seconds_to_HMS += tspHMS.Hours.ToString.PadLeft(1, "0"c) & " hours, "
            End If
            If tspHMS.Minutes = 1 Then
                Seconds_to_HMS += tspHMS.Minutes.ToString.PadLeft(2, "0"c) & " minute, "
            Else
                Seconds_to_HMS += tspHMS.Minutes.ToString.PadLeft(2, "0"c) & " minutes, "
            End If
            If tspHMS.Seconds = 1 Then
                Seconds_to_HMS += tspHMS.Seconds.ToString.PadLeft(2, "0"c) & " second"
            Else
                Seconds_to_HMS += tspHMS.Seconds.ToString.PadLeft(2, "0"c) & " seconds"
            End If
        Catch ex As Exception
            Seconds_to_HMS = dblSeconds.ToString("#,##0.#") & " seconds"
        End Try

    End Function
    Private Sub Clear_Form(Optional ByVal blnOutputFieldsOnly As Boolean = False)

        Try
            For Each cntrl In grpOutput.Controls
                If cntrl.GetType.Name = "TextBox" Then cntrl.clear()
            Next
            lblTokenExpiresHMS.Text = ""
            lblTokenExtHMS.Text = ""
            If blnOutputFieldsOnly Then Exit Sub
            For Each cntrl In grpInputs.Controls
                If cntrl.GetType.Name = "TextBox" Then cntrl.clear()
            Next
        Catch ex As Exception
            Dim strException As String = ex.Message
        End Try

    End Sub

End Class
