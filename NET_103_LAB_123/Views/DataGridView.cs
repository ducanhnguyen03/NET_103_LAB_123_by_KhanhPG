using NET_103_LAB_123.Controllers;
using NET_103_LAB_123.Models;
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
    public partial class DataGridView : Form
    {
        public Login login {get;set;}
        public DataGridView()
        {
            InitializeComponent();
        }
        string path = @"C:\Users\PC\Desktop\NET_103_LAB_123-master\NET_103_LAB_123\XMLFile1.xml";
        private void DataGridView_Load(object sender, EventArgs e)
        {
            dtg_show.ReadOnly = true;
        }

        private void cb_confirm_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_confirm.Checked)
            {
                SaveCars sc = new SaveCars();
                List<Cars> lstCar = sc.Read<Cars>(path);
               dtg_show.DataSource = lstCar;
              
            }
            else
            {
                dtg_show.DataSource = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.ShowDialog();
            if (cb_confirm.Checked)
            {
                SaveCars sc = new SaveCars();
                List<Cars> lstCar = sc.Read<Cars>(path);
                dtg_show.DataSource = lstCar;
            }
        }
    }
}
