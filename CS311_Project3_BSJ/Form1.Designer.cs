namespace CS311_Project3_BSJ
{
    partial class FormEatZaPizza
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEatZaPizza));
            pictPizza = new PictureBox();
            pnlSelection = new Panel();
            grpCrust = new GroupBox();
            rdoRegular = new RadioButton();
            rdoThin = new RadioButton();
            rdoThick = new RadioButton();
            lblToppings = new Label();
            cmbSize = new ComboBox();
            lblSize = new Label();
            pnlToppings = new Panel();
            ckbMushroom = new CheckBox();
            ckbExtraCheese = new CheckBox();
            ckbJalapeno = new CheckBox();
            ckbBananaPepper = new CheckBox();
            ckbGreenOlive = new CheckBox();
            ckbBlackOlive = new CheckBox();
            ckbGreenPepper = new CheckBox();
            ckbOnion = new CheckBox();
            ckbSpicyItalianSausage = new CheckBox();
            ckbCanadianBacon = new CheckBox();
            ckbSausage = new CheckBox();
            ckbPepperoni = new CheckBox();
            lblEatZaPizza = new Label();
            rtfSummary = new RichTextBox();
            lblOrderSummary = new Label();
            lblSubTotal = new Label();
            lblTotal = new Label();
            lblTax = new Label();
            txtSubTotal = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictPizza).BeginInit();
            pnlSelection.SuspendLayout();
            grpCrust.SuspendLayout();
            pnlToppings.SuspendLayout();
            SuspendLayout();
            // 
            // pictPizza
            // 
            pictPizza.BackgroundImage = (Image)resources.GetObject("pictPizza.BackgroundImage");
            pictPizza.BackgroundImageLayout = ImageLayout.Stretch;
            pictPizza.Location = new Point(12, 12);
            pictPizza.Name = "pictPizza";
            pictPizza.Size = new Size(228, 161);
            pictPizza.TabIndex = 0;
            pictPizza.TabStop = false;
            // 
            // pnlSelection
            // 
            pnlSelection.BorderStyle = BorderStyle.FixedSingle;
            pnlSelection.Controls.Add(grpCrust);
            pnlSelection.Controls.Add(lblToppings);
            pnlSelection.Controls.Add(cmbSize);
            pnlSelection.Controls.Add(lblSize);
            pnlSelection.Controls.Add(pnlToppings);
            pnlSelection.Location = new Point(12, 179);
            pnlSelection.Name = "pnlSelection";
            pnlSelection.Size = new Size(742, 180);
            pnlSelection.TabIndex = 1;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rdoRegular);
            grpCrust.Controls.Add(rdoThin);
            grpCrust.Controls.Add(rdoThick);
            grpCrust.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpCrust.Location = new Point(233, 13);
            grpCrust.Name = "grpCrust";
            grpCrust.Size = new Size(283, 23);
            grpCrust.TabIndex = 16;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust Type:";
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdoRegular.Location = new Point(206, 1);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(68, 19);
            rdoRegular.TabIndex = 3;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Checked = true;
            rdoThin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdoThin.Location = new Point(90, 1);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(49, 19);
            rdoThin.TabIndex = 1;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdoThick.Location = new Point(145, 1);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(55, 19);
            rdoThick.TabIndex = 2;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToppings.Location = new Point(3, 53);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(59, 15);
            lblToppings.TabIndex = 2;
            lblToppings.Text = "Toppings:";
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cmbSize.Location = new Point(66, 13);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(121, 23);
            cmbSize.TabIndex = 1;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.Location = new Point(27, 21);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(33, 15);
            lblSize.TabIndex = 0;
            lblSize.Text = "Size:";
            // 
            // pnlToppings
            // 
            pnlToppings.Controls.Add(ckbMushroom);
            pnlToppings.Controls.Add(ckbExtraCheese);
            pnlToppings.Controls.Add(ckbJalapeno);
            pnlToppings.Controls.Add(ckbBananaPepper);
            pnlToppings.Controls.Add(ckbGreenOlive);
            pnlToppings.Controls.Add(ckbBlackOlive);
            pnlToppings.Controls.Add(ckbGreenPepper);
            pnlToppings.Controls.Add(ckbOnion);
            pnlToppings.Controls.Add(ckbSpicyItalianSausage);
            pnlToppings.Controls.Add(ckbCanadianBacon);
            pnlToppings.Controls.Add(ckbSausage);
            pnlToppings.Controls.Add(ckbPepperoni);
            pnlToppings.Location = new Point(27, 71);
            pnlToppings.Name = "pnlToppings";
            pnlToppings.Size = new Size(640, 100);
            pnlToppings.TabIndex = 17;
            // 
            // ckbMushroom
            // 
            ckbMushroom.AutoSize = true;
            ckbMushroom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbMushroom.Location = new Point(528, 78);
            ckbMushroom.Name = "ckbMushroom";
            ckbMushroom.Size = new Size(86, 19);
            ckbMushroom.TabIndex = 23;
            ckbMushroom.Text = "Mushroom";
            ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            ckbExtraCheese.AutoSize = true;
            ckbExtraCheese.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbExtraCheese.Location = new Point(528, 54);
            ckbExtraCheese.Name = "ckbExtraCheese";
            ckbExtraCheese.Size = new Size(98, 19);
            ckbExtraCheese.TabIndex = 22;
            ckbExtraCheese.Text = "Extra Cheese";
            ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbJalapeno
            // 
            ckbJalapeno.AutoSize = true;
            ckbJalapeno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbJalapeno.Location = new Point(528, 28);
            ckbJalapeno.Name = "ckbJalapeno";
            ckbJalapeno.Size = new Size(74, 19);
            ckbJalapeno.TabIndex = 21;
            ckbJalapeno.Text = "Jalapeno";
            ckbJalapeno.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPepper
            // 
            ckbBananaPepper.AutoSize = true;
            ckbBananaPepper.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbBananaPepper.Location = new Point(528, 3);
            ckbBananaPepper.Name = "ckbBananaPepper";
            ckbBananaPepper.Size = new Size(109, 19);
            ckbBananaPepper.TabIndex = 20;
            ckbBananaPepper.Text = "Banana Pepper";
            ckbBananaPepper.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlive
            // 
            ckbGreenOlive.AutoSize = true;
            ckbGreenOlive.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbGreenOlive.Location = new Point(261, 78);
            ckbGreenOlive.Name = "ckbGreenOlive";
            ckbGreenOlive.Size = new Size(93, 19);
            ckbGreenOlive.TabIndex = 19;
            ckbGreenOlive.Text = "Green Olive";
            ckbGreenOlive.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlive
            // 
            ckbBlackOlive.AutoSize = true;
            ckbBlackOlive.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbBlackOlive.Location = new Point(261, 53);
            ckbBlackOlive.Name = "ckbBlackOlive";
            ckbBlackOlive.Size = new Size(88, 19);
            ckbBlackOlive.TabIndex = 18;
            ckbBlackOlive.Text = "Black Olive";
            ckbBlackOlive.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            ckbGreenPepper.AutoSize = true;
            ckbGreenPepper.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbGreenPepper.Location = new Point(261, 28);
            ckbGreenPepper.Name = "ckbGreenPepper";
            ckbGreenPepper.Size = new Size(104, 19);
            ckbGreenPepper.TabIndex = 17;
            ckbGreenPepper.Text = "Green Pepper";
            ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbOnion.Location = new Point(261, 3);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(59, 19);
            ckbOnion.TabIndex = 16;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            ckbSpicyItalianSausage.AutoSize = true;
            ckbSpicyItalianSausage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbSpicyItalianSausage.Location = new Point(4, 78);
            ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            ckbSpicyItalianSausage.Size = new Size(140, 19);
            ckbSpicyItalianSausage.TabIndex = 15;
            ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            ckbCanadianBacon.AutoSize = true;
            ckbCanadianBacon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbCanadianBacon.Location = new Point(4, 53);
            ckbCanadianBacon.Name = "ckbCanadianBacon";
            ckbCanadianBacon.Size = new Size(112, 19);
            ckbCanadianBacon.TabIndex = 14;
            ckbCanadianBacon.Text = "Canadian Bacon";
            ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbSausage.Location = new Point(4, 28);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(71, 19);
            ckbSausage.TabIndex = 13;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            ckbPepperoni.AutoSize = true;
            ckbPepperoni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbPepperoni.Location = new Point(4, 3);
            ckbPepperoni.Name = "ckbPepperoni";
            ckbPepperoni.Size = new Size(83, 19);
            ckbPepperoni.TabIndex = 12;
            ckbPepperoni.Text = "Pepperoni";
            ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // lblEatZaPizza
            // 
            lblEatZaPizza.AutoSize = true;
            lblEatZaPizza.Font = new Font("Pristina", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblEatZaPizza.Location = new Point(246, 12);
            lblEatZaPizza.Name = "lblEatZaPizza";
            lblEatZaPizza.Size = new Size(476, 126);
            lblEatZaPizza.TabIndex = 2;
            lblEatZaPizza.Text = "Eat Za Pizza";
            // 
            // rtfSummary
            // 
            rtfSummary.Location = new Point(137, 365);
            rtfSummary.Name = "rtfSummary";
            rtfSummary.ReadOnly = true;
            rtfSummary.Size = new Size(436, 157);
            rtfSummary.TabIndex = 3;
            rtfSummary.Text = "";
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderSummary.Location = new Point(32, 368);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(99, 15);
            lblOrderSummary.TabIndex = 4;
            lblOrderSummary.Text = "Order Summary:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(580, 371);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(58, 15);
            lblSubTotal.TabIndex = 5;
            lblSubTotal.Text = "SubTotal:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(601, 429);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(37, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTax.Location = new Point(607, 400);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(29, 15);
            lblTax.TabIndex = 7;
            lblTax.Text = "Tax:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(654, 368);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 8;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(654, 397);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 9;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(654, 426);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 10;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(579, 462);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(175, 60);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // FormEatZaPizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 536);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubTotal);
            Controls.Add(lblTax);
            Controls.Add(lblTotal);
            Controls.Add(lblSubTotal);
            Controls.Add(lblOrderSummary);
            Controls.Add(rtfSummary);
            Controls.Add(lblEatZaPizza);
            Controls.Add(pictPizza);
            Controls.Add(pnlSelection);
            Name = "FormEatZaPizza";
            Text = "Eat Za Pizza";
            ((System.ComponentModel.ISupportInitialize)pictPizza).EndInit();
            pnlSelection.ResumeLayout(false);
            pnlSelection.PerformLayout();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            pnlToppings.ResumeLayout(false);
            pnlToppings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictPizza;
        private Panel pnlSelection;
        private ComboBox cmbSize;
        private Label lblSize;
        private Label lblEatZaPizza;
        private Label lblToppings;
        private RichTextBox rtfSummary;
        private Label lblOrderSummary;
        private Label lblSubTotal;
        private Label lblTotal;
        private Label lblTax;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Panel pnlCrust;
        private RadioButton rdoRegular;
        private Label lblCrustType;
        private GroupBox grpCrust;
        private RadioButton rdoThin;
        private RadioButton rdoThick;
        private Panel pnlToppings;
        private CheckBox ckbMushroom;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbJalapeno;
        private CheckBox ckbBananaPepper;
        private CheckBox ckbGreenOlive;
        private CheckBox ckbBlackOlive;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbOnion;
        private CheckBox ckbSpicyItalianSausage;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbSausage;
        private CheckBox ckbPepperoni;
    }
}