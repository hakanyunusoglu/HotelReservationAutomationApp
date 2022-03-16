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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
         
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-0F7MQS8;Initial Catalog=HotelAutomation;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
                connect.Open();
                string sql = "select * from Admin where Username=@adminusername AND Password=@adminpassword";
                SqlParameter usrnm = new SqlParameter("adminusername",txtusername.text.Trim());
                SqlParameter psswrd = new SqlParameter("adminpassword", txtpassword.text.Trim());
                SqlCommand cmd = new SqlCommand(sql,connect);
                cmd.Parameters.Add(usrnm);
                cmd.Parameters.Add(psswrd);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MainPage mp = new MainPage();
                    mp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed Login. Try Again!");
                    txtusername.text = "Username";
                    txtpassword.text = "Password";
                }
            connect.Close();

        
    }
    }
}
