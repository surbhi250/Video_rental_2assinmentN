using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_2assinment
{
   public class DataForwarding
    {


       // creating connection
        SqlConnection conntn;

        //from ssm write the user string
        String conStr = "Data Source=DESKTOP-HKD1BEO\\SQLEXPRESS;Initial Catalog=RentalAssignment;Integrated Security=True";

        // all CRUD based concept here
        SqlCommand dbcmd;

        //  reading data from database
        SqlDataReader DReader;


        //method used to execute query which doent return any thing only modifit the database
        public void CmdQuery(String query)
        {
            conntn = new SqlConnection(conStr);
            conntn.Open();
            dbcmd = new SqlCommand(query, conntn);
            dbcmd.ExecuteNonQuery();
            conntn.Close();
        }

        // for record searching
        public DataTable CmdRecord(String qry)
        {
            DataTable tbl = new DataTable();

            conntn = new SqlConnection(conStr);

            conntn.Open();

            dbcmd = new SqlCommand(qry, conntn);

            DReader = dbcmd.ExecuteReader();

            tbl.Load(DReader);

            conntn.Close();

            return tbl;
        }
    }
}
