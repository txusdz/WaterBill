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
            panel1 = new Panel();
            btnClear = new Button();
            dtpInvoiceDate = new DateTimePicker();
            btnExportInvoice = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.FromArgb(15, 58, 64);
            label1.Location = new Point(27, 71);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(15, 58, 64);
            label2.Location = new Point(27, 155);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 1;
            label2.Text = "Customer Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(15, 58, 64);
            label3.Location = new Point(645, 71);
            label3.Name = "label3";
            label3.Size = new Size(229, 25);
            label3.TabIndex = 2;
            label3.Text = "Last month reading meter";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(15, 58, 64);
            label4.Location = new Point(645, 155);
            label4.Name = "label4";
            label4.Size = new Size(230, 25);
            label4.TabIndex = 3;
            label4.Text = "This month reading meter";
            // 
            // inputCustomerName
            // 
            inputCustomerName.BackColor = Color.White;
            inputCustomerName.Location = new Point(27, 108);
            inputCustomerName.Name = "inputCustomerName";
            inputCustomerName.Size = new Size(289, 26);
            inputCustomerName.TabIndex = 4;
            inputCustomerName.TextChanged += inputCustomerName_TextChanged;
            // 
            // comboCustomerType
            // 
            comboCustomerType.BackColor = Color.White;
            comboCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCustomerType.FlatStyle = FlatStyle.Flat;
            comboCustomerType.Font = new Font("Segoe UI", 11F);
            comboCustomerType.ForeColor = Color.Black;
            comboCustomerType.FormattingEnabled = true;
            comboCustomerType.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            comboCustomerType.Location = new Point(27, 183);
            comboCustomerType.Name = "comboCustomerType";
            comboCustomerType.Size = new Size(289, 33);
            comboCustomerType.TabIndex = 6;
            comboCustomerType.SelectedValueChanged += comboCustomerType_SelectedValueChanged;
            // 
            // inputLastMonth
            // 
            inputLastMonth.BackColor = Color.White;
            inputLastMonth.Location = new Point(645, 108);
            inputLastMonth.Name = "inputLastMonth";
            inputLastMonth.Size = new Size(289, 26);
            inputLastMonth.TabIndex = 7;
            // 
            // inputThisMonth
            // 
            inputThisMonth.BackColor = Color.White;
            inputThisMonth.Location = new Point(645, 190);
            inputThisMonth.Name = "inputThisMonth";
            inputThisMonth.Size = new Size(289, 26);
            inputThisMonth.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.FromArgb(15, 58, 64);
            label5.Location = new Point(27, 238);
            label5.Name = "label5";
            label5.Size = new Size(166, 25);
            label5.TabIndex = 9;
            label5.Text = "Number of people";
            // 
            // inputNumberOfPeople
            // 
            inputNumberOfPeople.BackColor = Color.White;
            inputNumberOfPeople.Location = new Point(27, 281);
            inputNumberOfPeople.Name = "inputNumberOfPeople";
            inputNumberOfPeople.Size = new Size(289, 26);
            inputNumberOfPeople.TabIndex = 10;
            inputNumberOfPeople.TextChanged += inputNumberOfPeople_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(212, 163, 115);
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(645, 238);
            button1.Name = "button1";
            button1.Size = new Size(249, 69);
            button1.TabIndex = 11;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(248, 245, 240);
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.FromArgb(15, 58, 64);
            label6.Location = new Point(34, 343);
            label6.Name = "label6";
            label6.Size = new Size(81, 35);
            label6.TabIndex = 12;
            label6.Text = "Result";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(248, 245, 240);
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(15, 58, 64);
            label7.Location = new Point(34, 385);
            label7.Name = "label7";
            label7.Size = new Size(164, 23);
            label7.TabIndex = 13;
            label7.Text = "Water consumption:";
            // 
            // inputWaterConsumption
            // 
            inputWaterConsumption.BackColor = SystemColors.HighlightText;
            inputWaterConsumption.Enabled = false;
            inputWaterConsumption.Location = new Point(190, 49);
            inputWaterConsumption.Name = "inputWaterConsumption";
            inputWaterConsumption.Size = new Size(184, 26);
            inputWaterConsumption.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(248, 245, 240);
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.FromArgb(15, 58, 64);
            label8.Location = new Point(34, 424);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 15;
            label8.Text = "Base Price";
            // 
            // inputBasePrice
            // 
            inputBasePrice.Enabled = false;
            inputBasePrice.Location = new Point(190, 89);
            inputBasePrice.Name = "inputBasePrice";
            inputBasePrice.Size = new Size(184, 26);
            inputBasePrice.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(248, 245, 240);
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.FromArgb(15, 58, 64);
            label9.Location = new Point(34, 467);
            label9.Name = "label9";
            label9.Size = new Size(68, 23);
            label9.TabIndex = 16;
            label9.Text = "Env Fee";
            // 
            // inputEnvFee
            // 
            inputEnvFee.Enabled = false;
            inputEnvFee.Location = new Point(190, 131);
            inputEnvFee.Name = "inputEnvFee";
            inputEnvFee.Size = new Size(184, 26);
            inputEnvFee.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(248, 245, 240);
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.FromArgb(15, 58, 64);
            label10.Location = new Point(623, 385);
            label10.Name = "label10";
            label10.Size = new Size(74, 23);
            label10.TabIndex = 18;
            label10.Text = "Subtotal";
            // 
            // inputSubtotal
            // 
            inputSubtotal.Enabled = false;
            inputSubtotal.Location = new Point(686, 49);
            inputSubtotal.Name = "inputSubtotal";
            inputSubtotal.Size = new Size(184, 26);
            inputSubtotal.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(248, 245, 240);
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.FromArgb(15, 58, 64);
            label11.Location = new Point(623, 424);
            label11.Name = "label11";
            label11.Size = new Size(70, 23);
            label11.TabIndex = 20;
            label11.Text = "VAT Fee";
            // 
            // inputVATFee
            // 
            inputVATFee.Enabled = false;
            inputVATFee.Location = new Point(686, 89);
            inputVATFee.Name = "inputVATFee";
            inputVATFee.Size = new Size(184, 26);
            inputVATFee.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(248, 245, 240);
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(15, 58, 64);
            label12.Location = new Point(617, 464);
            label12.Name = "label12";
            label12.Size = new Size(67, 31);
            label12.TabIndex = 22;
            label12.Text = "Total";
            // 
            // inputTotal
            // 
            inputTotal.Enabled = false;
            inputTotal.Font = new Font("Segoe UI", 15F);
            inputTotal.Location = new Point(686, 131);
            inputTotal.Name = "inputTotal";
            inputTotal.Size = new Size(184, 41);
            inputTotal.TabIndex = 23;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, invoicesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1018, 28);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 245, 240);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(inputTotal);
            panel1.Controls.Add(inputWaterConsumption);
            panel1.Controls.Add(inputBasePrice);
            panel1.Controls.Add(inputVATFee);
            panel1.Controls.Add(inputEnvFee);
            panel1.Controls.Add(inputSubtotal);
            panel1.ForeColor = Color.WhiteSmoke;
            panel1.Location = new Point(12, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 216);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(717, 555);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 41);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dtpInvoiceDate
            // 
            dtpInvoiceDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpInvoiceDate.Enabled = false;
            dtpInvoiceDate.Format = DateTimePickerFormat.Custom;
            dtpInvoiceDate.Location = new Point(768, 31);
            dtpInvoiceDate.Name = "dtpInvoiceDate";
            dtpInvoiceDate.Size = new Size(250, 26);
            dtpInvoiceDate.TabIndex = 27;
            // 
            // btnExportInvoice
            // 
            btnExportInvoice.ForeColor = Color.Black;
            btnExportInvoice.Location = new Point(870, 556);
            btnExportInvoice.Name = "btnExportInvoice";
            btnExportInvoice.Size = new Size(119, 38);
            btnExportInvoice.TabIndex = 28;
            btnExportInvoice.Text = "Export Invoice";
            btnExportInvoice.UseVisualStyleBackColor = true;
            btnExportInvoice.Click += btnExportInvoice_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 245, 237);
            ClientSize = new Size(1018, 606);
            Controls.Add(btnExportInvoice);
            Controls.Add(dtpInvoiceDate);
            Controls.Add(btnClear);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
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
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 8.25F);
            ForeColor = Color.White;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WaterBill";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Button btnClear;
        private DateTimePicker dtpInvoiceDate;
        private Button btnExportInvoice;
    }
}
