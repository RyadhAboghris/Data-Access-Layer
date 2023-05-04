using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Data_Access_Layer.BL
{
    internal class CLS_LOGIN
    {
        DAL.DAL DAL = new Data_Access_Layer.DAL.DAL();
        public DataTable DT(string user,string password)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0]=new SqlParameter("User", user);
            pr[1]=new SqlParameter("Pass", password);
            DAL.open();
            return DAL.Read("Login", pr);
            DAL.close();
        }
    }
}
