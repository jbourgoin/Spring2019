using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayablesData
{
    public class Invoice
    {
        private string invoiceNumber;
        private DateTime invoiceDate;
        private decimal invoiceTotal;
        private decimal paymentTotal;
        private decimal creditTotal;
        private DateTime dueDate;

        public Invoice()
        {
        }

        public string InvoiceNumber
        {
            get
            {
                return invoiceNumber;
            }
            set
            {
                invoiceNumber = value;
            }
        }

        public DateTime InvoiceDate
        {
            get
            {
                return invoiceDate;
            }
            set
            {
                invoiceDate = value;
            }
        }

        public decimal InvoiceTotal
        {
            get
            {
                return invoiceTotal;
            }
            set
            {
                invoiceTotal = value;
            }
        }

        public decimal PaymentTotal
        {
            get
            {
                return paymentTotal;
            }
            set
            {
                paymentTotal = value;
            }
        }

        public decimal CreditTotal
        {
            get
            {
                return creditTotal;
            }
            set
            {
                creditTotal = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }

        public decimal BalanceDue()
        {
            return invoiceTotal - paymentTotal - creditTotal;
        }
    }
}
