Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display the Dormitory price in the list box
        lstDormitory.Items.Add("Allen Hall - 2,500.00 ")
        lstDormitory.Items.Add("Pike Hall - 2,200.00")
        lstDormitory.Items.Add("Farthing Hall - 2,100.00")
        lstDormitory.Items.Add("UniversitySuites - 2,800.00")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAddDorm.Click
        ' if user don't choose any price in list box 
        Select Case lstDormitory.SelectedIndex
            Case -1
                MessageBox.Show("Select A Dormitory Please!")
        End Select

        'Determine the value in Module and display the value of price to lblDormitory 
        Select Case lstDormitory.SelectedIndex
            Case 0
                lblDormCost.Text = PriceConstants.Allen_Hall.ToString("c2")
            Case 1
                lblDormCost.Text = PriceConstants.Pike_Hall.ToString("c2")
            Case 2
                lblDormCost.Text = PriceConstants.Farthing_Hall.ToString("c2")
            Case 3
                lblDormCost.Text = PriceConstants.UniversitySuites.ToString("c2")
        End Select

    End Sub

    Private Sub btnViewMealPlan_Click(sender As Object, e As EventArgs) Handles btnViewMealPlan.Click
        'Display the second form (Meal Plan)
        Me.Hide()
        frmMealPlans.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all the label except the list box
        lblDormCost.Text = String.Empty
        lblMealPlanCost.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
