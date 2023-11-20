using System.Net.Http.Headers;
using System.Xml.Linq;

namespace HW_1_week_2
{
    class Program
    {
        static void AddProduct(string product, decimal price, int quantity)
        {
            
            Console.WriteLine("Enter product name:");
            string productName = Console.ReadLine();
            Console.WriteLine(product);

            Console.WriteLine("Enter product price:");
            decimal productprice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(price);

            Console.WriteLine("Enter product quantity:");
            int productquantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(quantity);

            Console.WriteLine("Product added successfully!");

        }

        static void UpdateQuantity()
        {
            Console.WriteLine("Enter product name:");
            string ProductName = Console.ReadLine();
            Console.WriteLine();

            


        }

        //static void DisplayList(string list)
        //{
        //    Console.WriteLine("Product List:");

        //}

        //static void RecordSale( string product , int quantitysold)
        //{
        //    Console.WriteLine("Enter product name:");
        //    string ProductName = Console.ReadLine();
        //    Console.WriteLine(product);

        //    Console.WriteLine("Enter quantity sold:");
        //    int productquantity = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(productquantity);
        //}

        //static void ProductReport()
        //{

        //}

        //static void SalesReport()
        //{

        //}
        //static void Operation(int choice)
        //{

        //    if (choice == 1)
        //    {
        //        AddProduct();
        //    }
        //    else if (choice == 2)
        //    {
        //        UpdateQuantity();
        //    }
        //    else if (choice == 3)
        //    {
        //        DisplayList();
        //    }
        //    else if (choice == 4)
        //    {
        //        RecordSale();
        //    }
        //    else if (choice == 5)
        //    {
        //        ProductReport();
        //    }
        //    else if (choice == 6)
        //    {
        //        SalesReport();
        //    }
        //    else if (choice == 7)
        //    {
        //        Console.WriteLine("Thank you for using the Inventory Management System, admin"); ;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid choice. Please select a valid operation.");
        //    }




        static void Main()
          {

            Console.WriteLine("WELCOME TO THE INVENTORY MANAGEMENT SYSTEM \n");

            Console.WriteLine("Please enter your username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();

            if ( username == "admin" && password == "adminpass")
            {
                Console.WriteLine("Authentication successful! Welcome, admin!");
            }
            else
            {
                Console.WriteLine("Please Enter a CORRECT User Name or Password!!!");
            }


            Console.WriteLine("\nOptions:\n1. Add product\n2. Update quantity\n3. Display products\n4. Record sale\n5. Generate product report\n" +
                "6. Generate sales report\n7. Exit");
            Console.Write("Select (1-7): ");
            int userchoice = Convert.ToInt32(Console.ReadLine());


                //int choice = 0;

                //if (choice == 1)
                //{
                //    AddProduct();
                //}
                //else if (choice == 2)
                //{
                //    UpdateQuantity();
                //}
                //else if (choice == 3)
                //{
                //    DisplayList();
                //}
                //else if (choice == 4)
                //{
                //    RecordSale();
                //}
                //else if (choice == 5)
                //{
                //    ProductReport();
                //}
                //else if (choice == 6)
                //{
                //    SalesReport();
                //}
                //else if (choice == 7)
                //{
                //    Console.WriteLine("Thank you for using the Inventory Management System, admin"); ;
                //}
                //else
                //{
                //    Console.WriteLine("Invalid choice. Please select a valid operation.");
                //}




            }
    }
    
}
