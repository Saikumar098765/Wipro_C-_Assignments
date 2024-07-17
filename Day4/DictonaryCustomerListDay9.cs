using System;
using System.Collections.Generic;

public class CustomerList
{
    private Dictionary<string, List<string>> customers;

    public CustomerList()
    {
        customers = new Dictionary<string, List<string>>();
    }

    public void AddCustomer(string name, string plan)
    {
        if (customers.ContainsKey(plan))
        {
            customers[plan].Add(name);
        }
        else
        {
            customers[plan] = new List<string> { name };
        }
    }

    public void AddCustomerByPlan(string name, string plan)
    {
        
        if (customers.ContainsKey(plan))
        {
            
            customers[plan].Add(name);
        }
        else
        {
            
            customers[plan] = new List<string> { name };
        }
    }

    public void RemoveCustomer(string name)
    {
       
        foreach (var plan in customers)
        {
           
            if (plan.Value.Contains(name))
            {
                
                plan.Value.Remove(name);

                
                if (plan.Value.Count == 0)
                {
                    customers.Remove(plan.Key);
                }

                
                return;
            }
        }

        
        Console.WriteLine($"Customer {name} not found.");
    }

    public void PrintCustomers()
    {
        foreach (var plan in customers)
        {
            Console.WriteLine($"Plan: {plan.Key}");
            foreach (var customer in plan.Value)
            {
                Console.WriteLine($"- {customer}");
            }
            Console.WriteLine();
        }
    }
}

public class Program
{
    public static void Main()
    {
        CustomerList customerList = new CustomerList();

       
        customerList.AddCustomer("Sai", "Basic");
        customerList.AddCustomer("Kumar", "Premium");
        customerList.AddCustomer("Sai Kumar", "Gold");

        
        customerList.AddCustomerByPlan("Sai", "Enterprise");

      
        customerList.RemoveCustomer("Sai");

       
        customerList.PrintCustomers();
    }
}