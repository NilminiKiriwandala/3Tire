using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public static class Connection
    {
        public static SqlConnection con = new SqlConnection("Data Source=TASP13SERVER;Initial Catalog=QUD;Integrated Security=True");
    }
}
