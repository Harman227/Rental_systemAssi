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
    public partial class rentalSection : Form
    {
        public int Cus_ID = 0;
        public int VId_ID = 0;
        String olDate = "";
        int RentID = 0;
        public rentalSection()
        {
            InitializeComponent();
            cus_id.Text = "" + Cus_ID;
            mov_id.Text = "" + VId_ID;
        }
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



        //  section opening other forms
        private void allvideosbtn_Click(object sender, EventArgs e)
        {
            adminMain obj = new adminMain();
            obj.Show();
        }
        //  section opening other forms
        private void customer_sec_Click(object sender, EventArgs e)
        {

            adminMain obj = new adminMain();
            obj.Show();
        }

        // user adding 
        private void user_add_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateNow = DateTime.Now;
                String today = "" + dateNow.ToShortDateString();
                String query = "insert into Rental(CID,VID,IssDate,RetDate)values(" + Convert.ToInt32(cus_id.Text) + "," +Convert.ToInt32(mov_id.Text )+ ",'" + today + "','issued')";
                DataQueryRecord(query);
                MessageBox.Show("Movie is Booked");
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check the data ");
            }
        }
        // when click on back btn
        private void RETURN_Click(object sender, EventArgs e)
        {

            /* try
             {*/
            DataTable dataTable = new DataTable();
            dataTable = DataQueryRecord("select * from Video");

            int cost = Convert.ToInt32(dataTable.Rows[0]["Cost"].ToString());

            DateTime current_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime prev_date = Convert.ToDateTime(olDate);


            //get the difference in the days fromat
            String Daysdiff = (current_date - prev_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));

            if (DaysInterval<1) {
                DaysInterval = 1;
            }
                int total = cost * Convert.ToInt32(DaysInterval);



                DateTime dateNow = DateTime.Now;
                String today = "" + dateNow;
                String query = "update  Rental set CID="+Convert.ToInt32(cus_id.Text)+",VID="+Convert.ToInt32(mov_id.Text)+",IssDate='"+olDate+"',RetDate='"+current_date.ToShortDateString()+"' where rentID="+RentID+"";
                DataQueryRecord(query);
                MessageBox.Show("Movie is Returned and bill is $"+total);


         /*   }
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check the data ");
            }*/
        }

        private void show_rent_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = DataQueryRecord("select * from Rental");
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cus_id.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mov_id.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            olDate = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
