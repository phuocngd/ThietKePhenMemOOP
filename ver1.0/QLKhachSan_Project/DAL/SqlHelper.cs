using System;
using System.Data;
using System.Data.SqlClient;

namespace DA
{
    public class SqlHelper
    {
        private static SqlHelper instance;

        private readonly string strconnect = "Data Source=JackieLeIV;Initial Catalog=MyQLKS2;Integrated Security=True";

        public static SqlHelper Instance
        {
            get { if (instance == null) instance = new SqlHelper(); return instance; }
            private set { instance = value; }
        }

        private SqlHelper() { }
       
        // Set command, and then execute the command with non query.
        public  int ExecuteNonQuery(string cmdtext, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(strconnect))
            {
                using (SqlCommand cmd = new SqlCommand(cmdtext, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        // Set command, and then execute the command and only return one value.
        public  object ExecuteScalar(string cmdtext, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(strconnect))
            {
                using (SqlCommand cmd = new SqlCommand(cmdtext, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        // Set  command, and then execute the command with query and return the reader.
        public  SqlDataReader ExecuteReader(string cmdtext, CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(strconnect);

            using (SqlCommand cmd = new SqlCommand(cmdtext, conn))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                conn.Open();
                // When using CommandBehavior.CloseConnection, the connection will be closed when the   
                // IDataReader is closed.  
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
        }
        public  DataTable ExecuteSelectQueryPar(string cmdtext, CommandType commandType, params SqlParameter[] parameters)
        {
            
            using (SqlConnection conn = new SqlConnection(strconnect))
            {
                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand(cmdtext, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdtext, conn);
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                    
                    return dt;
                }
            }
        }
    }
    
}
