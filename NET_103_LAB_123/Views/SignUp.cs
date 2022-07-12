using NET_103_LAB_123.Models;
using NET_103_LAB_123.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_103_LAB_123.Views
{
    [Serializable]
    public partial class SignUp : Form
    {
        string path = @"C:\Users\PC\Desktop\NET_103_LAB_123-master\NET_103_LAB_123\XMLFile1.xml";
        public SignUp()
        {
            InitializeComponent();
        }


        private void btn_SignUpCar_Click(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

            if(tb_car.Text.Trim() == "" || tb_pricee.Text.Trim() == "" || cb_producer.Text.Trim() == "" || tb_stocks.Text.Trim() == "")
            {
           
                MessageBox.Show("Fields cannot be left blank");
              
            }
            else
            {
                btn_signup.Enabled = true;
                Cars car = new Cars();
                List<Cars> lstCar = new List<Cars>();
                car.NameCar = tb_car.Text;
                car.Producer = cb_producer.Text;
                car.Price = Convert.ToInt32(tb_pricee.Text);
                car.Stocks = Convert.ToInt32(tb_stocks.Text);            
                lstCar.Add(car);
                SaveCars sc = new SaveCars();
                sc.Save<Cars>(path,car);
                MessageBox.Show("OK");
                this.Close();
            }


        }
        public bool CheckNumbers(string numbers)
        {
            return Regex.IsMatch(numbers,"[^ 0-9]");
        }
        public bool CheckWhiteSpace(string text)
        {
            return Regex.IsMatch(text, "\\s");
        }
        private void tb_pricee_TextChanged(object sender, EventArgs e)
        {
           
            if (CheckNumbers(tb_pricee.Text) || CheckWhiteSpace(tb_pricee.Text))
            {
               
                tb_pricee.Text = "";
                MessageBox.Show("Only input numbers");
                tb_stocks.Enabled = false;
            }
            else
            {
                tb_stocks.Enabled = true;
            }
            
          
        }

        private void tb_stocks_TextChanged(object sender, EventArgs e)
        {
       
            if (CheckNumbers(tb_stocks.Text) || CheckWhiteSpace(tb_stocks.Text))
            {
                tb_stocks.Text = "";
                MessageBox.Show("Only input numbers");
                btn_signup.Enabled = false;
            }
            else
            {
                btn_signup.Enabled= true;
            }
        }

        private void cb_producer_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void SignUp_StyleChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            tb_pricee.Enabled = false;
            tb_stocks.Enabled = false;
            btn_signup.Enabled = false;
        }

        private void SignUp_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }

        private void tb_car_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void cb_producer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_producer.Text != "")
            {
                tb_pricee.Enabled = true;
            }
            else
            {
                tb_pricee.Enabled = false;
            }
        }
    }
}
