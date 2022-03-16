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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-0F7MQS8;Initial Catalog=HotelAutomation;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
       
        private void Rooms_Load(object sender, EventArgs e)
        {
            connect.Open();
            string id101 = "1";
            SqlCommand cmdroom101 = new SqlCommand("select * from room101 where RoomNumber='"+id101+"'", connect);
            SqlDataReader readroom101 = cmdroom101.ExecuteReader();
            while (readroom101.Read())
            {
                room101.ButtonText = readroom101["Name"].ToString() + " " + readroom101["Surname"].ToString();
            }
            connect.Close();
            if (room101.ButtonText != "101") 
            {
                room101.IdleFillColor = Color.Red;
                room101.ActiveFillColor = Color.Red;
                room101.ActiveLineColor = Color.Red;
                room101.IdleLineColor = Color.Red;
                room101.ForeColor = Color.White;
                room101.ActiveForecolor = Color.White;
            }
            
            connect.Open();
            string id102 = "2";
            SqlCommand cmdroom102 = new SqlCommand("select * from room102 where RoomNumber='" + id102 + "'", connect);
            SqlDataReader readroom102 = cmdroom102.ExecuteReader();

            while (readroom102.Read())
            {
                room102.ButtonText = readroom102["Name"].ToString() + " " + readroom102["Surname"].ToString();
            }

            connect.Close();
            if (room102.ButtonText != "102")
            {
                room102.IdleFillColor = Color.Red;
                room102.ActiveFillColor = Color.Red;
                room102.ActiveLineColor = Color.Red;
                room102.IdleLineColor = Color.Red;
                room102.ForeColor = Color.White;
                room102.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id103 = "3";
            SqlCommand cmdroom103 = new SqlCommand("select * from room103 where RoomNumber='" + id103 + "'", connect);
            SqlDataReader readroom103 = cmdroom103.ExecuteReader();

            while (readroom103.Read())
            {
                room103.ButtonText = readroom103["Name"].ToString() + " " + readroom103["Surname"].ToString();
            }

            connect.Close();
            if (room103.ButtonText != "103")
            {
                room103.IdleFillColor = Color.Red;
                room103.ActiveFillColor = Color.Red;
                room103.ActiveLineColor = Color.Red;
                room103.IdleLineColor = Color.Red;
                room103.ForeColor = Color.White;
                room103.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id104 = "4";
            SqlCommand cmdroom104 = new SqlCommand("select * from room104 where RoomNumber='" + id104 + "'", connect);
            SqlDataReader readroom104 = cmdroom104.ExecuteReader();

            while (readroom104.Read())
            {
                room104.ButtonText = readroom104["Name"].ToString() + " " + readroom104["Surname"].ToString();
            }

            connect.Close();
            if (room104.ButtonText != "104")
            {
                room104.IdleFillColor = Color.Red;
                room104.ActiveFillColor = Color.Red;
                room104.ActiveLineColor = Color.Red;
                room104.IdleLineColor = Color.Red;
                room104.ForeColor = Color.White;
                room104.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id105 = "5";
            SqlCommand cmdroom105 = new SqlCommand("select * from room105 where RoomNumber='" + id105 + "'", connect);
            SqlDataReader readroom105 = cmdroom105.ExecuteReader();

            while (readroom105.Read())
            {
                room105.ButtonText = readroom105["Name"].ToString() + " " + readroom105["Surname"].ToString();
            }

            connect.Close();
            if (room105.ButtonText != "105")
            {
                room105.IdleFillColor = Color.Red;
                room105.ActiveFillColor = Color.Red;
                room105.ActiveLineColor = Color.Red;
                room105.IdleLineColor = Color.Red;
                room105.ForeColor = Color.White;
                room105.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id106 = "6";
            SqlCommand cmdroom106 = new SqlCommand("select * from room106 where RoomNumber='" + id106 + "'", connect);
            SqlDataReader readroom106 = cmdroom106.ExecuteReader();

            while (readroom106.Read())
            {
                room106.ButtonText = readroom106["Name"].ToString() + " " + readroom106["Surname"].ToString();
            }

            connect.Close();
            if (room106.ButtonText != "106")
            {
                room106.IdleFillColor = Color.Red;
                room106.ActiveFillColor = Color.Red;
                room106.ActiveLineColor = Color.Red;
                room106.IdleLineColor = Color.Red;
                room106.ForeColor = Color.White;
                room106.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id107 = "7";
            SqlCommand cmdroom107 = new SqlCommand("select * from room107 where RoomNumber='" + id107 + "'", connect);
            SqlDataReader readroom107 = cmdroom107.ExecuteReader();

            while (readroom107.Read())
            {
                room107.ButtonText = readroom107["Name"].ToString() + " " + readroom107["Surname"].ToString();
            }

            connect.Close();
            if (room107.ButtonText != "107")
            {
                room107.IdleFillColor = Color.Red;
                room107.ActiveFillColor = Color.Red;
                room107.ActiveLineColor = Color.Red;
                room107.IdleLineColor = Color.Red;
                room107.ForeColor = Color.White;
                room107.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id108 = "8";
            SqlCommand cmdroom108 = new SqlCommand("select * from room108 where RoomNumber='" + id108 + "'", connect);
            SqlDataReader readroom108 = cmdroom108.ExecuteReader();

            while (readroom108.Read())
            {
                room108.ButtonText = readroom108["Name"].ToString() + " " + readroom108["Surname"].ToString();
            }

            connect.Close();
            if (room108.ButtonText != "108")
            {
                room108.IdleFillColor = Color.Red;
                room108.ActiveFillColor = Color.Red;
                room108.ActiveLineColor = Color.Red;
                room108.IdleLineColor = Color.Red;
                room108.ForeColor = Color.White;
                room108.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id109 = "9";
            SqlCommand cmdroom109 = new SqlCommand("select * from room109 where RoomNumber='" + id109 + "'", connect);
            SqlDataReader readroom109 = cmdroom109.ExecuteReader();

            while (readroom109.Read())
            {
                room109.ButtonText = readroom109["Name"].ToString() + " " + readroom109["Surname"].ToString();
            }

            connect.Close();
            if (room109.ButtonText != "109")
            {
                room109.IdleFillColor = Color.Red;
                room109.ActiveFillColor = Color.Red;
                room109.ActiveLineColor = Color.Red;
                room109.IdleLineColor = Color.Red;
                room109.ForeColor = Color.White;
                room109.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id110 = "10";
            SqlCommand cmdroom110 = new SqlCommand("select * from room110 where RoomNumber='" + id110 + "'", connect);
            SqlDataReader readroom110 = cmdroom110.ExecuteReader();

            while (readroom110.Read())
            {
                room110.ButtonText = readroom110["Name"].ToString() + " " + readroom110["Surname"].ToString();
            }

            connect.Close();
            if (room110.ButtonText != "110")
            {
                room110.IdleFillColor = Color.Red;
                room110.ActiveFillColor = Color.Red;
                room110.ActiveLineColor = Color.Red;
                room110.IdleLineColor = Color.Red;
                room110.ForeColor = Color.White;
                room110.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id111 = "11";
            SqlCommand cmdroom111 = new SqlCommand("select * from room111 where RoomNumber='" + id111 + "'", connect);
            SqlDataReader readroom111 = cmdroom111.ExecuteReader();

            while (readroom111.Read())
            {
                room111.ButtonText = readroom111["Name"].ToString() + " " + readroom111["Surname"].ToString();
            }

            connect.Close();
            if (room111.ButtonText != "111")
            {
                room111.IdleFillColor = Color.Red;
                room111.ActiveFillColor = Color.Red;
                room111.ActiveLineColor = Color.Red;
                room111.IdleLineColor = Color.Red;
                room111.ForeColor = Color.White;
                room111.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id112 = "12";
            SqlCommand cmdroom112 = new SqlCommand("select * from room112 where RoomNumber='" + id112 + "'", connect);
            SqlDataReader readroom112 = cmdroom112.ExecuteReader();

            while (readroom112.Read())
            {
                room112.ButtonText = readroom112["Name"].ToString() + " " + readroom112["Surname"].ToString();
            }

            connect.Close();
            if (room112.ButtonText != "112")
            {
                room112.IdleFillColor = Color.Red;
                room112.ActiveFillColor = Color.Red;
                room112.ActiveLineColor = Color.Red;
                room112.IdleLineColor = Color.Red;
                room112.ForeColor = Color.White;
                room112.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id113 = "13";
            SqlCommand cmdroom113 = new SqlCommand("select * from room113 where RoomNumber='" + id113 + "'", connect);
            SqlDataReader readroom113 = cmdroom113.ExecuteReader();

            while (readroom113.Read())
            {
                room113.ButtonText = readroom113["Name"].ToString() + " " + readroom113["Surname"].ToString();
            }

            connect.Close();
            if (room113.ButtonText != "113")
            {
                room113.IdleFillColor = Color.Red;
                room113.ActiveFillColor = Color.Red;
                room113.ActiveLineColor = Color.Red;
                room113.IdleLineColor = Color.Red;
                room113.ForeColor = Color.White;
                room113.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id114 = "14";
            SqlCommand cmdroom114 = new SqlCommand("select * from room114 where RoomNumber='" + id114 + "'", connect);
            SqlDataReader readroom114 = cmdroom114.ExecuteReader();

            while (readroom114.Read())
            {
                room114.ButtonText = readroom114["Name"].ToString() + " " + readroom114["Surname"].ToString();
            }

            connect.Close();
            if (room114.ButtonText != "114")
            {
                room114.IdleFillColor = Color.Red;
                room114.ActiveFillColor = Color.Red;
                room114.ActiveLineColor = Color.Red;
                room114.IdleLineColor = Color.Red;
                room114.ForeColor = Color.White;
                room114.ActiveForecolor = Color.White;
            }
            connect.Open();
            string id115 = "15";
            SqlCommand cmdroom115 = new SqlCommand("select * from room115 where RoomNumber='" + id115 + "'", connect);
            SqlDataReader readroom115 = cmdroom115.ExecuteReader();

            while (readroom115.Read())
            {
                room115.ButtonText = readroom115["Name"].ToString() + " " + readroom115["Surname"].ToString();
            }

            connect.Close();
            if (room115.ButtonText != "115")
            {
                room115.IdleFillColor = Color.Red;
                room115.ActiveFillColor = Color.Red;
                room115.ActiveLineColor = Color.Red;
                room115.IdleLineColor = Color.Red;
                room115.ForeColor = Color.White;
                room115.ActiveForecolor = Color.White;
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
