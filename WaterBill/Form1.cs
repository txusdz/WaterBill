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
    }
}