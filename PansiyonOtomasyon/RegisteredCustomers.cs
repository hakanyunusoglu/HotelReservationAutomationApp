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
    public partial class RegisteredCustomers : Form
    {
        public RegisteredCustomers()
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

        private void btnshowcustomers_Click(object sender, EventArgs e)
        {
            customerlist();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtidnumber.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtsurname.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtgender.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtphone.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtemail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtroomnumber.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtprice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            entrydatetime.Value = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[9].Text);
            enddatetime.Value = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[10].Text);
            txtisdeleted.Text = listView1.SelectedItems[0].SubItems[11].Text;
        }

        private void btndeletecustomers_Click(object sender, EventArgs e)
        {
                if (txtroomnumber.Text == "101")
              {
                int room101 = 101;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room101 set RoomNumber='"+room101+"'",connect);
                cmds.ExecuteNonQuery(); 
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "102")
            {
                int room102 = 102;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room102 set RoomNumber='" + room102 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "103")
            {
                int room103 = 103;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room103 set RoomNumber='" + room103 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "102")
            {
                int room104 = 104;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room104 set RoomNumber='" + room104 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "105")
            {
                int room105 = 105;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room105 set RoomNumber='" + room105 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "106")
            {
                int room106 = 106;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room106 set RoomNumber='" + room106 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "107")
            {
                int room107 = 107;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room107 set RoomNumber='" + room107 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "108")
            {
                int room108 = 108;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room108 set RoomNumber='" + room108 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "109")
            {
                int room109 = 109;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room109 set RoomNumber='" + room109 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "110")
            {
                int room110 = 110;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room110 set RoomNumber='" + room110 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "111")
            {
                int room111 = 111;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room111 set RoomNumber='" + room111 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "102")
            {
                int room112 = 112;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room112 set RoomNumber='" + room112 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "113")
            {
                int room113 = 113;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room113 set RoomNumber='" + room113 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "114")
            {
                int room114 = 114;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room114 set RoomNumber='" + room114 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
            else if (txtroomnumber.Text == "115")
            {
                int room115 = 115;
                string _isdeleted = "YES";
                connect.Open();
                SqlCommand cmds = new SqlCommand("update room115 set RoomNumber='" + room115 + "'", connect);
                cmds.ExecuteNonQuery();
                connect.Close();
                connect.Open();
                SqlCommand cmdsz = new SqlCommand("update AddCustomer set isDeleted='" + _isdeleted + "' where No='" + id + "'", connect);
                cmdsz.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Selected Customer Deleted!");
            }
                else
            {
                MessageBox.Show("Failed! Try Again!");
                
            }
            customerlist();

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
            txtisdeleted.Text = "isDeleted";
            entrydatetime.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
            enddatetime.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
        }

        private void btnupdatecustomers_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmdz = new SqlCommand("update AddCustomer set IDNumber='"+txtidnumber.Text+"',Name='"+txtname.Text+"',Surname='"+txtsurname.Text+"',Gender='"+txtgender.Text+"',Phone='"+txtphone.Text+"',Email='"+txtemail.Text+"',RoomNumber='"+txtroomnumber.Text+"',Price='"+Convert.ToInt32(txtprice.Text)+"',EntryDate='"+entrydatetime.Value.ToString("yyyy/MM/dd")+"',EndDate='"+enddatetime.Value.ToString("yyyy/MM/dd")+"' where No='"+id+"'",connect);
            cmdz.ExecuteNonQuery();
            connect.Close();
            customerlist();
        }

        private void btnsearchcustomers_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from AddCustomer where Name like '%"+txtsearchcustomer.Text+"%'", connect);
            SqlDataReader readcustomer = cmd.ExecuteReader();
            while (readcustomer.Read())
            {
                ListViewItem addcustomer = new ListViewItem();
                addcustomer.Text = readcustomer["No"].ToString();
                addcustomer.SubItems.Add(readcustomer["IDNumber"].ToString());
                addcustomer.SubItems.Add(readcustomer["Name"].ToString());
                addcustomer.SubItems.Add(readcustomer["Surname"].ToString());
                addcustomer.SubItems.Add(readcustomer["Gender"].ToString());
                addcustomer.SubItems.Add(readcustomer["Phone"].ToString());
                addcustomer.SubItems.Add(readcustomer["Email"].ToString());
                addcustomer.SubItems.Add(readcustomer["RoomNumber"].ToString());
                addcustomer.SubItems.Add(readcustomer["Price"].ToString());
                addcustomer.SubItems.Add(readcustomer["EntryDate"].ToString());
                addcustomer.SubItems.Add(readcustomer["EndDate"].ToString());
                addcustomer.SubItems.Add(readcustomer["isDeleted"].ToString());

                listView1.Items.Add(addcustomer);
            }
            connect.Close();

        }
        private void customerlist()
        {
            listView1.Items.Clear();
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from AddCustomer", connect);
            SqlDataReader readcustomer = cmd.ExecuteReader();
            while (readcustomer.Read())
            {
                ListViewItem addcustomer = new ListViewItem();
                addcustomer.Text = readcustomer["No"].ToString();
                addcustomer.SubItems.Add(readcustomer["IDNumber"].ToString());
                addcustomer.SubItems.Add(readcustomer["Name"].ToString());
                addcustomer.SubItems.Add(readcustomer["Surname"].ToString());
                addcustomer.SubItems.Add(readcustomer["Gender"].ToString());
                addcustomer.SubItems.Add(readcustomer["Phone"].ToString());
                addcustomer.SubItems.Add(readcustomer["Email"].ToString());
                addcustomer.SubItems.Add(readcustomer["RoomNumber"].ToString());
                addcustomer.SubItems.Add(readcustomer["Price"].ToString());
                addcustomer.SubItems.Add(readcustomer["EntryDate"].ToString());
                addcustomer.SubItems.Add(readcustomer["EndDate"].ToString());
                addcustomer.SubItems.Add(readcustomer["isDeleted"].ToString());
                listView1.Items.Add(addcustomer);
            }
            connect.Close();

        }

        private void btnregistercustomer_Click(object sender, EventArgs e)
        {
            NewCustomer nw = new NewCustomer();
            nw.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }
    }
}
