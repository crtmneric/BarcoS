using BarcoS.Classes.Views.MainForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcoS.Classes.Beans
{
    public class SqlHelper : IDisposable
    {
        SqlConnection cn;
        public void Dispose()
        {
            if (cn != null)
            {
                cn.Dispose();
                cn = null;
            }
        }
        public SqlHelper(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }
        public bool IsConnection()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                return true;
            }
            catch(Exception ex)
            {
                frmLogin.Log.Error("Cannot connect to database", ex);
                return false;
            }
        }
    }
}
