<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRegQty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.radRepeat = New System.Windows.Forms.RadioButton()
        Me.radOnce = New System.Windows.Forms.RadioButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(357, 97)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(72, 30)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculate"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(357, 149)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 33)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(51, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter # of Registrants"
        '
        'txtRegQty
        '
        Me.txtRegQty.Location = New System.Drawing.Point(214, 42)
        Me.txtRegQty.Name = "txtRegQty"
        Me.txtRegQty.Size = New System.Drawing.Size(51, 20)
        Me.txtRegQty.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 104)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Number of Registrants" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1       $795 per person" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2-4   $645 per person" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5-7   $475" &
    " per person" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8-16 $385 per person" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No more than 16 people are allowed " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from o" &
    "ne company" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(49, 290)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(443, 43)
        Me.lblMessage.TabIndex = 13
        Me.lblMessage.Text = "Please complete the registration form."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.radRepeat)
        Me.Panel2.Controls.Add(Me.radOnce)
        Me.Panel2.Location = New System.Drawing.Point(54, 227)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 47)
        Me.Panel2.TabIndex = 14
        '
        'radRepeat
        '
        Me.radRepeat.Location = New System.Drawing.Point(24, 23)
        Me.radRepeat.Name = "radRepeat"
        Me.radRepeat.Size = New System.Drawing.Size(153, 20)
        Me.radRepeat.TabIndex = 6
        Me.radRepeat.Text = "Attended Before"
        '
        'radOnce
        '
        Me.radOnce.Checked = True
        Me.radOnce.Location = New System.Drawing.Point(25, 3)
        Me.radOnce.Name = "radOnce"
        Me.radOnce.Size = New System.Drawing.Size(152, 20)
        Me.radOnce.TabIndex = 5
        Me.radOnce.TabStop = True
        Me.radOnce.Text = "First Time Attending"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 335)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRegQty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmMain"
        Me.Text = "App Developer's Conference Registration"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRegQty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents radRepeat As RadioButton
    Friend WithEvents radOnce As RadioButton
End Class
