using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_systemAss
{
    public partial class adminMain : Form
    {

        public int CusID = 0;
        public int VidID = 0;
        public String section = "";
        //create the instance of the SQL Connection class
        SqlConnection sqlConn;

        //write the connection sstring to assthe data form one for to the database 
        String conStr = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=RentalBookingTask;Integrated Security=True";

        //command are use to excute the command of isnert , delete , update
        SqlCommand sqlcmd;

        //data reader is used to read thedata from the database table 
        SqlDataReader DReader;


        //method used to execute query which doent return any thing only modifit the database
        public void CmdQuery(String query)
        {
            sqlConn = new SqlConnection(conStr);
            sqlConn.Open();
            sqlcmd = new SqlCommand(query, sqlConn);
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable DataQueryRecord(String qry)
        {
            DataTable tbl = new DataTable();

            sqlConn = new SqlConnection(conStr);

            sqlConn.Open();

            sqlcmd = new SqlCommand(qry, sqlConn);

            DReader = sqlcmd.ExecuteReader();

            tbl.Load(DReader);

            sqlConn.Close();

            return tbl;
        }



        public adminMain()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // inserting customers
        private void user_add_Click(object sender, EventArgs e)
        {
            try {
                String query = "insert into Customer(Name,Contact,Address)values('"+txt_name.Text+"','"+txt_cont_user.Text+"','"+txt_address.Text+"')";
                DataQueryRecord(query);
                MessageBox.Show("Customer Record is inserted");
                txt_address.Text = "";
                txt_cont_user.Text = "";
                txt_name.Text = "";
               }
            catch (Exception ex) {
                MessageBox.Show("Must need to check the data ");
            }
        }
        // for deleting user
        private void delete_user_Click(object sender, EventArgs e)
        {

            try
            {
                String query = "delete from Customer where ID="+CusID+"";
                DataQueryRecord(query);
                MessageBox.Show("Customer Record is removed ");
                CusID = 0;
                txt_address.Text = "";
                txt_cont_user.Text = "";
                txt_name.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check the data ");
            }
        }

        // edit user
        private void edit_user_Click(object sender, EventArgs e)
        {

            try
            {
                String query = "update Customer set Name='"+txt_name.Text+"',Contact='"+txt_cont_user.Text+"',Address='"+txt_address.Text+"' where ID="+CusID+"";
                DataQueryRecord(query);
                MessageBox.Show("Customer Record is Edited ");
                CusID = 0;
                txt_address.Text = "";
                txt_cont_user.Text = "";
                txt_name.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check the data ");
            }
        }

        // add video 
        private void add_video_Click(object sender, EventArgs e)
        {
            try {

                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(txt_video_year.Text);
                int Vcost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    Vcost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    Vcost = 5;
                }

                String cost = "" + Vcost;
                String query = "insert into Video(Name,Ratting,Year,Cost,Genre) values('"+txt_video_name.Text+"','"+txt_video_ratting.Text+"','"+txt_video_year.Text+"','"+cost+"','"+txt_genre.Text+"')";
                DataQueryRecord(query);
                MessageBox.Show("Video Record is Inserted");
                txt_video_name.Text = "";
                txt_video_ratting.Text = "";
                txt_video_year.Text = "";
                txt_genre.Text = "";
                cost = "";
            }
            catch (Exception) {
                    
            }
        }

        // deleting video
        private void video_del_Click(object sender, EventArgs e)
        {
            try
            {
                String cost = 12.ToString();
                String query = "delete from video where ID="+VidID+"";
                DataQueryRecord(query);
                MessageBox.Show("Video Record is removed");
                txt_video_name.Text = "";
                txt_video_ratting.Text = "";
                txt_video_year.Text = "";
                txt_genre.Text = "";
                cost = "";
                VidID = 0;
            }
            catch (Exception)
            {

            }
        }

        // edit video
        private void edit_video_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(txt_video_year.Text);
                int Vcost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    Vcost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    Vcost = 5;
                }

                String cost = "" + Vcost;
                String query = "udapte video set Name='"+txt_video_name.Text+"',Ratting='"+txt_video_ratting.Text+"',Year='"+txt_video_year.Text+"',Cost='"+cost+"',Genre='"+txt_genre.Text+ "'where ID=" + VidID + "";
                DataQueryRecord(query);
                MessageBox.Show("Video Record is removed");
                txt_video_name.Text = "";
                txt_video_ratting.Text = "";
                txt_video_year.Text = "";
                txt_genre.Text = "";
                cost = "";
                VidID = 0;
            }
            catch (Exception)
            {

            }

        }

        // all video showing
        private void allvideosbtn_Click(object sender, EventArgs e)
        {
            section = "video";
            DataTable dataTable = new DataTable();
            dataTable = DataQueryRecord("select * from Video");
            dataGridView1.DataSource = dataTable;
        }

        // showing customers
        private void customer_sec_Click(object sender, EventArgs e)
        {
            section = "customer";
            DataTable dataTable = new DataTable();
            dataTable = DataQueryRecord("select * from Customer");
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (section.Equals("customer")) {
                CusID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_cont_user.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            }
            if (section.Equals("video"))
            {
                VidID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txt_video_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_video_ratting.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_video_year.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_genre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


            }
        }

        private void returnBack_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            rentalSection obj = new rentalSection();
            obj.Show();
            obj.cus_id.Text = ""+CusID;
            obj.mov_id.Text= ""+VidID;
        }
    }
}
