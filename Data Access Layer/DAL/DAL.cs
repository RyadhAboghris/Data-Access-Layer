using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data_Access_Layer.DAL
{
    
     class DAL
    {
        SqlConnection con;


        public DAL()
        {
            con =new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ryadh\Desktop\Projects\U\Data Access Layer\Data Access Layer\DBSTUDENT.mdf"";Integrated Security=True");

        }
        // open connection
        public void open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open(); 
            }
        }
        // close connection
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        // Method to read data
        public DataTable Read(String Store, SqlParameter[] pr)
        {
            SqlCommand cmd =new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Store; 
            
            if(pr != null)
            {
               
                    cmd.Parameters.AddRange(pr);
                MessageBox.Show("okok");


            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }
        //void for insert,delete,edit
        public void Excute(string Store, SqlParameter[] pr)
        {
            SqlCommand cmd= new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType= CommandType.StoredProcedure;   
            cmd.CommandText= Store;
            if(pr!= null)
            {
                cmd.Parameters.AddRange(pr);
            }
            cmd.ExecuteNonQuery();
        }
    }
}
