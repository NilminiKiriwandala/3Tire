using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class RegistrationTable
    {
        public DataSet Read()
        {
            DataSet result = new DataSet();
            Connection.con.Open();
            SqlCommand cmd = new SqlCommand("dbo.GET_STUDNETS", Connection.con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(result);
            Connection.con.Close();
            return result;
        }

        public bool Save(object[] value)
        {
            Connection.con.Open();
            SqlCommand cmd = new SqlCommand("dbo.SAVE_STUDENT", Connection.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = value[0];
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = value[1];
            cmd.Parameters.Add("@dob", SqlDbType.Date).Value = value[2];
            cmd.Parameters.Add("@gpa", SqlDbType.Decimal).Value = value[3];
            cmd.Parameters.Add("@active", SqlDbType.Bit).Value = value[4];
            cmd.ExecuteNonQuery();
            Connection.con.Close();
            return true;
        }
    }
}
