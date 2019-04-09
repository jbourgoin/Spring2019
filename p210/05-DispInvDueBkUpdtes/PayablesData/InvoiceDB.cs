using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace PayablesData
{
    public static class InvoiceDB
    {
        public static List<Invoice> GetInvoicesDue()
        {
            List<Invoice> invoiceList = new List<Invoice>();

            SqlConnection connection = new SqlConnection("Data Source=A254J-T006006;Initial Catalog=Payables;" +
             "Integrated Security=True");
           
            string selectStatement =
                "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, " +
                "PaymentTotal, CreditTotal, DueDate " +
                "FROM Invoices " +
                "WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0 " +
                "ORDER BY DueDate";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Invoice invoice = new Invoice();
                    invoice.InvoiceNumber = reader["InvoiceNumber"].ToString();
                    invoice.InvoiceDate = (DateTime)reader["InvoiceDate"];
                    invoice.InvoiceTotal = (decimal)reader["InvoiceTotal"];
                    invoice.PaymentTotal = (decimal)reader["PaymentTotal"];
                    invoice.CreditTotal = (decimal)reader["CreditTotal"];
                    invoice.DueDate = (DateTime)reader["DueDate"];
                    invoiceList.Add(invoice);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return invoiceList;
        }

        //=================================================================================
        public static void MakePayment(string pInvoiceNumber, string pPayment)
        {
            SqlConnection connection = new SqlConnection("Data Source=A254J-T006006;Initial Catalog=Payables;" +
             "Integrated Security=True");

            string selectStatement = "SELECT PaymentTotal FROM Invoices " +
               "WHERE InvoiceNumber = @InvoiceNumber ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar, 50);
            selectCommand.Parameters["@InvoiceNumber"].Value = pInvoiceNumber;
            decimal currBalance = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    currBalance = (decimal)reader["PaymentTotal"];
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            //==============================

             string updateStatement =
               "UPDATE Invoices SET  PaymentTotal = @PaymentTotal " +
               "WHERE InvoiceNumber = @InvoiceNumber AND PaymentTotal = " + currBalance;
            //   why                                 AND PaymentTotal = " + currBalance   ???

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.Add("@PaymentTotal", SqlDbType.Money);
            updateCommand.Parameters["@PaymentTotal"].Value = Convert.ToInt32(pPayment) + currBalance;

            updateCommand.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar, 50);
            updateCommand.Parameters["@InvoiceNumber"].Value = pInvoiceNumber;
            int recordsChanged = 0;
            try
            {
                connection.Open();
                recordsChanged = updateCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
                if (recordsChanged == 0)
                {
                    throw new ApplicationException("someone changed the data, try again!");
                }
            }
        }
    }
}
