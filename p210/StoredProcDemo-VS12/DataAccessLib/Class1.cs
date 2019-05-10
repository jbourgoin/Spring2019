using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class NorthwindData
    {
        private const string connectString = @"Server=localhost\sqlexpress;Database=Northwind;Integrated Security=SSPI";

        private const string dbErrorMsg = "Database operation failed.  Please contact your system administrator.";
    
        // This method inserts a row into the Products table in the Northwind database
        // returns ProductID of the Product
        public static int AddProduct(string productName, int supplierID, int categoryID, int quantityPerUnit,
           float unitPrice, int unitsInStock, int unitsOnOrder, int reorderLevel, bool discontinued, string supplierProductID)
        {
            SqlCommand procCommand = new SqlCommand();   // instantiate the command object

            try
            {
                procCommand.Connection = new SqlConnection(connectString); //configure the connection

                // name of stored proc is the command text
                procCommand.CommandText = "InsertNewProduct"; // This is the name of the proc already sitting in the SQL system

                procCommand.CommandType = CommandType.StoredProcedure;  //set command type

                //Add parameters for each parm in the stored proc

                procCommand.Parameters.Add("@ProductName", System.Data.SqlDbType.NVarChar, 40);
                procCommand.Parameters["@ProductName"].Value = productName;
                procCommand.Parameters["@ProductName"].Direction = System.Data.ParameterDirection.Input;  //we never had this before!
                procCommand.Parameters["@ProductName"].IsNullable = false;
                
                //SupplierID parm
                procCommand.Parameters.Add("@SupplierID", System.Data.SqlDbType.Int);
                procCommand.Parameters["@SupplierID"].Value = supplierID;
                procCommand.Parameters["@SupplierID"].Direction = System.Data.ParameterDirection.Input;  //we never had this before!
                procCommand.Parameters["@SupplierID"].IsNullable = false;
              

                //CategoryID parm
                procCommand.Parameters.Add("@CategoryID", System.Data.SqlDbType.Int);
                procCommand.Parameters["@CategoryID"].Value = categoryID;
                procCommand.Parameters["@CategoryID"].Direction = System.Data.ParameterDirection.Input;  //we never had this before!
                procCommand.Parameters["@CategoryID"].IsNullable = false;
           
                //QuantityPerUnit parm
                procCommand.Parameters.Add("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 50);
                procCommand.Parameters["@QuantityPerUnit"].Value = quantityPerUnit;
                procCommand.Parameters["@QuantityPerUnit"].Direction = System.Data.ParameterDirection.Input;  //we never had this before!
                procCommand.Parameters["@QuantityPerUnit"].IsNullable = false;
         
                //UnitPrice parm
                procCommand.Parameters.Add("@UnitPrice", System.Data.SqlDbType.Float);
                procCommand.Parameters["@UnitPrice"].Value = unitPrice;
                procCommand.Parameters["@UnitPrice"].Direction = System.Data.ParameterDirection.Input;  //we never had this before!
                procCommand.Parameters["@UnitPrice"].IsNullable = false;
               
                //UnitinStock parm
                procCommand.Parameters.Add("@UnitsinStock", System.Data.SqlDbType.Int);
                procCommand.Parameters["@UnitsinStock"].Value = unitsInStock;
                procCommand.Parameters["@UnitsinStock"].Direction = System.Data.ParameterDirection.Input;  //we never had this before!
                procCommand.Parameters["@UnitsinStock"].IsNullable = false;
               
                //UnitsonOrder parm
                procCommand.Parameters.Add("@UnitsonOrder", System.Data.SqlDbType.Int);
                procCommand.Parameters["@UnitsonOrder"].Value = unitsOnOrder;
                procCommand.Parameters["@UnitsonOrder"].Direction = System.Data.ParameterDirection.Input;  //we never had this before!
                procCommand.Parameters["@UnitsonOrder"].IsNullable = false;
               
                //ReorderLevel parm
                procCommand.Parameters.Add("@ReorderLevel", System.Data.SqlDbType.Int);
                procCommand.Parameters["@ReorderLevel"].Value = reorderLevel;
                procCommand.Parameters["@ReorderLevel"].Direction = System.Data.ParameterDirection.Input;  //we never had this before!
                procCommand.Parameters["@ReorderLevel"].IsNullable = false;
                
                //Discontinued parm
                procCommand.Parameters.Add("@Discontinued", System.Data.SqlDbType.Bit);
                procCommand.Parameters["@Discontinued"].Value = discontinued;
                procCommand.Parameters["@Discontinued"].Direction = System.Data.ParameterDirection.Input;  //we never had this before!
                procCommand.Parameters["@Discontinued"].IsNullable = false;




                //OUTPUT Parm for OrderID
                SqlParameter tempParm = new SqlParameter();

                tempParm.ParameterName = "@ProductID";
                tempParm.SqlDbType = SqlDbType.Int;
                tempParm.Direction = ParameterDirection.Output;  // here is the parameter that comes back out
                procCommand.Parameters.Add(tempParm);

                procCommand.Connection.Open();  //open the connection

                procCommand.ExecuteNonQuery();  // its not an ExecuteScalar, as it is not SQL creating a sum or something to return
                // it is a parameter coming back that our proc will write

                //return the value of the stored proc Output parm
                return Convert.ToInt32(procCommand.Parameters["@ProductID"].Value);


            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException(dbErrorMsg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                procCommand.Connection.Close();
            }

        }

    }
}
