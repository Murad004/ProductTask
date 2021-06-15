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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddProdButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                ProductListBox.Items.Add(form2.product);
            }
            EditProductBtn.Enabled = true;
            RemoveProductBtn.Enabled = true;
            EditProductBtn.Click += EditProductBtn_Click;
        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            var pr = ProductListBox.SelectedItem as Product;
            

        }
    }
}
