<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMealPlans
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstMealPlan = New System.Windows.Forms.ListBox()
        Me.btnAddMealPlan = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstMealPlan)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Weekly Meal Plan"
        '
        'lstMealPlan
        '
        Me.lstMealPlan.FormattingEnabled = True
        Me.lstMealPlan.ItemHeight = 16
        Me.lstMealPlan.Location = New System.Drawing.Point(11, 30)
        Me.lstMealPlan.Name = "lstMealPlan"
        Me.lstMealPlan.Size = New System.Drawing.Size(321, 84)
        Me.lstMealPlan.TabIndex = 0
        Me.lstMealPlan.TabStop = False
        '
        'btnAddMealPlan
        '
        Me.btnAddMealPlan.Location = New System.Drawing.Point(375, 24)
        Me.btnAddMealPlan.Name = "btnAddMealPlan"
        Me.btnAddMealPlan.Size = New System.Drawing.Size(141, 55)
        Me.btnAddMealPlan.TabIndex = 1
        Me.btnAddMealPlan.Text = "Add Meal Plan"
        Me.btnAddMealPlan.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(375, 117)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(141, 55)
        Me.btnClose.TabIndex = 2
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMealPlans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 190)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddMealPlan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMealPlans"
        Me.Text = "Meal Plans"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstMealPlan As ListBox
    Friend WithEvents btnAddMealPlan As Button
    Friend WithEvents btnClose As Button
End Class
