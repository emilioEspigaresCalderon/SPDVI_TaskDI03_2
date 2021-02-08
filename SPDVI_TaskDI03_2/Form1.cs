using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVI_TaskDI03_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void confirmChoiceButton_Click(object sender, EventArgs e)
        {
            var productModel = DataAccess.GetProductModel(int.Parse(productsTB.Text));
            MemoryStream ms = new MemoryStream(productModel.LargePhoto);
            Image largePhoto = Image.FromStream(ms);
            productImage.Image = largePhoto;
        }
    }
}
