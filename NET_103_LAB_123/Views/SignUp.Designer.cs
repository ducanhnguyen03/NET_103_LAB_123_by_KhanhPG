namespace NET_103_LAB_123.Views
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_namecar = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.cbb_producer = new System.Windows.Forms.ComboBox();
            this.btn_SignUpCar = new System.Windows.Forms.Button();
            this.tb_car = new System.Windows.Forms.TextBox();
            this.tb_pricee = new System.Windows.Forms.TextBox();
            this.tb_stocks = new System.Windows.Forms.TextBox();
            this.cb_producer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(106, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(106, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock";
            // 
            // tb_namecar
            // 
            this.tb_namecar.Location = new System.Drawing.Point(262, 76);
            this.tb_namecar.Name = "tb_namecar";
            this.tb_namecar.Size = new System.Drawing.Size(322, 23);
            this.tb_namecar.TabIndex = 4;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(262, 215);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(322, 23);
            this.tb_price.TabIndex = 5;
            // 
            // tb_stock
            // 
            this.tb_stock.Location = new System.Drawing.Point(262, 281);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(322, 23);
            this.tb_stock.TabIndex = 6;
            // 
            // cbb_producer
            // 
            this.cbb_producer.FormattingEnabled = true;
            this.cbb_producer.Items.AddRange(new object[] {
            "Toyota",
            "Huyndai",
            "Honda",
            "Mercedes",
            "BMW"});
            this.cbb_producer.Location = new System.Drawing.Point(262, 151);
            this.cbb_producer.Name = "cbb_producer";
            this.cbb_producer.Size = new System.Drawing.Size(322, 23);
            this.cbb_producer.TabIndex = 7;
            // 
            // btn_SignUpCar
            // 
            this.btn_SignUpCar.Location = new System.Drawing.Point(0, 0);
            this.btn_SignUpCar.Name = "btn_SignUpCar";
            this.btn_SignUpCar.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUpCar.TabIndex = 0;
            // 
            // tb_car
            // 
            this.tb_car.Location = new System.Drawing.Point(335, 95);
            this.tb_car.Name = "tb_car";
            this.tb_car.Size = new System.Drawing.Size(289, 23);
            this.tb_car.TabIndex = 0;
            this.tb_car.TextChanged += new System.EventHandler(this.tb_car_TextChanged);
            // 
            // tb_pricee
            // 
            this.tb_pricee.Location = new System.Drawing.Point(335, 259);
            this.tb_pricee.Name = "tb_pricee";
            this.tb_pricee.Size = new System.Drawing.Size(289, 23);
            this.tb_pricee.TabIndex = 1;
            this.tb_pricee.TextChanged += new System.EventHandler(this.tb_pricee_TextChanged);
            // 
            // tb_stocks
            // 
            this.tb_stocks.Location = new System.Drawing.Point(335, 342);
            this.tb_stocks.Name = "tb_stocks";
            this.tb_stocks.Size = new System.Drawing.Size(289, 23);
            this.tb_stocks.TabIndex = 2;
            this.tb_stocks.TextChanged += new System.EventHandler(this.tb_stocks_TextChanged);
            // 
            // cb_producer
            // 
            this.cb_producer.FormattingEnabled = true;
            this.cb_producer.Items.AddRange(new object[] {
            "Toyota",
            "Huyndai",
            "Honda",
            "Mercedes",
            "BMW"});
            this.cb_producer.Location = new System.Drawing.Point(335, 179);
            this.cb_producer.Name = "cb_producer";
            this.cb_producer.Size = new System.Drawing.Size(289, 23);
            this.cb_producer.TabIndex = 3;
            this.cb_producer.SelectedIndexChanged += new System.EventHandler(this.cb_producer_SelectedIndexChanged);
            this.cb_producer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_producer_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(189, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name Car";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(189, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Producer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(189, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(189, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stock";
            // 
            // btn_signup
            // 
            this.btn_signup.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_signup.Location = new System.Drawing.Point(335, 419);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(289, 70);
            this.btn_signup.TabIndex = 8;
            this.btn_signup.Text = "Sign Up Car";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(338, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 42);
            this.label9.TabIndex = 9;
            this.label9.Text = "Duk Ank AUTO";
            // 
            // SignUp
            // 
            this.ClientSize = new System.Drawing.Size(919, 543);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_producer);
            this.Controls.Add(this.tb_stocks);
            this.Controls.Add(this.tb_pricee);
            this.Controls.Add(this.tb_car);
            this.Name = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.DpiChanged += new System.Windows.Forms.DpiChangedEventHandler(this.SignUp_DpiChanged);
            this.StyleChanged += new System.EventHandler(this.SignUp_StyleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_namecar;
        private TextBox tb_price;
        private TextBox tb_stock;
        private ComboBox cbb_producer;
        private Button btn_SignUpCar;
        private TextBox tb_car;
        private TextBox tb_pricee;
        private TextBox tb_stocks;
        private ComboBox cb_producer;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btn_signup;
        private Label label9;
    }
}