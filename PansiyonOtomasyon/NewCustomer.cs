using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PansiyonOtomasyon
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
                     
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-0F7MQS8;Initial Catalog=HotelAutomation;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {           
            connect.Open();
            SqlCommand cmdroom101 = new SqlCommand("select * from room101", connect);
            SqlDataReader readroom101 = cmdroom101.ExecuteReader();

            while (readroom101.Read())
            {
                room101.ButtonText = readroom101["RoomNumber"].ToString();
            }
            connect.Close();
            if (room101.ButtonText == "1")
            {
                room101.IdleFillColor = Color.Red;
                room101.ActiveFillColor = Color.Red;
                room101.ActiveLineColor = Color.Red;
                room101.IdleLineColor = Color.Red;
                room101.Enabled = false;
                room101.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom102 = new SqlCommand("select * from room102", connect);
            SqlDataReader readroom102 = cmdroom102.ExecuteReader();

            while (readroom102.Read())
            {
                room102.ButtonText = readroom102["RoomNumber"].ToString();
            }

            connect.Close();
            if (room102.ButtonText == "2")
            {
                room102.IdleFillColor = Color.Red;
                room102.ActiveFillColor = Color.Red;
                room102.ActiveLineColor = Color.Red;
                room102.IdleLineColor = Color.Red;
                room102.Enabled = false;
                room102.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom103 = new SqlCommand("select * from room103", connect);
            SqlDataReader readroom103 = cmdroom103.ExecuteReader();

            while (readroom103.Read())
            {
                room103.ButtonText = readroom103["RoomNumber"].ToString();
            }

            connect.Close();
            if (room103.ButtonText == "3")
            {
                room103.IdleFillColor = Color.Red;
                room103.ActiveFillColor = Color.Red;
                room103.ActiveLineColor = Color.Red;
                room103.IdleLineColor = Color.Red;
                room103.Enabled = false;
                room103.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom104 = new SqlCommand("select * from room104", connect);
            SqlDataReader readroom104 = cmdroom104.ExecuteReader();

            while (readroom104.Read())
            {
                room104.ButtonText = readroom104["RoomNumber"].ToString();
            }

            connect.Close();
            if (room104.ButtonText == "4")
            {
                room104.IdleFillColor = Color.Red;
                room104.ActiveFillColor = Color.Red;
                room104.ActiveLineColor = Color.Red;
                room104.IdleLineColor = Color.Red;
                room104.Enabled = false;
                room104.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom105 = new SqlCommand("select * from room105", connect);
            SqlDataReader readroom105 = cmdroom105.ExecuteReader();

            while (readroom105.Read())
            {
                room105.ButtonText = readroom105["RoomNumber"].ToString();
            }

            connect.Close();
            if (room105.ButtonText == "5")
            {
                room105.IdleFillColor = Color.Red;
                room105.ActiveFillColor = Color.Red;
                room105.ActiveLineColor = Color.Red;
                room105.IdleLineColor = Color.Red;
                room105.Enabled = false;
                room105.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom106 = new SqlCommand("select * from room106", connect);
            SqlDataReader readroom106 = cmdroom106.ExecuteReader();

            while (readroom106.Read())
            {
                room106.ButtonText = readroom106["RoomNumber"].ToString();
            }

            connect.Close();
            if (room106.ButtonText == "6")
            {
                room106.IdleFillColor = Color.Red;
                room106.ActiveFillColor = Color.Red;
                room106.ActiveLineColor = Color.Red;
                room106.IdleLineColor = Color.Red;
                room106.Enabled = false;
                room106.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom107 = new SqlCommand("select * from room107", connect);
            SqlDataReader readroom107 = cmdroom107.ExecuteReader();

            while (readroom107.Read())
            {
                room107.ButtonText = readroom107["RoomNumber"].ToString();
            }

            connect.Close();
            if (room107.ButtonText == "7")
            {
                room107.IdleFillColor = Color.Red;
                room107.ActiveFillColor = Color.Red;
                room107.ActiveLineColor = Color.Red;
                room107.IdleLineColor = Color.Red;
                room107.Enabled = false;
                room107.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom108 = new SqlCommand("select * from room108", connect);
            SqlDataReader readroom108 = cmdroom108.ExecuteReader();

            while (readroom108.Read())
            {
                room108.ButtonText = readroom108["RoomNumber"].ToString();
            }

            connect.Close();
            if (room108.ButtonText == "8")
            {
                room108.IdleFillColor = Color.Red;
                room108.ActiveFillColor = Color.Red;
                room108.ActiveLineColor = Color.Red;
                room108.IdleLineColor = Color.Red;
                room108.Enabled = false;
                room108.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom109 = new SqlCommand("select * from room109", connect);
            SqlDataReader readroom109 = cmdroom109.ExecuteReader();

            while (readroom109.Read())
            {
                room109.ButtonText = readroom109["RoomNumber"].ToString();
            }

            connect.Close();
            if (room109.ButtonText == "9")
            {
                room109.IdleFillColor = Color.Red;
                room109.ActiveFillColor = Color.Red;
                room109.ActiveLineColor = Color.Red;
                room109.IdleLineColor = Color.Red;
                room109.Enabled = false;
                room109.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom110 = new SqlCommand("select * from room110", connect);
            SqlDataReader readroom110 = cmdroom110.ExecuteReader();

            while (readroom110.Read())
            {
                room110.ButtonText = readroom110["RoomNumber"].ToString();
            }

            connect.Close();
            if (room110.ButtonText == "10")
            {
                room110.IdleFillColor = Color.Red;
                room110.ActiveFillColor = Color.Red;
                room110.ActiveLineColor = Color.Red;
                room110.IdleLineColor = Color.Red;
                room110.Enabled = false;
                room110.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom111 = new SqlCommand("select * from room111", connect);
            SqlDataReader readroom111 = cmdroom111.ExecuteReader();

            while (readroom111.Read())
            {
                room111.ButtonText = readroom111["RoomNumber"].ToString();
            }

            connect.Close();
            if (room111.ButtonText == "11")
            {
                room111.IdleFillColor = Color.Red;
                room111.ActiveFillColor = Color.Red;
                room111.ActiveLineColor = Color.Red;
                room111.IdleLineColor = Color.Red;
                room111.Enabled = false;
                room111.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom112 = new SqlCommand("select * from room112", connect);
            SqlDataReader readroom112 = cmdroom112.ExecuteReader();

            while (readroom112.Read())
            {
                room112.ButtonText = readroom112["RoomNumber"].ToString();
            }

            connect.Close();
            if (room112.ButtonText == "12")
            {
                room112.IdleFillColor = Color.Red;
                room112.ActiveFillColor = Color.Red;
                room112.ActiveLineColor = Color.Red;
                room112.IdleLineColor = Color.Red;
                room112.Enabled = false;
                room112.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom113 = new SqlCommand("select * from room113", connect);
            SqlDataReader readroom113 = cmdroom113.ExecuteReader();

            while (readroom113.Read())
            {
                room113.ButtonText = readroom113["RoomNumber"].ToString();
            }

            connect.Close();
            if (room113.ButtonText == "13")
            {
                room113.IdleFillColor = Color.Red;
                room113.ActiveFillColor = Color.Red;
                room113.ActiveLineColor = Color.Red;
                room113.IdleLineColor = Color.Red;
                room113.Enabled = false;
                room113.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom114 = new SqlCommand("select * from room114", connect);
            SqlDataReader readroom114 = cmdroom114.ExecuteReader();

            while (readroom114.Read())
            {
                room114.ButtonText = readroom114["RoomNumber"].ToString();
            }

            connect.Close();
            if (room114.ButtonText == "14")
            {
                room114.IdleFillColor = Color.Red;
                room114.ActiveFillColor = Color.Red;
                room114.ActiveLineColor = Color.Red;
                room114.IdleLineColor = Color.Red;
                room114.Enabled = false;
                room114.ButtonText = " ";
            }
            connect.Open();
            SqlCommand cmdroom115 = new SqlCommand("select * from room115", connect);
            SqlDataReader readroom115 = cmdroom115.ExecuteReader();

            while (readroom115.Read())
            {
                room115.ButtonText = readroom115["RoomNumber"].ToString();
            }

            connect.Close();
            if (room115.ButtonText == "15")
            {
                room115.IdleFillColor = Color.Red;
                room115.ActiveFillColor = Color.Red;
                room115.ActiveLineColor = Color.Red;
                room115.IdleLineColor = Color.Red;
                room115.Enabled = false;
                room115.ButtonText = " ";
            }
        }
   
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
       
        private void enddatetime_onValueChanged(object sender, EventArgs e)
        {
            int price;
            DateTime smalldate = Convert.ToDateTime(entrydatetime.Value);
            DateTime bigdate = Convert.ToDateTime(enddatetime.Value);

            TimeSpan result;
            result = bigdate - smalldate;
            txttotalday.Text = Convert.ToInt32(result.TotalDays + 1).ToString();
            price = Convert.ToInt32(txttotalday.Text) * 100;
            txtprice.Text = price.ToString();
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidnumber.Text) || string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtsurname.Text) || string.IsNullOrEmpty(txtgender.Text) || string.IsNullOrEmpty(txtphone.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtroomnumber.Text) || string.IsNullOrEmpty(txtprice.Text))

            {
                MessageBox.Show("Please fill all information!");
            }
            else
            {
                connect.Open();
                try
            {
                    string isDeleted = "NO";
                SqlCommand cmd = new SqlCommand("insert into AddCustomer (IDNumber,Name,Surname,Gender,Phone,Email,RoomNumber,Price,EntryDate,EndDate,isDeleted) values('" + txtidnumber.Text + "','" + txtname.Text + "','" + txtsurname.Text + "','" + txtgender.Text + "','" + txtphone.Text + "','" + txtemail.Text + "','" + txtroomnumber.Text + "','" + Convert.ToInt32(txtprice.Text) + "','" + entrydatetime.Value.ToString("yyyy-MM-dd") + "','" + enddatetime.Value.ToString("yyyy-MM-dd") + "','"+isDeleted+"')", connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Register Successful!");
                
              }
            catch (Exception)
            {
                MessageBox.Show("Register Failed! Try Again!");
            }
                connect.Close();
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtidnumber.Text = "ID Number";
            txtname.Text = "Name";
            txtsurname.Text = "Surname";
            txtgender.Text = "Gender";
            txtphone.Text = "Phone";
            txtemail.Text = "E-Mail";
            txtroomnumber.Text = "Room Number";
            txtprice.Text = "Price";

                     
        }

        private void room101_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "101";
                int RoomNumber = 1;
                connect.Open();
                SqlCommand roomreg101 = new SqlCommand("insert into room101 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg101.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room102_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "102";
                int RoomNumber = 2;
                connect.Open();
                SqlCommand roomreg102 = new SqlCommand("insert into room102 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg102.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room103_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "103";
                int RoomNumber = 3;
                connect.Open();
                SqlCommand roomreg103 = new SqlCommand("insert into room103 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg103.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room104_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "104";
                int RoomNumber = 4;
                connect.Open();
                SqlCommand roomreg104 = new SqlCommand("insert into room104 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg104.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room105_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "105";
                int RoomNumber = 5;
                connect.Open();
                SqlCommand roomreg105 = new SqlCommand("insert into room105 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg105.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room106_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "106";
                int RoomNumber = 6;
                connect.Open();
                SqlCommand roomreg106 = new SqlCommand("insert into room106 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg106.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room107_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "107";
                int RoomNumber = 7;
                connect.Open();
                SqlCommand roomreg107 = new SqlCommand("insert into room107 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg107.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room108_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "108";
                int RoomNumber = 8;
                connect.Open();
                SqlCommand roomreg108 = new SqlCommand("insert into room108 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg108.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room109_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "109";
                int RoomNumber = 9;
                connect.Open();
                SqlCommand roomreg109 = new SqlCommand("insert into room109 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg109.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room110_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "110";
                int RoomNumber = 10;
                connect.Open();
                SqlCommand roomreg110 = new SqlCommand("insert into room110 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg110.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room111_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "111";
                int RoomNumber = 11;
                connect.Open();
                SqlCommand roomreg111 = new SqlCommand("insert into room111 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg111.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room112_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "112";
                int RoomNumber = 12;
                connect.Open();
                SqlCommand roomreg112 = new SqlCommand("insert into room112 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg112.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room113_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text=="ID Number" || txtname.Text=="Name" || txtsurname.Text=="Surname" || txtgender.Text=="Gender" || txtphone.Text=="Phone" || txtemail.Text=="E-Mail" || txtprice.Text=="Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            { 
            txtroomnumber.Text = "113";
            int RoomNumber = 13;
            connect.Open();
            SqlCommand roomreg113 = new SqlCommand("insert into room113 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
            roomreg113.ExecuteNonQuery();
            connect.Close();
            }
        }

        private void room114_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "114";
                int RoomNumber = 14;
                connect.Open();
                SqlCommand roomreg114 = new SqlCommand("insert into room114 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg114.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void room115_Click(object sender, EventArgs e)
        {
            if (txtidnumber.Text == "ID Number" || txtname.Text == "Name" || txtsurname.Text == "Surname" || txtgender.Text == "Gender" || txtphone.Text == "Phone" || txtemail.Text == "E-Mail" || txtprice.Text == "Price")
            {
                MessageBox.Show("Please Firstly fill all informations!");
            }
            else
            {
                txtroomnumber.Text = "115";
                int RoomNumber = 15;
                connect.Open();
                SqlCommand roomreg115 = new SqlCommand("insert into room115 (Name, Surname, RoomNumber) values ('" + txtname.Text + "','" + txtsurname.Text + "','" + RoomNumber + "')", connect);
                roomreg115.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }
    }
}
