namespace WaterBill
{
    public partial class Form1 : Form
    {
        List<Invoice> invoices = new List<Invoice>();
        private InvoiceListForm? invoiceListForm;

        public Form1()
        {
            InitializeComponent();
            inputNumberOfPeople.Enabled = false;

            btnExportInvoice.Enabled = false;
        }

        private void inputNumberOfPeople_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboCustomerType_SelectedValueChanged(object sender, EventArgs e)
        {
            // Fix NullReferenceException when SelectedItem is null
            if (comboCustomerType.SelectedItem == null)
            {
                inputNumberOfPeople.Enabled = false;
                return;
            }

            string customerType = comboCustomerType.SelectedItem.ToString();
            inputNumberOfPeople.Enabled = (customerType == "Household customer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validate Customer Name
                if (string.IsNullOrWhiteSpace(inputCustomerName.Text))
                {
                    MessageBox.Show("Please enter the customer name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputCustomerName.Focus();
                    return;
                }

                // 2. Validate Customer Type Selection
                if (comboCustomerType.SelectedItem == null)
                {
                    MessageBox.Show("Please select a customer type!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboCustomerType.Focus();
                    return;
                }

                // 3. Validate Water Meter Readings
                if (!int.TryParse(inputLastMonth.Text, out int lastMonthReading) || lastMonthReading < 0)
                {
                    MessageBox.Show("Last month's index must be a valid non-negative integer!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputLastMonth.Focus();
                    return;
                }

                if (!int.TryParse(inputThisMonth.Text, out int thisMonthReading) || thisMonthReading < 0)
                {
                    MessageBox.Show("This month's index must be a valid non-negative integer!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputThisMonth.Focus();
                    return;
                }

                // 4. Validate Meter Logic
                if (thisMonthReading < lastMonthReading)
                {
                    MessageBox.Show("This month's index must be greater than or equal to last month's index!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputThisMonth.Focus();
                    return;
                }

                int waterConsumption = thisMonthReading - lastMonthReading;
                string customerType = comboCustomerType.SelectedItem.ToString();
                double basePrice = 0;
                double envFee = 0;
                int numberOfPeople = 0;

                // 5. Calculate Price based on Customer Type
                if (customerType == "Household customer")
                {
                    if (!int.TryParse(inputNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0)
                    {
                        MessageBox.Show("Number of people must be an integer greater than 0!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        inputNumberOfPeople.Focus();
                        return;
                    }

                    double consumptionPerPerson = (double)waterConsumption / numberOfPeople;

                    if (consumptionPerPerson < 10)
                    {
                        basePrice = 5973;
                        envFee = 597.3;
                    }
                    else if (consumptionPerPerson >= 10 && consumptionPerPerson < 20)
                    {
                        basePrice = 7052;
                        envFee = 705.2;
                    }
                    else if (consumptionPerPerson >= 20 && consumptionPerPerson < 30)
                    {
                        basePrice = 8699;
                        envFee = 866.90;
                    }
                    else
                    {
                        basePrice = 15929;
                        envFee = 1592.9;
                    }
                }
                else if (customerType == "Administrative agency, public services")
                {
                    basePrice = 9955;
                    envFee = 995.5;
                }
                else if (customerType == "Production units")
                {
                    basePrice = 11615;
                    envFee = 1161.5;
                }
                else if (customerType == "Business services")
                {
                    basePrice = 22068;
                    envFee = 2206.8;
                }

                // 6. Calculate Totals
                double subtotal = basePrice * waterConsumption;
                double vatFee = subtotal * 0.1;
                double total = subtotal + vatFee + envFee;

                // Display Results
                inputWaterConsumption.Text = waterConsumption.ToString();
                inputBasePrice.Text = basePrice.ToString("F2");
                inputEnvFee.Text = envFee.ToString("F2");
                inputSubtotal.Text = subtotal.ToString("F2");
                inputVATFee.Text = vatFee.ToString("F2");
                inputTotal.Text = total.ToString("F2");

                btnExportInvoice.Enabled = true;

                // Save Invoice
                Invoice invoice = new Invoice
                {
                    CustomerName = inputCustomerName.Text.Trim(),
                    CustomerType = customerType,
                    LastMonthReading = lastMonthReading,
                    ThisMonthReading = thisMonthReading,
                    NumberOfPeople = numberOfPeople,
                    WaterConsumption = waterConsumption,
                    BasePrice = basePrice,
                    EnvFee = envFee,
                    SubTotal = subtotal,
                    VATFee = vatFee,
                    TotalPrice = total
                };

                invoices.Add(invoice);
                MessageBox.Show("Invoice calculated and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Global exception handler for unforeseen crashes
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invoiceListForm == null || invoiceListForm.IsDisposed)
            {
                invoiceListForm = new InvoiceListForm(invoices);
                invoiceListForm.Show();
            }
            else
            {
                invoiceListForm.LoadInvoices();
                invoiceListForm.BringToFront();
                invoiceListForm.Focus();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void inputCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            inputCustomerName.Clear();
            inputLastMonth.Clear();
            inputThisMonth.Clear();
            inputNumberOfPeople.Clear();
            comboCustomerType.SelectedIndex = -1;

            inputWaterConsumption.Clear();
            inputBasePrice.Clear();
            inputEnvFee.Clear();
            inputSubtotal.Clear();
            inputVATFee.Clear();
            inputTotal.Clear();

            btnExportInvoice.Enabled = false;

            MessageBox.Show("All fields have been cleared successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            inputCustomerName.Focus();
        }

        private void btnExportInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputTotal.Text))
            {
                MessageBox.Show("Please calculate the water bill before exporting the invoice!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open file save dialog
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "HTML File (*.html)|*.html|All Files (*.*)|*.*";
                sfd.FileName = $"Invoice_{inputCustomerName.Text.Trim()}_{DateTime.Now:yyyyMMdd_HHmm}.html";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Professional Invoice Template in English
                        string htmlContent = $@"
                <!DOCTYPE html>
                <html>
                <head>
                    <meta charset='utf-8'>
                    <style>
                        body {{ font-family: 'Segoe UI', Arial, sans-serif; margin: 30px; background-color: #F8F9FA; }}
                        .invoice-card {{ background: #ffffff; padding: 30px; border-radius: 8px; border: 1px solid #E5E7EB; max-width: 550px; margin: auto; box-shadow: 0 4px 6px rgba(0,0,0,0.05); }}
                        .header {{ text-align: center; border-bottom: 2px solid #1E3A8A; padding-bottom: 10px; margin-bottom: 20px; }}
                        .header h2 {{ color: #1E3A8A; margin: 0; text-transform: uppercase; font-size: 22px; }}
                        .header p {{ color: #6B7280; margin: 5px 0 0 0; font-size: 13px; }}
                        .info-table, .data-table {{ width: 100%; border-collapse: collapse; margin-bottom: 15px; }}
                        .info-table td {{ padding: 6px 0; font-size: 14px; color: #374151; }}
                        .info-label {{ font-weight: bold; color: #1F2937; width: 45%; }}
                        .data-table th {{ background-color: #1E3A8A; color: white; padding: 8px; text-align: left; font-size: 13px; }}
                        .data-table td {{ padding: 8px; border-bottom: 1px solid #E5E7EB; font-size: 13px; }}
                        .text-right {{ text-align: right; }}
                        .total-row {{ background-color: #FEF3C7; font-weight: bold; color: #1E3A8A; font-size: 15px; }}
                        .footer {{ text-align: center; margin-top: 25px; color: #9CA3AF; font-size: 12px; border-top: 1px dashed #E5E7EB; padding-top: 10px; }}
                    </style>
                </head>
                <body>
                    <div class='invoice-card'>
                        <div class='header'>
                            <h2>WATER BILL INVOICE</h2>
                            <p>Official Billing Document</p>
                        </div>

                        <table class='info-table'>
                            <tr><td class='info-label'>Date & Time:</td><td>{dtpInvoiceDate.Value:dd/MM/yyyy HH:mm}</td></tr>
                            <tr><td class='info-label'>Customer Name:</td><td>{inputCustomerName.Text}</td></tr>
                            <tr><td class='info-label'>Customer Type:</td><td>{comboCustomerType.SelectedItem}</td></tr>
                            ";

                        if (comboCustomerType.SelectedItem?.ToString() == "Household customer")
                        {
                            htmlContent += $"<tr><td class='info-label'>Number of People:</td><td>{inputNumberOfPeople.Text}</td></tr>";
                        }

                        htmlContent += $@"
                        </table>

                        <table class='data-table'>
                            <thead>
                                <tr><th>Description</th><th class='text-right'>Value</th></tr>
                            </thead>
                            <tbody>
                                <tr><td>Last Month Index</td><td class='text-right'>{inputLastMonth.Text}</td></tr>
                                <tr><td>This Month Index</td><td class='text-right'>{inputThisMonth.Text}</td></tr>
                                <tr><td>Water Consumption</td><td class='text-right'>{inputWaterConsumption.Text} m³</td></tr>
                                <tr><td>Base Price</td><td class='text-right'>{inputBasePrice.Text} VND</td></tr>
                                <tr><td>Subtotal</td><td class='text-right'>{inputSubtotal.Text} VND</td></tr>
                                <tr><td>Environment Fee</td><td class='text-right'>{inputEnvFee.Text} VND</td></tr>
                                <tr><td>VAT Fee (10%)</td><td class='text-right'>{inputVATFee.Text} VND</td></tr>
                                <tr class='total-row'><td>TOTAL AMOUNT</td><td class='text-right'>{inputTotal.Text} VND</td></tr>
                            </tbody>
                        </table>

                        <div class='footer'>
                            <p>Thank you for your payment!</p>
                        </div>
                    </div>
                </body>
                </html>";

                        // Save file
                        System.IO.File.WriteAllText(sfd.FileName, htmlContent, System.Text.Encoding.UTF8);

                        // Open exported invoice in browser
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = sfd.FileName,
                            UseShellExecute = true
                        });

                        MessageBox.Show("Invoice exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}