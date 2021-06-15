using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6._2
{
    public partial class Form2 : Form
    {
        public string prodName { get; set; }
        public string Country { get; set; }
        public int Cost { get; set; }
        public Product product { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            prodName = ProductNameTxtB.Text;
            Country = OriginCountryTxtB.Text;
            Cost = int.Parse(ProductCostTxtB.Text);
            Product product1 = new Product { Name = prodName, Country = Country, Cost = Cost };
            product = product1;

        }

        private void CANCELbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
