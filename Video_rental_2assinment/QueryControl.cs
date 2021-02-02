using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_2assinment
{
   public class QueryControl
    {
        public DataForwarding data = new DataForwarding();

        // different functions for insertion , updation and deleting of data 
        public Boolean InsertCustomer(String Name,int Age,String Contact,String Country) {
            String insert = "insert into CustomerDetails(Name,Age,Contact,Country)values('"+Name+"',"+Age+",'"+Contact+"','"+Country+"')";
            data.CmdQuery(insert);
            return true;
        }

        // different functions for insertion , updation and deleting of data 

        public Boolean UpdateCustomer(int Cus_ID,String Name, int Age, String Contact, String Country)
        {
            String Update = "update CustomerDetails set Name='"+Name+"',Age="+Age+",Contact='"+Contact+"',Country='"+Country+"' where Cs_ID="+Cus_ID+"";
            data.CmdQuery(Update);
            return true;
        }

        // different functions for insertion , updation and deleting of data 

        public Boolean DeleteCustomer(int Cus_ID, String Name, int Age, String Contact, String Country)
        {
            String Update = "update CustomerDetails set Name='" + Name + "',Age=" + Age + ",Contact='" + Contact + "',Country='" + Country + "' where Cs_ID=" + Cus_ID + "";
            data.CmdQuery(Update);
            return true;
        }


        // different functions for insertion , updation and deleting of data 
        public Boolean InsertVideo(String Name,int Year, String Plot,String Maker,int Price,int Copies) {
            String Insert = "insert into VideoDetails(Name,Year,Plot,Makers,Charges,Copies)values('"+Name+"',"+Year+",'"+Plot+"','"+Maker+"',"+Price+","+Copies+")";
            data.CmdQuery(Insert);
            return true;
        }

        // different functions for insertion , updation and deleting of data 
        public Boolean UpdateVideo(int V_ID,String Name, int Year, String Plot, String Maker, int Price, int Copies)
        {
            String Update = "Update VideoDetails set Name='"+Name+"',Year="+Year+",Plot='"+Plot+"',Makers='"+Maker+"',Charges="+Price+",Copies="+Copies+" where Vd_ID="+V_ID+"";
            data.CmdQuery(Update);
            return true;
        }

        // different functions for insertion , updation and deleting of data 
        public Boolean DeleteVideo(int V_ID)
        {
            String delete = "delete from VideoDetails Vd_ID="+V_ID+"";
            data.CmdQuery(delete);
            return true;
        }

        // different functions for insertion , updation and deleting of data 
        public Boolean movieIssued(int cus_ID,int Mv_ID,String IssDate,String RetrnDate) {
            String insert = "insert into RentalDetails(Cs_ID,Mv_ID,BookDate,ReturnDate) values("+cus_ID+","+Mv_ID+",'"+IssDate+"','"+RetrnDate+"')" ;
            data.CmdQuery(insert);
            return   true;
        }

        // different functions for insertion , updation and deleting of data 

        public Boolean DeleteIssued(int rent_ID)
        {
            String delete = "delete from  RentalDetails where Rn_ID="+rent_ID+"";
            data.CmdQuery(delete);
            return true;
        }

        // different functions for insertion , updation and deleting of data 
        public Boolean movieReturn(int rent_ID,int cus_ID, int Mv_ID, String IssDate, String RetrnDate)
        {
            String Update = "update RentalDetails set Cs_ID="+cus_ID+",Mv_ID="+Mv_ID+",BookDate='"+IssDate+"',ReturnDate='"+RetrnDate+ "' where Rn_ID=" + rent_ID + ""; 
            data.CmdQuery(Update);
            return true;
        }

    }
}
