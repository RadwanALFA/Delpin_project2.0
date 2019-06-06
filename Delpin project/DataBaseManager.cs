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
        //access intity to the database Class
        public static readonly DataBaseManager dbmanager = new DataBaseManager();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userNamer"></param>
        /// <returns>returns the passward of a specific staff member baised on there username</returns>
        public String GetPassword(string userNamer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<string>($"select PASSWARD from STAFF where USERNAME ='{userNamer}'").AsList()[0];
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>the addresses of all the Branches</returns>
        public string[] FillCombo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<string>($"select ADDRESS from BRANCH").ToArray();
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>the names of all Main Catagories</returns>
        public string[] FillMainCombo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<string>($"select NAME from MAIN").ToArray();
            }

        }
        /// <summary>
        /// Deletes a specific resource transfer record baised on it's ID
        /// </summary>
        /// <param name="id"></param>
        internal void DeleteTransfer(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute($"DELETE FROM RESERVES WHERE ID = {id}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>a list of all resources transfer records</returns>
        public List<Reserves> GetALLTransfers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Reserves>($"SELECT * FROM RESERVES").ToList();
            }
        }
        /// <summary>
        /// Creats a resource transface record
        /// </summary>
        /// <param name="param"></param>
        internal void CreateTransfer(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                 connection.Execute($"INSERT INTO RESERVES(FROM_ID , TO_ID, DATE, product_id) VALUES " +
                     $"(@FROM_ID, @TO_ID, @DATE,@resource_id);",param);
            }
        }
        /// <summary>
        /// Update the information of a specific resource transfare record
        /// </summary>
        /// <param name="param"></param>
        internal void EditeTransfer(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute($"UPDATE RESERVES SET TO_ID = @TO_ID , DATE = @DATE WHERE ID = @ID",param);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>all the names of all accessories </returns>
        internal String[] GetAllAccrssories()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<String>($"select MODEL from ACCESSORIES").ToArray();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns> a list of all sub Catagories in a specific main catagory</returns>
        public List<Catagory> GetAllCatagory(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Catagory>($"select * from CATAGORY WHERE MAIN_ID = {id}").ToList();
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a list of all resources in a specific catagory</returns>
        public List<Product> GetAllProductByCatagory(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Product>($"select * from PRODUCT WHERE CATAGORY_ID = {id}").ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns>the ID of a Catagory baised on it's name</returns>
        public int GetCatagoryID(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.QueryFirst<int>($"select CATAGORY_ID from CATAGORY WHERE NAME LIKE '{x}'");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns>the ID of the Main Catagory baised n it's name</returns>
        public int GetMainID(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.QueryFirst<int>($"select ID from MAIN WHERE NAME LIKE '{x}'");
            }
        }
        /// <summary>
        /// Updates a booking's information baised on it's ID
        /// </summary>
        /// <param name="param"></param>
        internal void UpdateBooking(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("updateBookingInfo",param,commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns>the ID of an accessory baised on it's name</returns>
        public int GetAccessoryID(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.QueryFirst<int>($"select ID from ACCESSORIES WHERE MODEL LIKE '{x}'");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns> a list of all resources</returns>
        public List<Product> GetAllProduct()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Product>($"select * from PRODUCT").ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns>a list of bookings for a specific Private customer baised on there CPR number</returns>
        public IEnumerable<dynamic> ViewAllBooking(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Booking>($"select * from BOOKING WHERE CPR_NUMM LIKE '{x}' ").ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns> a list of all bookings</returns>
        public List<Booking> GetAllBooking()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Booking>($"SELECT * FROM BOOKING").ToList();
            }
        }
        /// <summary>
        /// Crate a new private Customer
        /// </summary>
        /// <param name="param"></param>
        public void CreatePrivateCustomer(DynamicParameters param)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("CreateOrUpdatePrivateCustomer", param, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Create a new Company Customer
        /// </summary>
        /// <param name="param"></param>
        public void CreateCompanyCustomer(DynamicParameters param)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("CreateCompanyCustomer", param, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Delete a Customer baised on there ID
        /// </summary>
        /// <param name="param"></param>
        public void DeleteCustomer(DynamicParameters param)
        {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
                {
                    connection.Execute("DeleteCustomerByID", param, commandType: CommandType.StoredProcedure);
                }
        }
        /// <summary>
        /// Delete a booking baised on it's ID
        /// </summary>
        /// <param name="param"></param>
        public void DeleteBooking(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("DeleteBookingById", param, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns>a list all customers or a specific customer baised of search text</returns>
        public List<Customer> ViewAllOrSearchCustomers(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                List<Customer> res = connection.Query<Customer>("ViewAllOrSearch", param, commandType: CommandType.StoredProcedure).ToList<Customer>();
                return res;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns>returns  a list of all the booking or bookings of a specific customer baised on search text </returns>
        public List<Booking> ViewAllOrSearchBooking(String x)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", x);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Booking>("ViewAllOrSearchBooking",param,commandType: CommandType.StoredProcedure).ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns> returns all CVR numbers of Company Customers</returns>
        internal List<string> GetAllCvrNumbers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<String>("SELECT CVR_NUMM FROM CUSTOMER").ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns> returns all CPR numbers of private Customers</returns>
        internal List<string> GetAllCprNumbers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<String>("SELECT CPR_NUMM FROM CUSTOMER").ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>a list of all the customers</returns>
        public List<Customer> GetCustomers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                List<Customer> res = connection.Query<Customer>("SELECT * FROM CUSTOMER").ToList<Customer>();
                return res;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns>returns the ID of a resource baised on it's name</returns>
        public int GetProductId(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.QueryFirst<int>($"SELECT ID FROM PRODUCT where NAME = '{x}'");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns>returns the id of a private customer baised on there CPR number</returns>
        public int GetCustomerId(String x)
        {
           using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
           {
               return connection.QueryFirst<int>($"SELECT ID FROM CUSTOMER WHERE CPR_NUMM" +
                   $" ='{x}'");
           }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns>returns the id of a company customer baised on there CVR number</returns>
        public int GetCustomerId2(String x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.QueryFirst<int>($"SELECT ID FROM CUSTOMER WHERE CVR_NUMM LIKE '{x}'");
            }

        }
        /// <summary>
        /// Create a booking for a resource.
        /// </summary>
        /// <param name="param"></param>
        public void CreateBooking(DynamicParameters param)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                connection.Execute("CreateBookingWithAccessory", param, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns>returns all the bookings for a pecific resource</returns>
        public List<Booking> GetBookingbyResourceId(int x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {

                return connection.Query<Booking>($"SELECT * FROM BOOKING WHERE PRODUCT_ID ={x}").ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="main_id"></param>
        /// <returns>returns all accessories for a specific main catagory</returns>
        public List<Accessory> GetProductAccrssories(int main_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<Accessory>($"SELECT * FROM ACCESSORIES where MAIN_ID = {main_id}").ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns> returns all the resources in a specific branch</returns>
        public List<Product> GetAllProductsByBranchId(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return  connection.Query<Product>($"select * from PRODUCT where BRANCH_ID = {id}").ToList();
            }
        }
        //returns all resources id's
        public List<int> GetAllProductsIDs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("test143")))
            {
                return connection.Query<int>($"select ID from PRODUCT").ToList();
            }
        }
    }
}
