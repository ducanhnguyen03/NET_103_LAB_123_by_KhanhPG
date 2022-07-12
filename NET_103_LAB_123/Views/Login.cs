using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_103_LAB_123.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_user.Text == "ducanhdzz" && tb_pass.Text == "123")
            {
                DataGridView dtg = new DataGridView();
                dtg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hong be oi");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
