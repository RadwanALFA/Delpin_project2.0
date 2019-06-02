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
        
        public static readonly DataBaseManager dbmanager = new DataBaseManager();
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
        public string[] FillMainCombo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<string>($"select NAME from MAIN").ToArray();
            }

        }
        public List<Customer> FillPrivateCustomersCombo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Customer>($"select * from CUSTOMER where CompName is NULL").ToList();
            }

        }
        internal void DeleteTransfer(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute($"DELETE FROM RESERVES WHERE ID = {id}");
            }
        }
        public List<Reserves> GetALLTransfers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Reserves>($"SELECT * FROM RESERVES").ToList();
            }
        }
        internal void CreateTransfer(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                 connection.Execute($"INSERT INTO RESERVES(FROM_ID , TO_ID, DATE) VALUES " +
                     $"(@FROM_ID, @TO_ID, @DATE);",param);
            }
        }
        internal void EditeTransfer(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute($"UPDATE RESERVES SET TO_ID = @TO_ID , DATE = @DATE WHERE ID = @ID",param);
            }
        }
        internal String[] GetAllAccrssories()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<String>($"select MODEL from ACCESSORIES").ToArray();
            }
        }
        public List<Customer> FillCompanyCustomersCombo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Customer>("select CompName from CUSTOMER where FNAME is NULL").ToList();
            }

        }
        public List<Catagory> GetAllCatagory(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Catagory>($"select * from CATAGORY WHERE MAIN_ID = {id}").ToList();
            }

        }
        public List<Product> GetAllProductByCatagory(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Product>($"select * from PRODUCT WHERE CATAGORY_ID = {id}").ToList();
            }
        }
        public int GetCatagoryID(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.QueryFirst<int>($"select CATAGORY_ID from CATAGORY WHERE NAME LIKE '{x}'");
            }
        }
        public int GetMainID(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.QueryFirst<int>($"select ID from MAIN WHERE NAME LIKE '{x}'");
            }
        }
        internal void UpdateBooking(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("updateBookingInfo",param,commandType: CommandType.StoredProcedure);
            }
        }
        public int GetAccessoryID(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.QueryFirst<int>($"select ID from ACCESSORIES WHERE MODEL LIKE '{x}'");
            }
        }
        public List<Product> GetAllProduct()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Product>($"select * from PRODUCT").ToList();
            }
        }
        public IEnumerable<dynamic> ViewAllBooking(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Booking>($"select * from BOOKING WHERE CPR_NUMM LIKE '{x}' ").ToList();
            }
        }
        public List<Booking> GetAllBooking()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Booking>($"SELECT * FROM BOOKING").ToList();
            }
        }
        public void CreatePrivateCustomer(DynamicParameters param)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("CreateOrUpdatePrivateCustomer", param, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateCompanyCustomer(DynamicParameters param)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("CreateCompanyCustomer", param, commandType: CommandType.StoredProcedure);
            }
        }
        public void DeleteCustomer(DynamicParameters param)
        {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
                {
                    connection.Execute("DeleteCustomerByID", param, commandType: CommandType.StoredProcedure);
                }
        }
        public void DeleteBooking(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("DeleteBookingById", param, commandType: CommandType.StoredProcedure);
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
        public List<Booking> ViewAllOrSearchBooking(String x)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", x);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Booking>("ViewAllOrSearchBooking",param,commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<Customer> GetCustomers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                List<Customer> res = connection.Query<Customer>("SELECT * FROM CUSTOMER").ToList<Customer>();
                return res;
            }
        }
        public int GetProductId(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.QueryFirst<int>($"SELECT ID FROM PRODUCT where NAME = '{x}'");
            }
        }
        public int GetCustomerId(String x)
        {
           using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
           {
               return connection.QueryFirst<int>($"SELECT ID FROM CUSTOMER WHERE CPR_NUMM" +
                   $" ='{x}'");
           }

        }
        public int GetCustomerId2(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.QueryFirst<int>($"SELECT ID FROM CUSTOMER WHERE CVR_NUMM LIKE '{x}'");
            }

        }
        public void CreateBooking2(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("CreateBooking", param, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreateBooking(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("CreateBooking2", param, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Booking> GetBookingbyResourceName(int x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {

                return connection.Query<Booking>($"SELECT * FROM BOOKING WHERE PRODUCT_ID ={x}").ToList();
            }
        }
        public List<Accessory> GetProductAccrssories(int main_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Accessory>($"SELECT * FROM ACCESSORIES where MAIN_ID = {main_id}").ToList();
            }
        }
        public List<Product> GetAllProductsByBranchId(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return  connection.Query<Product>($"select * from PRODUCT where BRANCH_ID = {id}").ToList();
            }
        }
    }
}
