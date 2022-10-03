using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testestes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //int Ov;
        double Ov;

        private void button1_Click(object sender, EventArgs e)
        {

            //int Iv = Convert.ToInt32(txtlv.Text);
            //int osh = Convert.ToInt32(txtOsh.Text);
            //int osl = Convert.ToInt32(txtOsl.Text);
            //int lsh = Convert.ToInt32(txtIsh.Text);
            //int lsl = Convert.ToInt32(txtIsl.Text);

            //Ov = ((osh - osl) * (Iv - lsl) / (lsh - lsl)) + osl;
            //txtOv.Text=Convert.ToString(Ov);
            double Iv = Convert.ToDouble(txtlv.Text);
            double osh = Convert.ToDouble(txtOsh.Text);
            double osl = Convert.ToDouble(txtOsl.Text);
            double lsh = Convert.ToDouble(txtIsh.Text);
            double lsl = Convert.ToDouble(txtIsl.Text);

            Ov = ((osh - osl) * (Iv - lsl) / (lsh - lsl)) + osl;
            
            txtOv.Text = Convert.ToString(Math.Round(Ov, 2));
            
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
