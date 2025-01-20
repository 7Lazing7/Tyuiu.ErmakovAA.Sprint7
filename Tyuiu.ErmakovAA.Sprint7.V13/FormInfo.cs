using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ErmakovAA.Sprint7.V13
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                ActiveControl = null;
            }));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxME_EAA_Click(object sender, EventArgs e)
        {

        }
    }
}