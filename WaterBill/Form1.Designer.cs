namespace WaterBill
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            inputCustomerName = new TextBox();
            comboCustomerType = new ComboBox();
            inputLastMonth = new TextBox();
            inputThisMonth = new TextBox();
            label5 = new Label();
            inputNumberOfPeople = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            inputWaterConsumption = new TextBox();
            label8 = new Label();
            inputBasePrice = new TextBox();
            label9 = new Label();
            inputEnvFee = new TextBox();
            label10 = new Label();
            inputSubtotal = new TextBox();
            label11 = new Label();
            inputVATFee = new TextBox();
            label12 = new Label();
            inputTotal = new TextBox();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            invoicesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 37);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 125);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(608, 37);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 2;
            label3.Text = "Last month reading meter";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(608, 125);
            label4.Name = "label4";
            label4.Size = new Size(180, 20);
            label4.TabIndex = 3;
            label4.Text = "This month reading meter";
            // 
            // inputCustomerName
            // 
            inputCustomerName.Location = new Point(23, 60);
            inputCustomerName.Name = "inputCustomerName";
            inputCustomerName.Size = new Size(289, 27);
            inputCustomerName.TabIndex = 4;
            // 
            // comboCustomerType
            // 
            comboCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCustomerType.FormattingEnabled = true;
            comboCustomerType.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            comboCustomerType.Location = new Point(23, 148);
            comboCustomerType.Name = "comboCustomerType";
            comboCustomerType.Size = new Size(289, 28);
            comboCustomerType.TabIndex = 6;
            comboCustomerType.SelectedValueChanged += comboCustomerType_SelectedValueChanged;
            // 
            // inputLastMonth
            // 
            inputLastMonth.Location = new Point(608, 60);
            inputLastMonth.Name = "inputLastMonth";
            inputLastMonth.Size = new Size(289, 27);
            inputLastMonth.TabIndex = 7;
            // 
            // inputThisMonth
            // 
            inputThisMonth.Location = new Point(608, 148);
            inputThisMonth.Name = "inputThisMonth";
            inputThisMonth.Size = new Size(289, 27);
            inputThisMonth.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 213);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 9;
            label5.Text = "Number of people";
            // 
            // inputNumberOfPeople
            // 
            inputNumberOfPeople.Location = new Point(23, 236);
            inputNumberOfPeople.Name = "inputNumberOfPeople";
            inputNumberOfPeople.Size = new Size(289, 27);
            inputNumberOfPeople.TabIndex = 10;
            inputNumberOfPeople.TextChanged += inputNumberOfPeople_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(608, 206);
            button1.Name = "button1";
            button1.Size = new Size(249, 57);
            button1.TabIndex = 11;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(23, 293);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 12;
            label6.Text = "Result";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 337);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 13;
            label7.Text = "Water consumption:";
            // 
            // inputWaterConsumption
            // 
            inputWaterConsumption.Enabled = false;
            inputWaterConsumption.Location = new Point(170, 334);
            inputWaterConsumption.Name = "inputWaterConsumption";
            inputWaterConsumption.Size = new Size(142, 27);
            inputWaterConsumption.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 379);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 15;
            label8.Text = "Base Price";
            // 
            // inputBasePrice
            // 
            inputBasePrice.Enabled = false;
            inputBasePrice.Location = new Point(170, 376);
            inputBasePrice.Name = "inputBasePrice";
            inputBasePrice.Size = new Size(142, 27);
            inputBasePrice.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 424);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 16;
            label9.Text = "Env Fee";
            // 
            // inputEnvFee
            // 
            inputEnvFee.Enabled = false;
            inputEnvFee.Location = new Point(170, 421);
            inputEnvFee.Name = "inputEnvFee";
            inputEnvFee.Size = new Size(142, 27);
            inputEnvFee.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(612, 337);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 18;
            label10.Text = "Subtotal";
            // 
            // inputSubtotal
            // 
            inputSubtotal.Enabled = false;
            inputSubtotal.Location = new Point(679, 334);
            inputSubtotal.Name = "inputSubtotal";
            inputSubtotal.Size = new Size(142, 27);
            inputSubtotal.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(612, 379);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 20;
            label11.Text = "VAT Fee";
            // 
            // inputVATFee
            // 
            inputVATFee.Enabled = false;
            inputVATFee.Location = new Point(679, 376);
            inputVATFee.Name = "inputVATFee";
            inputVATFee.Size = new Size(142, 27);
            inputVATFee.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(606, 421);
            label12.Name = "label12";
            label12.Size = new Size(67, 31);
            label12.TabIndex = 22;
            label12.Text = "Total";
            // 
            // inputTotal
            // 
            inputTotal.Enabled = false;
            inputTotal.Font = new Font("Segoe UI", 15F);
            inputTotal.Location = new Point(679, 421);
            inputTotal.Name = "inputTotal";
            inputTotal.Size = new Size(142, 41);
            inputTotal.TabIndex = 23;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, invoicesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(923, 28);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // invoicesToolStripMenuItem
            // 
            invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            invoicesToolStripMenuItem.Size = new Size(76, 24);
            invoicesToolStripMenuItem.Text = "Invoices";
            invoicesToolStripMenuItem.Click += invoicesToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 516);
            Controls.Add(inputTotal);
            Controls.Add(label12);
            Controls.Add(inputVATFee);
            Controls.Add(label11);
            Controls.Add(inputSubtotal);
            Controls.Add(label10);
            Controls.Add(inputEnvFee);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(inputBasePrice);
            Controls.Add(inputWaterConsumption);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(inputNumberOfPeople);
            Controls.Add(label5);
            Controls.Add(inputThisMonth);
            Controls.Add(inputLastMonth);
            Controls.Add(comboCustomerType);
            Controls.Add(inputCustomerName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WaterBill";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox inputCustomerName;
        private ComboBox comboCustomerType;
        private TextBox inputLastMonth;
        private TextBox inputThisMonth;
        private Label label5;
        private TextBox inputNumberOfPeople;
        private Button button1;
        private Label label6;
        private Label label7;
        private TextBox inputWaterConsumption;
        private Label label8;
        private TextBox inputBasePrice;
        private Label label9;
        private TextBox inputEnvFee;
        private Label label10;
        private TextBox inputSubtotal;
        private Label label11;
        private TextBox inputVATFee;
        private Label label12;
        private TextBox inputTotal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem invoicesToolStripMenuItem;
    }
}
