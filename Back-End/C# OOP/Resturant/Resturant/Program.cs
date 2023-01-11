using Resturant.Classes;
using System;
using System.Collections.Generic;
using cw = System.Console;

namespace Resturant
{
    enum MenuOptions
    {
        Koshary = 1,
        Pizza,
        Crepe
    }

    enum LoginOptions
    {
        Manger = 1,
        Cashier,
        Customer
    }
    enum MangerOptions
    {

        AddEmployee = 1,
        RemoveEmployee,
        PrintAllEmployee,
        AddNewMenu,
        AddNewItemToMenu,
        RemoveItemfomeMenu,
        PrintAllMenu,
        PrintAllItemInMenu,
        exit

    }
    enum CashierOptions
    {
        NewOrder = 1,
        CancelLastOrder,
        PrintBill,
        logout
    }
    enum AddEmpolyeeOptions
    {
        AddCashier = 1,
    }

    partial class main
    {
        public static void start()
        {
            #region Bill List
            var BillList = new List<Bill>();
            #endregion

            #region Customers List
            var customersList = new List<Customer>();
            #endregion

            #region Created Menus
            var menusList = new MenuList();
            menusList.addMenu(ResaurantSystem.CrepeMenu());
            menusList.addMenu(ResaurantSystem.KosharyMenu());
            menusList.addMenu(ResaurantSystem.PizzaMenu());
            #endregion

            #region Created Cashiers
            var employeeList = new EmployeeList();

            Cashier cashier = new Cashier()
            {
                Address = new Address
                {
                    Country = "Egypt",
                    City = "Luxor",
                    Street = "TV"
                },
                Name = "Ali",
                TypeJob = "Cashier",
                UserName = "ali123",
                Salary = 1200.0,
                Password = "123",
                SSN = "123456789"
            };

            employeeList.AddEmployee(cashier);

            Cashier cashier2 = new Cashier
            {
                TypeJob = "Cashier",
                Name = "Mahmoud",
                UserName = "Mahmoud123",
                Password = "123",
                Salary = 1200.0,
                SSN = "123456789",
                Address = new Address
                {
                    Country = "Egypt",
                    City = "Quna",
                    Street = "rt"
                }
            };


            employeeList.AddEmployee(cashier);
            #endregion



            do
            {
                Console.Clear();
                cw.WriteLine("\n\n[1] log in           [2] Create New Customer Account\n");
                cw.WriteLine("Press any number to Exit\n");
                cw.Write("Select your choice: ");
                try
                {
                    int choice = int.Parse(cw.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                ResaurantSystem.ShowLoginOptions();
                                try
                                {
                                    LoginOptions loginOptions = (LoginOptions)int.Parse(cw.ReadLine());
                                    switch (loginOptions)
                                    {
                                        case LoginOptions.Manger:
                                            ResaurantSystem.MangerLogin(ref employeeList, ref menusList);
                                            break;
                                        case LoginOptions.Cashier:
                                            ResaurantSystem.CashierLogin(ref employeeList, ref menusList, ref BillList);
                                            break;
                                        case LoginOptions.Customer:
                                            {
                                                ResaurantSystem.CustomerLogin(ref customersList, ref menusList);
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    cw.WriteLine(ex.Message);
                                }

                            }
                            break;
                        case 2:
                            {
                                Customer customer = ResaurantSystem.CreateCustomer();
                                cw.WriteLine($"\n{"".PadLeft(20)}HI {customer.Name}, Welcome in our Online Restaurant");
                                customersList.Add(customer);

                            }
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    cw.WriteLine(ex.Message);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                cw.Write("Do you want to Exit from program (y / n): ");
                Console.ForegroundColor = ConsoleColor.Gray;

            } while (checkYesNo());
        }
        static void Main(string[] args)
        {
            start();
        }
        public static bool checkYesNo()
        {
            bool ok = false;
            string str;
            bool ex = true;
            do
            {
                str = cw.ReadLine();
                if (str == "n" || str == "y")
                {
                    if (str == "y")
                    {
                        ok = false;
                        break;
                    }
                    else if (str == "n")
                    {
                        ok = true;
                        break;
                    }

                }
                else
                {
                    cw.Write("Please Enter (y / n):");
                    ex = false;
                }
            } while (!ex);
            return ok;
        }
    }


}



