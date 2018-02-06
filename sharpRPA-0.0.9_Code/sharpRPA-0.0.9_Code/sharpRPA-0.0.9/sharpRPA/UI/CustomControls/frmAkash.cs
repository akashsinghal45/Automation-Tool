using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharpRPA.UI.CustomControls
{
    public partial class frmAkash : Form
    {
      public static string strValue = "";
        public frmAkash()
        {
           
            InitializeComponent();

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void frmAkash_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
                strValue= textBox1.Text;

            this.Hide();

           
        }
        public string Data()
        {
            return strValue;
        }
    }
}
