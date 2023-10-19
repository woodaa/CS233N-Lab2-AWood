using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Linq;

namespace MMABooksBusinessClasses

{
    public class Product
    {


        public Product() { }

        public Product(int pc, string description, int unitprice, int ohq)
        {

            ProductCode = pc;
            Description = description;
            UnitPrice = unitprice;
            OnHandQuantity = ohq;



        }

        private int ProductCode;
        private string Description;
        private int UnitPrice;
        private int OnHandQuantity;

        public int ProductCode
        {
            get
            {
                return pc;
            }
            set
            {
                if (value > 0)
                    pc = value;
                else
                    throw new ArgumentOutOfRangeException("Product code must be a positive integer");
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value.Trim().Length > 0 && value.Length <= 100)
                    description = value;
                else
                    throw new ArgumentOutOfRangeException("Item description must be more than 0 characters");
            }

        }
        public int UnitPrice
        {
            get
            {
                return unitprice;
            }

            set
            {
                if (value >= 0)
                    unitprice = value;
                else
                    throw new ArgumentOutOfRangeException("The price must be a number");
            }


        }

        public int OnHandQuanity
        {
            get
            {
                return ohq;
            }

            set
            {
                if (value > 0)
                    ohq = value;
                else
                    throw new ArgumentOutOfRangeException("The on hand quanity of the of a product should exist whether its zero or not.");
            }
        }

        

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
    
    

