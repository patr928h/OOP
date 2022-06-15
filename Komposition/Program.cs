using System;
using System.Collections.Generic;
namespace Komposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leverandøren har ingen kontaktoplysninger");
            ContactInfo c = new(32, "info@ølbutikken.dk", "30405060");
            ContactInfo c1 = new(64, "support@ølbutikken.dk", "20304050");
            ContactInfo c2 = new(63, "kontakt@ølbutikken.dk", "10203040");
            ContactInfo c3 = new(62, "salg@ølbutikken.dk", "40506070");
            ContactInfo c4 = new(61, "job@ølbutikken.dk", "27304050");
            ContactInfo c5 = new(60, "administration@ølbutikken.dk", "27405060");
            ContactInfo c6 = new(59, "butik@ølbutikken.dk", "2750607080");

            Product p = new(51, "Rødvin", 100);
            Product p1 = new(52, "Hvidvin", 100);
            Product p2 = new(53, "Øl", 50);

            List<Product> list = new List<Product>();

            list.Add(p);
            list.Add(p1);
            list.Add(p2);


            Supplier s = new(1, "Ølbutikken", c);
            Supplier s1 = new(2, "Ølbutikken", c1);
            Supplier s2 = new(3, "Ølbutikken", c2);
            Supplier s3 = new(4, "Ølbutikken", c3);
            Supplier s4 = new(5, "Ølbutikken", c4);
            Supplier s5 = new(6, "Ølbutikken", c5);
            Supplier s6 = new(7, "Ølbutikken", c6);

            Supplier s7 = new(8, "Ølbutikken", null, list);

            s.ContactInfo = c;
            s1.ContactInfo = c1;
            s2.ContactInfo = c2;
            s3.ContactInfo = c3;
            s4.ContactInfo = c4;
            s5.ContactInfo = c5;
            s6.ContactInfo = c6;

            


            bool? nationalityDanish = s.IsDanish();
            if (nationalityDanish == null)
            {
               
            }
            else
            {
                if (nationalityDanish == true)
                {
                    Console.WriteLine("Leverandøren er dansk");
                }
                else
                {
                    Console.WriteLine("Leverandøren er udenlandsk");
                }

               


                nationalityDanish = s.IsDanish();
                if (nationalityDanish == null)
                {
                    Console.WriteLine("Leverandøren har ingen kontaktoplysninger");
                }
                else
                {
                    if (nationalityDanish == true)
                    {
                        Console.WriteLine("Leverandøren er dansk");
                    }
                    else
                    {
                        Console.WriteLine("Leverandøren er udenlandsk");
                    }
                }

            }
            Console.WriteLine(p);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(s7.GetNumberOfProducts());
        }
    }
}
