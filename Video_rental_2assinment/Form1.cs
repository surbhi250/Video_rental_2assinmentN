using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_2assinment
{
    //Entry of Project
    public partial class Form1 : Form
    {
        QueryControl Task = new QueryControl();
        String display = "";

        public Form1()
        {
            InitializeComponent();
            grpVideo.Visible = false;
        }
        // to see all videos
        private void videos_Click(object sender, EventArgs e)
        {
            display = "movie";
            DataTable tbl = new DataTable();
            tbl = Task.data.CmdRecord("select * from VideoDetails");
            TableData.DataSource = tbl;
        }

        // to see rentals 
        private void Rentals_Click(object sender, EventArgs e)
        {
            display = "rental";
            DataTable tbl = new DataTable();
            tbl = Task.data.CmdRecord("select * from RentalDetails");
            TableData.DataSource = tbl;
        }

        // display all customers record
        private void customers_Click(object sender, EventArgs e)
        {
            display = "customer";
            DataTable tbl = new DataTable();
            tbl = Task.data.CmdRecord("select * from CustomerDetails");
            TableData.DataSource = tbl;
        }


        // to insert value in database
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (Task.InsertVideo(videoname.Text, Convert.ToInt32(year.Text), plot.Text, makers.Text, Convert.ToInt32(video_PRICE.Text), Convert.ToInt32(video_Copies.Text)))
            {
                MessageBox.Show("Video Record is saved ");
                rental_videoid.Text = "";
                videoname.Text = "";
                year.Text = "";
                plot.Text = "";
                makers.Text = "";
                video_Copies.Text="";
                video_PRICE.Text = "";
            }
            else {
                MessageBox.Show("check the Details once to proceed ");
            }
        }

        // to delete value in database
        private void delete_btn_Click(object sender, EventArgs e)
        {

            if (Task.DeleteVideo(Convert.ToInt32(rental_videoid.Text)))
            {
                MessageBox.Show("Video Record is removed ");
                rental_videoid.Text = "";
                videoname.Text = "";
                year.Text = "";
                plot.Text = "";
                makers.Text = "";
                video_Copies.Text = "";
                video_PRICE.Text = "";
            }
            else
            {
                MessageBox.Show("check the Details once to proceed ");
            }
        }
        // to update value in database

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (Task.UpdateVideo(Convert.ToInt32(rental_videoid.Text),videoname.Text, Convert.ToInt32(year.Text), plot.Text, makers.Text, Convert.ToInt32(video_PRICE.Text), Convert.ToInt32(video_Copies.Text)))
            {
                MessageBox.Show("Video Record is Edited Sucessfully ");
                rental_videoid.Text = "";
                videoname.Text = "";
                year.Text = "";
                plot.Text = "";
                makers.Text = "";
                video_Copies.Text = "";
                video_PRICE.Text = "";
            }
            else
            {
                MessageBox.Show("check the Details once to proceed ");
            }
        }

        // to issue movie and slecting data from database and inserting  in database table for rentals

        private void issue_mov_Click(object sender, EventArgs e)
        {
            if (Task.movieIssued(Convert.ToInt32(cs_id.Text), Convert.ToInt32(rental_videoid.Text), IssDate.Text, "Given"))
            {
                rental_videoid.Text = "";
                videoname.Text = "";
                year.Text = "";
                plot.Text = "";
                makers.Text = "";
                video_Copies.Text = "";
                video_PRICE.Text = "";

                cs_id.Text = "";
                rental_videoid.Text = "";
                cs_name.Text = "";
                cs_age.Text = "";
                cs_mob.Text = "";
                cs_country.Text = "";
                cs_id.Text = "";

                MessageBox.Show("Thnaks for the booking ");
            }
            else {
                MessageBox.Show("must need to select video and Cusotmer to issue");
            }
        }
        // to delete value in database
        private void delete_mov_Click(object sender, EventArgs e)
        {
            if (Task.DeleteIssued(Convert.ToInt32(lblRentalID.Text)))
            {
                rental_videoid.Text = "";
                videoname.Text = "";
                year.Text = "";
                plot.Text = "";
                makers.Text = "";
                video_Copies.Text = "";
                video_PRICE.Text = "";

                cs_id.Text = "";
                rental_videoid.Text = "";
                cs_name.Text = "";
                cs_age.Text = "";
                cs_mob.Text = "";
                cs_country.Text = "";
                cs_id.Text = "";
                MessageBox.Show("Issued Video is deleted ");
            }
            else
            {
                MessageBox.Show("must need to select video and Cusotmer to issue");
            }
        }

        // firslt sql query is taking data from database and then inserting in database
        private void return_mov_Click(object sender, EventArgs e)
        {
            if (Task.movieReturn(Convert.ToInt32(lblRentalID.Text), Convert.ToInt32(cs_id.Text), Convert.ToInt32(rental_videoid.Text), IssDate.Text,return_mov.Text))
            {
                //get the price from the database to generate the bill  
                DataTable tbl = new DataTable();
                tbl = new DataTable();
                tbl = Task.data.CmdRecord("select * from VideoDetails where Vd_ID=" + Convert.ToInt32(rental_videoid.Text) + "");
                int Cost = Convert.ToInt32(tbl.Rows[0]["Charges"].ToString());

                //get the difference in the days 
                DateTime nowdate = DateTime.Now;

                //convert the old date from string to Date fromat
                DateTime oldDate = Convert.ToDateTime(IssDate.Text);


                //get the difference in the days fromat
                String Daysdiff = (nowdate - oldDate).TotalDays.ToString();


                // calculate the round off value 
                Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));


                int total = Cost * Convert.ToInt32(DaysInterval);




                rental_videoid.Text = "";
                videoname.Text = "";
                year.Text = "";
                plot.Text = "";
                makers.Text = "";
                video_Copies.Text = "";
                video_PRICE.Text = "";
                cs_id.Text = "";
                rental_videoid.Text = "";

                cs_name.Text = "";
                cs_age.Text = "";
                cs_mob.Text = "";
                cs_country.Text = "";
                cs_id.Text = "";
                MessageBox.Show("Thnaks for using  your bill is $"+total);
            }
            else
            {
                MessageBox.Show("must need to select video and Cusotmer to issue");
            }
        }

        // coverting formats
        private void year_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(year.Text);
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;
                }
                video_PRICE.Text = "" + cost;
            }
            catch (Exception ex)
            {

            }

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }


        // showing alertnative values
        private void label8_Click(object sender, EventArgs e)
        {
            grpVideo.Visible = true;
            grpCustomer.Visible = false;
        }

        // showing alertnative values 
        private void label9_Click(object sender, EventArgs e)
        {

            grpVideo.Visible = false;
            grpCustomer.Visible = true;
        }

        // to add record in customer table

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (Task.InsertCustomer(cs_name.Text, Convert.ToInt32(cs_age.Text), cs_mob.Text, cs_country.Text))
            {
                MessageBox.Show("Customer Record is saved Properly ");
                cs_name.Text = "";
                cs_age.Text = "";
                cs_mob.Text = "";
                cs_country.Text = "";
                cs_id.Text = "";
            }
            else {
                MessageBox.Show("Must need to fill details and verify once ");
            }
        }

        // to update record from database table

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {

            if (Task.UpdateCustomer(Convert.ToInt32(cs_id.Text),cs_name.Text, Convert.ToInt32(cs_age.Text), cs_mob.Text, cs_country.Text))
            {
                MessageBox.Show("Customer Record is Edit Properly ");
                cs_name.Text = "";
                cs_age.Text = "";
                cs_mob.Text = "";
                cs_country.Text = "";
                cs_id.Text = "";
            }
            else
            {
                MessageBox.Show("Must need to fill details and verify once ");
            }
        }

        // to delete customer data
        private void btnCustomerDel_Click(object sender, EventArgs e)
        {
            if (Task.DeleteCustomer(Convert.ToInt32(cs_id.Text), cs_name.Text, Convert.ToInt32(cs_age.Text), cs_mob.Text, cs_country.Text))
            {
                MessageBox.Show("Customer Record is removed ");
                cs_name.Text = "";
                cs_age.Text = "";
                cs_mob.Text = "";
                cs_country.Text = "";
                cs_id.Text = "";
            }
            else
            {
                MessageBox.Show("Must need to fill details and verify once ");
            }
        }

        private void TableData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (display.Equals("customer")) {
                cs_id.Text = TableData.CurrentRow.Cells[0].Value.ToString();
                cs_name.Text = TableData.CurrentRow.Cells[1].Value.ToString();
                cs_age.Text = TableData.CurrentRow.Cells[2].Value.ToString();
                cs_mob.Text = TableData.CurrentRow.Cells[3].Value.ToString();
                cs_country.Text = TableData.CurrentRow.Cells[4].Value.ToString();

                grpCustomer.Visible = true;
                grpVideo.Visible = false;

            } else if (display.Equals("movie")) {
                rental_videoid.Text = TableData.CurrentRow.Cells[0].Value.ToString();
                videoname.Text = TableData.CurrentRow.Cells[1].Value.ToString();
                year.Text = TableData.CurrentRow.Cells[2].Value.ToString();
                plot.Text = TableData.CurrentRow.Cells[3].Value.ToString();
                makers.Text = TableData.CurrentRow.Cells[4].Value.ToString();
                video_PRICE.Text = TableData.CurrentRow.Cells[5].Value.ToString();
                video_Copies.Text = TableData.CurrentRow.Cells[6].Value.ToString();

                grpCustomer.Visible = false;
                grpVideo.Visible = true;
            } else if (display.Equals("rental")) {
                lblRentalID.Text= TableData.CurrentRow.Cells[0].Value.ToString();
                cs_id.Text= TableData.CurrentRow.Cells[1].Value.ToString();
                rental_videoid.Text= TableData.CurrentRow.Cells[2].Value.ToString();
                IssDate.Text= TableData.CurrentRow.Cells[3].Value.ToString();



                grpCustomer.Visible = false;
                grpVideo.Visible = false;
            }
            display = "";
        }

        private void show_popcs_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            tblData =Task.data.CmdRecord("select * from CustomerDetails");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = Task.data.CmdRecord("select * from RentalDetails where Cs_ID='" + tblData.Rows[x]["Cs_ID"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Most Popular Customer Name is " + Title);

        }

        private void showpopmovie_Click(object sender, EventArgs e)
        {

            DataTable tblData = new DataTable();
            tblData = Task.data.CmdRecord("select * from MovieDetails");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = Task.data.CmdRecord("select * from RentalDetails where Mv_ID='" + tblData.Rows[x]["Vd_ID"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Most Popular Movie  Name is " + Title);
        }
    }
}
