using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public static class NorthwindDataAccess
    {
        private const string connectString = @"Server = localhost\sqlexpress; Database= Northwind; Integrated Security=SSPI";
        
        // Generic error message for database issues
        private const string sqlErrorMessage = "Database operation failed.  Please contact your System Administrator";

        public static DataSet GetOrders()
        {
            SqlDataAdapter northwindAdapter = new SqlDataAdapter();
            northwindAdapter.SelectCommand = new SqlCommand();
            northwindAdapter.SelectCommand.Connection = new SqlConnection();
            try
            {
                northwindAdapter.SelectCommand.Connection.ConnectionString = connectString;
                northwindAdapter.SelectCommand.CommandText = "Select * from Orders order by OrderID";
                //instantiate the data set to be filled
                DataSet ordersDataSet = new DataSet("Orders DataSet");
                
                northwindAdapter.Fill(ordersDataSet, "Orders");  //and fill 1 table in the dataset

                northwindAdapter.SelectCommand.CommandText = "Select * from [Order Details] order by OrderID";
                northwindAdapter.Fill(ordersDataSet, "OrderDetails");  //and fill 2nd table in the dataset

                //set up the relationship between the 2 tables
                DataRelation ordersDataRelation = new DataRelation("UsefulRelation",
                    ordersDataSet.Tables["Orders"].Columns["OrderID"], // pkey
                    ordersDataSet.Tables["OrderDetails"].Columns["OrderID"]); //fkey
                ordersDataSet.Relations.Add(ordersDataRelation); // add it to the property which is a List<DataRelation>

                // now that we have a Constraint, how do we want to handle conflicts?
                // This next line has to come AFTER the Relations.Add, because that is when the ForeignKeyConstraint is auto-added
                ordersDataRelation.ChildKeyConstraint.DeleteRule = Rule.Cascade;
                //The change (update or delete) made to the parent record 
                // is made in related records in the child table as well.


                //ForeignKeyConstraint myForeignKeyConstraint = ordersDataRelation.ChildKeyConstraint;
                //myForeignKeyConstraint.DeleteRule = Rule.Cascade;

                //// Creating in-memory ForeignKeyConstraint  <<<< but won't let you have this with same relationshiop
                //// as an existing DataRelation
                //ForeignKeyConstraint custOrderFK = new ForeignKeyConstraint("custOrderFK",  // rela name, then parent, then child
                //    ordersDataSet.Tables["Orders"].Columns["OrderID"],
                //    ordersDataSet.Tables["OrderDetails"].Columns["OrderID"]);
                //// now that we have a Constraint, how do we want to handle conflicts?
                //custOrderFK.DeleteRule = Rule.None;
                //// .None = take no action, so system will not delete an order that has associated line
                //// item in the Order Details table.
                //ordersDataSet.Tables["OrderDetails"].Constraints.Add(custOrderFK);  // like adding params,



                return ordersDataSet;
            }
            catch (SqlException sqlEx)
            {
                //here you might write details to an error log
                
                //note that we do not throw the original SQLException object
                //because the object contains information (server, database, etc.)
                //that we do not want to reveal
                throw new ApplicationException(sqlErrorMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        

    }
}
