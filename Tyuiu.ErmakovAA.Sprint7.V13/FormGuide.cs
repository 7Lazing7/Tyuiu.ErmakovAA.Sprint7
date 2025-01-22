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
    public partial class FormGuide : System.Windows.Forms.Form
    {
        public FormGuide()
        {
            InitializeComponent();
        }

        private void textBoxGuide_SBI_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}