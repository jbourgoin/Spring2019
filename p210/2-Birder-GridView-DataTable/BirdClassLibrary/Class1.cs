using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdClassLibrary
{
    public static class ConnClass
    {
        public static SqlConnection GetConnection()
        {         
           
            return connection;
        }
    }

}
