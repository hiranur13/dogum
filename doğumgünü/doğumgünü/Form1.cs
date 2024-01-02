using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doğumgünü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dogumGunu=new DateTime(2024,01,28);
            DateTime bugunTarihi = DateTime.Today;
            TimeSpan kalanSure = dogumGunu-bugunTarihi;
            int kalanGun = kalanSure.Days;
            label1.Text=kalanGun.ToString();   
        }
    }
}
