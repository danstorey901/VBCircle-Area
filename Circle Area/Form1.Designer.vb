<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblRadiusInches = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAreaoftheCircle = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRadiusInches
        '
        Me.lblRadiusInches.AutoSize = True
        Me.lblRadiusInches.Location = New System.Drawing.Point(49, 63)
        Me.lblRadiusInches.Name = "lblRadiusInches"
        Me.lblRadiusInches.Size = New System.Drawing.Size(111, 13)
        Me.lblRadiusInches.TabIndex = 0
        Me.lblRadiusInches.Text = "Enter radius in inches:"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(166, 60)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtRadius.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(52, 218)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(133, 218)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(214, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAreaoftheCircle
        '
        Me.lblAreaoftheCircle.AutoSize = True
        Me.lblAreaoftheCircle.Location = New System.Drawing.Point(130, 122)
        Me.lblAreaoftheCircle.Name = "lblAreaoftheCircle"
        Me.lblAreaoftheCircle.Size = New System.Drawing.Size(88, 13)
        Me.lblAreaoftheCircle.TabIndex = 5
        Me.lblAreaoftheCircle.Text = "Area of the Circle"
        '
        'lblSum
        '
        Me.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSum.Location = New System.Drawing.Point(96, 135)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(151, 53)
        Me.lblSum.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 309)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.lblAreaoftheCircle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.lblRadiusInches)
        Me.Name = "Form1"
        Me.Text = "Circle Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRadiusInches As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAreaoftheCircle As Label
    Friend WithEvents lblSum As Label
End Class
