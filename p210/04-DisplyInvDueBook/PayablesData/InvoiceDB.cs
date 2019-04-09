using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PayablesData
{
    public static class InvoiceDB
    {
        public static List<Invoice> GetInvoicesDue()
        {
            List<Invoice> invoiceList = new List<Invoice>();

            SqlConnection connection = new SqlConnection("Data Source=SQLEXPRESS;Initial Catalog=Payables;" +
                 "Integrated Security=True");
            
            string selectStatement =
                "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, " +
                "PaymentTotal, CreditTotal, DueDate " +
                "FROM Invoices " +
                "WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0 " +   // only retrieve records that meet this criteria
                "ORDER BY DueDate";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())  // build one new object for each record in DB
                {
                    Invoice invoice = new Invoice();
                    invoice.InvoiceNumber = reader["InvoiceNumber"].ToString();
                    invoice.InvoiceDate = (DateTime)reader["InvoiceDate"];
                    invoice.InvoiceTotal = (decimal)reader["InvoiceTotal"];
                    invoice.PaymentTotal = (decimal)reader["PaymentTotal"];
                    invoice.CreditTotal = (decimal)reader["CreditTotal"];
                    invoice.DueDate = (DateTime)reader["DueDate"];
                    invoiceList.Add(invoice);   // add the new object to the List
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
    }
}
