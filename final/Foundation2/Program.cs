using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Console.WriteLine("Select order 1 or 2");
        string input = Console.ReadLine();
        if (input == "1"){
            string custName1 = "Bill Bob ";
            string street1 = "Wood St ";
            string city1 = "New York ";
            string state1 = "New York ";
            string country1 = "USA ";
            string product1 = "HeadPhones ";
            string product2 = "Laptop";
            string prodnum1 = "#143256 ";
            string prodnum2 = "#9458945895";
            int price1 = 20;
            int price2 = 220;
            int quantity1 = 1;
            int quantity2 = 1;
            int shipping;

            Product _product1 = new Product();
            _product1.SetProduct(product1, prodnum1, price1, quantity1);
            Product _product2 = new Product();
            _product2.SetProduct(product2, prodnum2, price2, quantity2);
            Console.WriteLine(_product1.GetProduct());
            Console.WriteLine(_product2.GetProduct());

            Address _address1 = new Address();
            _address1.SetAddress(street1, city1, state1, country1);
            string address1 = _address1.GetAddress();
            Console.WriteLine(address1);

            Customer _customer1 = new Customer();
            _customer1.SetCustomer(custName1, address1);
            Console.WriteLine(_customer1.GetCustomer());

            if (country1 == "USA "){
                shipping = 15;
            }
            else {
                shipping = 35;
            }

            int total1 = _product1.CalcPrice();
            int total2 = _product2.CalcPrice();
            int total = total1 + total2 + shipping;
            Console.WriteLine($"Your shipping costs ${shipping}");
            Console.Write($"Your total is: ${total}");
        }
        else if (input == "2"){
            string custName1 = "Jane Jan ";
            string street1 = "Poppy Way ";
            string city1 = "Price ";
            string state1 = "Utah ";
            string country1 = "USA ";
            string product1 = "Sunflower Seeds ";
            string product2 = "Potting Soil";
            string prodnum1 = "#938475 ";
            string prodnum2 = "#37864";
            int price1 = 7;
            int price2 = 40;
            int quantity1 = 1;
            int quantity2 = 1;
            int shipping;

            Product _product1 = new Product();
            _product1.SetProduct(product1, prodnum1, price1, quantity1);
            Product _product2 = new Product();
            _product2.SetProduct(product2, prodnum2, price2, quantity2);
            Console.WriteLine(_product1.GetProduct());
            Console.WriteLine(_product2.GetProduct());

            Address _address1 = new Address();
            _address1.SetAddress(street1, city1, state1, country1);
            string address1 = _address1.GetAddress();
            Console.WriteLine(address1);

            Customer _customer1 = new Customer();
            _customer1.SetCustomer(custName1, address1);
            Console.WriteLine(_customer1.GetCustomer());

            if (country1 == "USA "){
                shipping = 15;
            }
            else {
                shipping = 35;
            }

            int total1 = _product1.CalcPrice();
            int total2 = _product2.CalcPrice();
            int total = total1 + total2 + shipping;
            Console.WriteLine($"Your shipping costs ${shipping}");
            Console.Write($"Your total is: ${total}");
           
        }
    }
}