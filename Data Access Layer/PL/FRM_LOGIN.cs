using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Data_Access_Layer.PL
{
    public partial class FRM_LOGIN : Form
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.CLS_LOGIN Login = new BL.CLS_LOGIN();
            DataTable Dt=new DataTable();
            Dt = Login.DT(txt_user.Text, txt_pass.Text);
            if(Dt.Rows.Count > 0)
            {
                PL.FRM_MAIN frm_main = new FRM_MAIN();
                frm_main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error in Login");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
