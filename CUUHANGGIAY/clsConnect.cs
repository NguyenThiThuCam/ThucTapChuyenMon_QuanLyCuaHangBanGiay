using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CUUHANGGIAY
{
  public  class clsConnect
    {
        private static clsConnect instace;
        private string conStr = @"Data Source=CAMCAM\SQLEXPRESS;Initial Catalog=CUAHANGGIAY;Integrated Security=True";
        public static clsConnect Instance
        {
            get
            {
                if (instace == null)
                    instace = new clsConnect();
                return clsConnect.instace;
            }
            private set
            {
                clsConnect.instace = value;
            }
            
             
        }
        public DataTable exQuery(string query)
        {
            DataTable data = new DataTable();
            
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            conn.Close();
            return data;
        }




    }
}
