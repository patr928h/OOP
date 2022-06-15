﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komposition
{
    class Supplier
    {
        #region Fields
        private int id;
        private string name;
        private ContactInfo contactInfo;
        private List<Product> products;
        #endregion


        #region Constructors
        public Supplier(int id, string name, ContactInfo contactInfo)
        {
            Id = id;
            Name = name;
            ContactInfo = contactInfo;
        } 
        public Supplier(int id, string name, ContactInfo contactInfo, List<Product> products): this(id, name, contactInfo)
        {
            Products = products;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public ContactInfo ContactInfo
        {
            get => contactInfo; set => contactInfo = value;
        }
        internal List<Product> Products { get => products; set => products = value; }
        #endregion

        #region Methods
        public bool? IsDanish()
        {
            if (contactInfo != null)
            {
                string mailTld = contactInfo.Mail.Split('.').Last();
                if (mailTld == ".dk")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return null;
        }
        public int GetNumberOfProducts()
        {
            return products.Count;
        }
        public bool ContainsProduct()
        {
            foreach (Product p in products)
            {
                if (p.Name == name)
                {
                    return true;
                }
            }
            return false; 
            #endregion
        }
    }
}
