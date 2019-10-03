using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using Dapper;
using LamdaShoppingList.Model;

namespace ORMBenchMark
{
  public  class DapperRepository
    {
        public List<Customer> GetUsersWithDapper()
        {
            using (IDbConnection db = new NpgsqlConnection(@"Host=localhost;Port=5432;Username=postgres;Password=1234;Database=testdb"))
            {
                return db.Query<Customer>
                ($"Select * from person").ToList();

            }
        }

        public Customer GetCustomer_Dapper()
        {
            using (IDbConnection db = new NpgsqlConnection(@"Host=localhost;Port=5432;Username=postgres;Password=1234;Database=testdb"))
            {
                return db.Query<Customer>
                ($"select * from person where name=Naveen").FirstOrDefault();

            }
        }
    }
}
