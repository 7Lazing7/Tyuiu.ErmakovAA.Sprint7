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
    public partial class FormGeographyImage : Form
    {
        public FormGeographyImage()
        {
            InitializeComponent();
        }
        public void textBoxGuideImage_SBI_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void textBoxGuideImage_EAA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}