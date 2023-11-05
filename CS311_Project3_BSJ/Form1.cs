namespace CS311_Project3_BSJ
{
    public partial class FormEatZaPizza : Form
    {
        double cost;
        String size, crust;
        List<String> toppings = new List<String>();

        public FormEatZaPizza()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        }

        private void Summarize()
        {
            //resets the rich textbox and cost value for the next summary
            toppings.Clear();
            cost = 0;

            //exits method if no size is selected
            if (cmbSize.SelectedItem == null)
            {
                toppings.Add("Please select a size!");
                rtfSummary.Lines = toppings.ToArray();
                return;
            }

            //sets values for the initial line of the pizza summary and places it in a list to use for the richtextbox
            size = cmbSize.Text;
            crust = grpCrust.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            toppings.Add("You ordered a " + size.ToString() + " with " + crust.ToString() + " crust and the following toppings:");

            //switch case to add the correct pricing for the size
            switch (cmbSize.SelectedIndex)
            {
                case 0: cost += 2; break;
                case 1: cost += 5; break;
                case 2: cost += 10; break;
                case 3: cost += 15; break;
                case 4: cost += 20; break;
            }

            //loops through all toppings, correctly pricing them and entering them into the order summary
            foreach (var item in pnlToppings.Controls.OfType<CheckBox>().OrderBy(ee => ee.TabIndex))
            {
                //checks to see if an item is checked
                if (item.Checked == true)
                {
                    toppings.Add("\u2022 " + item.Text);

                    //checks for whether the item is a premium topping based on TabIndex
                    if (item.TabIndex <= 15)
                    {
                        cost += 2;
                    }
                    else
                    {
                        cost += 1;
                    }
                }

            }

            //tabulates total, subtotal, and tax, putting them in correct textboxes
            txtSubTotal.Text = String.Format("{0:C}", cost);
            txtTax.Text = String.Format("{0:C}", cost * 0.06);
            txtTotal.Text = String.Format("{0:C}", cost * 1.06);

            //prints order summary
            rtfSummary.Lines = toppings.ToArray();
        }
    }
}