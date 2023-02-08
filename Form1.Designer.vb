<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grpInputs = New System.Windows.Forms.GroupBox()
        Me.txtScope = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtGrantType = New System.Windows.Forms.TextBox()
        Me.txtClientSecret = New System.Windows.Forms.TextBox()
        Me.txtClientId = New System.Windows.Forms.TextBox()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.lblScope = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblGrantType = New System.Windows.Forms.Label()
        Me.lblClientSecret = New System.Windows.Forms.Label()
        Me.lblClientId = New System.Windows.Forms.Label()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.lblTokenExtHMS = New System.Windows.Forms.Label()
        Me.lblTokenExpiresHMS = New System.Windows.Forms.Label()
        Me.txtToken = New System.Windows.Forms.TextBox()
        Me.txtTokenExt = New System.Windows.Forms.TextBox()
        Me.txtTokenExpires = New System.Windows.Forms.TextBox()
        Me.txtTokenScope = New System.Windows.Forms.TextBox()
        Me.txtTokenType = New System.Windows.Forms.TextBox()
        Me.lblToken = New System.Windows.Forms.Label()
        Me.lblTokenExt = New System.Windows.Forms.Label()
        Me.lblTokenExpires = New System.Windows.Forms.Label()
        Me.lblTokenScope = New System.Windows.Forms.Label()
        Me.lblTokenType = New System.Windows.Forms.Label()
        Me.lblRawOutput = New System.Windows.Forms.Label()
        Me.txtRawOutput = New System.Windows.Forms.TextBox()
        Me.grpInputs.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInputs
        '
        Me.grpInputs.Controls.Add(Me.txtScope)
        Me.grpInputs.Controls.Add(Me.txtPassword)
        Me.grpInputs.Controls.Add(Me.txtUserName)
        Me.grpInputs.Controls.Add(Me.txtGrantType)
        Me.grpInputs.Controls.Add(Me.txtClientSecret)
        Me.grpInputs.Controls.Add(Me.txtClientId)
        Me.grpInputs.Controls.Add(Me.txtURL)
        Me.grpInputs.Controls.Add(Me.lblURL)
        Me.grpInputs.Controls.Add(Me.lblScope)
        Me.grpInputs.Controls.Add(Me.lblPassword)
        Me.grpInputs.Controls.Add(Me.lblUserName)
        Me.grpInputs.Controls.Add(Me.lblGrantType)
        Me.grpInputs.Controls.Add(Me.lblClientSecret)
        Me.grpInputs.Controls.Add(Me.lblClientId)
        Me.grpInputs.Location = New System.Drawing.Point(12, 12)
        Me.grpInputs.Name = "grpInputs"
        Me.grpInputs.Size = New System.Drawing.Size(760, 242)
        Me.grpInputs.TabIndex = 0
        Me.grpInputs.TabStop = False
        Me.grpInputs.Text = "Input Attributes"
        '
        'txtScope
        '
        Me.txtScope.Location = New System.Drawing.Point(98, 200)
        Me.txtScope.Name = "txtScope"
        Me.txtScope.Size = New System.Drawing.Size(550, 23)
        Me.txtScope.TabIndex = 13
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(98, 171)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(320, 23)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(98, 142)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(450, 23)
        Me.txtUserName.TabIndex = 9
        '
        'txtGrantType
        '
        Me.txtGrantType.Location = New System.Drawing.Point(98, 113)
        Me.txtGrantType.Name = "txtGrantType"
        Me.txtGrantType.Size = New System.Drawing.Size(150, 23)
        Me.txtGrantType.TabIndex = 7
        '
        'txtClientSecret
        '
        Me.txtClientSecret.Location = New System.Drawing.Point(98, 84)
        Me.txtClientSecret.Name = "txtClientSecret"
        Me.txtClientSecret.Size = New System.Drawing.Size(320, 23)
        Me.txtClientSecret.TabIndex = 5
        Me.txtClientSecret.UseSystemPasswordChar = True
        '
        'txtClientId
        '
        Me.txtClientId.Location = New System.Drawing.Point(98, 55)
        Me.txtClientId.Name = "txtClientId"
        Me.txtClientId.Size = New System.Drawing.Size(320, 23)
        Me.txtClientId.TabIndex = 3
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(98, 26)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(640, 23)
        Me.txtURL.TabIndex = 1
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Location = New System.Drawing.Point(61, 29)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(31, 15)
        Me.lblURL.TabIndex = 0
        Me.lblURL.Text = "URL:"
        Me.lblURL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblScope
        '
        Me.lblScope.AutoSize = True
        Me.lblScope.Location = New System.Drawing.Point(50, 203)
        Me.lblScope.Name = "lblScope"
        Me.lblScope.Size = New System.Drawing.Size(42, 15)
        Me.lblScope.TabIndex = 12
        Me.lblScope.Text = "Scope:"
        Me.lblScope.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(32, 174)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(60, 15)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(24, 145)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(68, 15)
        Me.lblUserName.TabIndex = 8
        Me.lblUserName.Text = "User Name:"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGrantType
        '
        Me.lblGrantType.AutoSize = True
        Me.lblGrantType.Location = New System.Drawing.Point(26, 116)
        Me.lblGrantType.Name = "lblGrantType"
        Me.lblGrantType.Size = New System.Drawing.Size(66, 15)
        Me.lblGrantType.TabIndex = 6
        Me.lblGrantType.Text = "Grant Type:"
        Me.lblGrantType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClientSecret
        '
        Me.lblClientSecret.AutoSize = True
        Me.lblClientSecret.Location = New System.Drawing.Point(16, 87)
        Me.lblClientSecret.Name = "lblClientSecret"
        Me.lblClientSecret.Size = New System.Drawing.Size(76, 15)
        Me.lblClientSecret.TabIndex = 4
        Me.lblClientSecret.Text = "Client Secret:"
        Me.lblClientSecret.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClientId
        '
        Me.lblClientId.AutoSize = True
        Me.lblClientId.Location = New System.Drawing.Point(38, 58)
        Me.lblClientId.Name = "lblClientId"
        Me.lblClientId.Size = New System.Drawing.Size(54, 15)
        Me.lblClientId.TabIndex = 2
        Me.lblClientId.Text = "Client Id:"
        Me.lblClientId.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Location = New System.Drawing.Point(12, 269)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(120, 30)
        Me.cmdGenerate.TabIndex = 1
        Me.cmdGenerate.Text = "&Generate Token"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(331, 269)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(120, 30)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Text = "&Clear Fields"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(652, 269)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(120, 30)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.lblTokenExtHMS)
        Me.grpOutput.Controls.Add(Me.lblTokenExpiresHMS)
        Me.grpOutput.Controls.Add(Me.txtToken)
        Me.grpOutput.Controls.Add(Me.txtTokenExt)
        Me.grpOutput.Controls.Add(Me.txtTokenExpires)
        Me.grpOutput.Controls.Add(Me.txtTokenScope)
        Me.grpOutput.Controls.Add(Me.txtTokenType)
        Me.grpOutput.Controls.Add(Me.lblToken)
        Me.grpOutput.Controls.Add(Me.lblTokenExt)
        Me.grpOutput.Controls.Add(Me.lblTokenExpires)
        Me.grpOutput.Controls.Add(Me.lblTokenScope)
        Me.grpOutput.Controls.Add(Me.lblTokenType)
        Me.grpOutput.Controls.Add(Me.lblRawOutput)
        Me.grpOutput.Controls.Add(Me.txtRawOutput)
        Me.grpOutput.Location = New System.Drawing.Point(12, 319)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(760, 480)
        Me.grpOutput.TabIndex = 4
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output Results"
        '
        'lblTokenExtHMS
        '
        Me.lblTokenExtHMS.AutoSize = True
        Me.lblTokenExtHMS.Location = New System.Drawing.Point(204, 416)
        Me.lblTokenExtHMS.Name = "lblTokenExtHMS"
        Me.lblTokenExtHMS.Size = New System.Drawing.Size(93, 15)
        Me.lblTokenExtHMS.TabIndex = 20
        Me.lblTokenExtHMS.Text = "lblTokenExtHMS"
        '
        'lblTokenExpiresHMS
        '
        Me.lblTokenExpiresHMS.AutoSize = True
        Me.lblTokenExpiresHMS.Location = New System.Drawing.Point(204, 387)
        Me.lblTokenExpiresHMS.Name = "lblTokenExpiresHMS"
        Me.lblTokenExpiresHMS.Size = New System.Drawing.Size(114, 15)
        Me.lblTokenExpiresHMS.TabIndex = 17
        Me.lblTokenExpiresHMS.Text = "lblTokenExpiresHMS"
        '
        'txtToken
        '
        Me.txtToken.BackColor = System.Drawing.Color.White
        Me.txtToken.Location = New System.Drawing.Point(98, 442)
        Me.txtToken.Name = "txtToken"
        Me.txtToken.ReadOnly = True
        Me.txtToken.Size = New System.Drawing.Size(640, 23)
        Me.txtToken.TabIndex = 22
        '
        'txtTokenExt
        '
        Me.txtTokenExt.BackColor = System.Drawing.Color.White
        Me.txtTokenExt.Location = New System.Drawing.Point(98, 413)
        Me.txtTokenExt.Name = "txtTokenExt"
        Me.txtTokenExt.ReadOnly = True
        Me.txtTokenExt.Size = New System.Drawing.Size(100, 23)
        Me.txtTokenExt.TabIndex = 19
        Me.txtTokenExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTokenExpires
        '
        Me.txtTokenExpires.BackColor = System.Drawing.Color.White
        Me.txtTokenExpires.Location = New System.Drawing.Point(98, 384)
        Me.txtTokenExpires.Name = "txtTokenExpires"
        Me.txtTokenExpires.ReadOnly = True
        Me.txtTokenExpires.Size = New System.Drawing.Size(100, 23)
        Me.txtTokenExpires.TabIndex = 16
        Me.txtTokenExpires.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTokenScope
        '
        Me.txtTokenScope.BackColor = System.Drawing.Color.White
        Me.txtTokenScope.Location = New System.Drawing.Point(98, 355)
        Me.txtTokenScope.Name = "txtTokenScope"
        Me.txtTokenScope.ReadOnly = True
        Me.txtTokenScope.Size = New System.Drawing.Size(550, 23)
        Me.txtTokenScope.TabIndex = 14
        '
        'txtTokenType
        '
        Me.txtTokenType.BackColor = System.Drawing.Color.White
        Me.txtTokenType.Location = New System.Drawing.Point(98, 326)
        Me.txtTokenType.Name = "txtTokenType"
        Me.txtTokenType.ReadOnly = True
        Me.txtTokenType.Size = New System.Drawing.Size(150, 23)
        Me.txtTokenType.TabIndex = 12
        '
        'lblToken
        '
        Me.lblToken.AutoSize = True
        Me.lblToken.Location = New System.Drawing.Point(10, 445)
        Me.lblToken.Name = "lblToken"
        Me.lblToken.Size = New System.Drawing.Size(80, 15)
        Me.lblToken.TabIndex = 21
        Me.lblToken.Text = "Access Token:"
        Me.lblToken.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTokenExt
        '
        Me.lblTokenExt.AutoSize = True
        Me.lblTokenExt.Location = New System.Drawing.Point(10, 416)
        Me.lblTokenExt.Name = "lblTokenExt"
        Me.lblTokenExt.Size = New System.Drawing.Size(82, 15)
        Me.lblTokenExt.TabIndex = 18
        Me.lblTokenExt.Text = "Ext. Expires In:"
        Me.lblTokenExt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTokenExpires
        '
        Me.lblTokenExpires.AutoSize = True
        Me.lblTokenExpires.Location = New System.Drawing.Point(32, 387)
        Me.lblTokenExpires.Name = "lblTokenExpires"
        Me.lblTokenExpires.Size = New System.Drawing.Size(60, 15)
        Me.lblTokenExpires.TabIndex = 15
        Me.lblTokenExpires.Text = "Expires In:"
        Me.lblTokenExpires.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTokenScope
        '
        Me.lblTokenScope.AutoSize = True
        Me.lblTokenScope.Location = New System.Drawing.Point(50, 358)
        Me.lblTokenScope.Name = "lblTokenScope"
        Me.lblTokenScope.Size = New System.Drawing.Size(42, 15)
        Me.lblTokenScope.TabIndex = 13
        Me.lblTokenScope.Text = "Scope:"
        Me.lblTokenScope.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTokenType
        '
        Me.lblTokenType.AutoSize = True
        Me.lblTokenType.Location = New System.Drawing.Point(24, 329)
        Me.lblTokenType.Name = "lblTokenType"
        Me.lblTokenType.Size = New System.Drawing.Size(68, 15)
        Me.lblTokenType.TabIndex = 11
        Me.lblTokenType.Text = "Token Type:"
        Me.lblTokenType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRawOutput
        '
        Me.lblRawOutput.AutoSize = True
        Me.lblRawOutput.Location = New System.Drawing.Point(16, 29)
        Me.lblRawOutput.Name = "lblRawOutput"
        Me.lblRawOutput.Size = New System.Drawing.Size(32, 15)
        Me.lblRawOutput.TabIndex = 0
        Me.lblRawOutput.Text = "Raw:"
        Me.lblRawOutput.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtRawOutput
        '
        Me.txtRawOutput.Location = New System.Drawing.Point(16, 47)
        Me.txtRawOutput.Multiline = True
        Me.txtRawOutput.Name = "txtRawOutput"
        Me.txtRawOutput.ReadOnly = True
        Me.txtRawOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRawOutput.Size = New System.Drawing.Size(730, 265)
        Me.txtRawOutput.TabIndex = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 811)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.grpInputs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "OAUTH Get Token"
        Me.grpInputs.ResumeLayout(False)
        Me.grpInputs.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpInputs As GroupBox
    Friend WithEvents txtScope As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtGrantType As TextBox
    Friend WithEvents txtClientSecret As TextBox
    Friend WithEvents txtClientId As TextBox
    Friend WithEvents txtURL As TextBox
    Friend WithEvents lblURL As Label
    Friend WithEvents lblScope As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblGrantType As Label
    Friend WithEvents lblClientSecret As Label
    Friend WithEvents lblClientId As Label
    Friend WithEvents cmdGenerate As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents lblRawOutput As Label
    Friend WithEvents txtRawOutput As TextBox
    Friend WithEvents txtToken As TextBox
    Friend WithEvents txtTokenExt As TextBox
    Friend WithEvents txtTokenExpires As TextBox
    Friend WithEvents txtTokenScope As TextBox
    Friend WithEvents txtTokenType As TextBox
    Friend WithEvents lblToken As Label
    Friend WithEvents lblTokenExt As Label
    Friend WithEvents lblTokenExpires As Label
    Friend WithEvents lblTokenScope As Label
    Friend WithEvents lblTokenType As Label
    Friend WithEvents lblTokenExtHMS As Label
    Friend WithEvents lblTokenExpiresHMS As Label
End Class
