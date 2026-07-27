using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WaterBill
{
    public partial class InvoiceListForm : Form
    {
        private readonly List<Invoice> invoices;
        public InvoiceListForm(List<Invoice> invoices)
        {
            this.invoices = invoices;
            InitializeComponent();
            LoadInvoices();
        }
        public void LoadInvoices()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = invoices;
        }
    }
}
