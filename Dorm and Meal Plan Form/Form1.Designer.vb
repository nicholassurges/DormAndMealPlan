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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstDormitory = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMealPlanCost = New System.Windows.Forms.Label()
        Me.lblDormCost = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddDorm = New System.Windows.Forms.Button()
        Me.btnViewMealPlan = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(412, 200)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 43)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstDormitory)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Dormitory"
        '
        'lstDormitory
        '
        Me.lstDormitory.FormattingEnabled = True
        Me.lstDormitory.ItemHeight = 16
        Me.lstDormitory.Location = New System.Drawing.Point(19, 29)
        Me.lstDormitory.Name = "lstDormitory"
        Me.lstDormitory.Size = New System.Drawing.Size(198, 100)
        Me.lstDormitory.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblMealPlanCost)
        Me.GroupBox2.Controls.Add(Me.lblDormCost)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(260, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 159)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chargest for the Semester"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(96, 89)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 5
        '
        'lblMealPlanCost
        '
        Me.lblMealPlanCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMealPlanCost.Location = New System.Drawing.Point(96, 57)
        Me.lblMealPlanCost.Name = "lblMealPlanCost"
        Me.lblMealPlanCost.Size = New System.Drawing.Size(100, 23)
        Me.lblMealPlanCost.TabIndex = 4
        '
        'lblDormCost
        '
        Me.lblDormCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDormCost.Location = New System.Drawing.Point(96, 29)
        Me.lblDormCost.Name = "lblDormCost"
        Me.lblDormCost.Size = New System.Drawing.Size(100, 23)
        Me.lblDormCost.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Meal Plan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dormitory"
        '
        'btnAddDorm
        '
        Me.btnAddDorm.Location = New System.Drawing.Point(32, 200)
        Me.btnAddDorm.Name = "btnAddDorm"
        Me.btnAddDorm.Size = New System.Drawing.Size(84, 43)
        Me.btnAddDorm.TabIndex = 2
        Me.btnAddDorm.Text = "Add Dormitory"
        Me.btnAddDorm.UseVisualStyleBackColor = True
        '
        'btnViewMealPlan
        '
        Me.btnViewMealPlan.Location = New System.Drawing.Point(157, 200)
        Me.btnViewMealPlan.Name = "btnViewMealPlan"
        Me.btnViewMealPlan.Size = New System.Drawing.Size(84, 43)
        Me.btnViewMealPlan.TabIndex = 3
        Me.btnViewMealPlan.Text = "View Meal Plan"
        Me.btnViewMealPlan.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(284, 200)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 43)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 266)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnViewMealPlan)
        Me.Controls.Add(Me.btnAddDorm)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmMain"
        Me.Text = " Dorm and Meal Plan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstDormitory As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMealPlanCost As Label
    Friend WithEvents lblDormCost As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddDorm As Button
    Friend WithEvents btnViewMealPlan As Button
    Friend WithEvents btnClear As Button
End Class
