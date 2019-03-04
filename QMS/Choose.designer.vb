<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choose))
        Me.btnPI = New System.Windows.Forms.Button()
        Me.btnQL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPI
        '
        Me.btnPI.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPI.Location = New System.Drawing.Point(12, 12)
        Me.btnPI.Name = "btnPI"
        Me.btnPI.Size = New System.Drawing.Size(306, 71)
        Me.btnPI.TabIndex = 0
        Me.btnPI.Text = "VISITOR ENTRY"
        Me.btnPI.UseVisualStyleBackColor = True
        '
        'btnQL
        '
        Me.btnQL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQL.Location = New System.Drawing.Point(12, 89)
        Me.btnQL.Name = "btnQL"
        Me.btnQL.Size = New System.Drawing.Size(306, 72)
        Me.btnQL.TabIndex = 1
        Me.btnQL.Text = "QUEUE LIST"
        Me.btnQL.UseVisualStyleBackColor = True
        '
        'Choose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 173)
        Me.Controls.Add(Me.btnQL)
        Me.Controls.Add(Me.btnPI)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Choose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose what to OPEN"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPI As System.Windows.Forms.Button
    Friend WithEvents btnQL As System.Windows.Forms.Button
End Class
