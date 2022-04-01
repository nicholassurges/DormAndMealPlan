Public Class frmMealPlans
    Private Sub btnAddMealPlan_Click(sender As Object, e As EventArgs) Handles btnAddMealPlan.Click
        'Declare the variable 
        Dim MealPlans As Integer

        ' if user doesn't choose any Meal Plan then display message box 
        Select Case lstMealPlan.SelectedIndex
            Case -1
                MessageBox.Show("Select A Meal Plan Please!")

        End Select

        ' Determine the value in Module and display the value of price to lblMeal_Plan in form Main 
        Select Case lstMealPlan.SelectedIndex
            Case 0
                frmMain.lblMealPlanCost.Text = PriceConstants.Meal_Plan_7.ToString("c2")
                MealPlans = CInt(Meal_Plan_7.ToString("c2"))
            Case 1
                frmMain.lblMealPlanCost.Text = PriceConstants.Meal_Plan_14.ToString("c2")
                MealPlans = CInt(Meal_Plan_14.ToString("c2"))
            Case 2
                frmMain.lblMealPlanCost.Text = PriceConstants.Meal_Plan_Unilimited.ToString("c2")
                MealPlans = CInt(Meal_Plan_Unilimited.ToString("c2"))
        End Select

        'Calculate the total of Dormitory and Meal Plan and display it to form Main
        frmMain.lblTotal.Text = (CInt(frmMain.lblDormCost.Text) + MealPlans).ToString("c2")

        'Display to the form Main (frmMain)
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub frmMealPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display the Weedkly Meal Plan price in the list box
        lstMealPlan.Items.Add("7 Meals - 1,560.00 ")
        lstMealPlan.Items.Add("14 Meals - 2,095.00")
        lstMealPlan.Items.Add("Unlimited Meals - 2,500.00")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close program
        Me.Close()
        frmMain.Show()
    End Sub
End Class