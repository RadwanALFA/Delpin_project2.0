using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Delpin_project
{
    public class DataBaseManager
    {
        /// <summary>
        /// Checks if the Enterd passward is correct baised on the user name
        /// </summary>
        /// <param name="userNamer"></param>
        /// <param name="passward"></param>
        /// <returns></returns>
        public String GetPassword(string userNamer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<string>($"select PASSWARD from STAFF where USERNAME ='{userNamer}'").AsList()[0];
            }
        }

        public string[] FillCombo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<string>($"select ADDRESS from BRANCH").ToArray();
            }

        }

        public string[] FillCombo2()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<string>($"select NAME from MAIN").ToArray();
            }

        }

        public string[] FillCombo3(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<string>($"select NAME from CATAGORY WHERE MAIN_ID = {id}").ToArray();
            }

        }

        public void CreatePrivateCustomer( DynamicParameters param)
        {
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("CreateOrUpdatePrivateCustomer", param, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Customer> ViewAllOrSearchCustomers(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                List<Customer> res = connection.Query<Customer>("ViewAllOrSearch", param, commandType: CommandType.StoredProcedure).ToList<Customer>();
                return res;
            }
        }
    }
}
