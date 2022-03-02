using System;
using Microsoft.Data.SqlClient;
using CommonLayer.Models;
namespace DataLayer
{
    public class DbConnection
    {
        public SqlConnection Cnn;
        public DbConnection()
        {
            Cnn = new SqlConnection(Connection.ConnectionStr);
        }
    }
}
