using System;
using System.Xml.Serialization;


// Q new category over 65 Pensioner 25% reduction

abstract class Customer {
	protected string name;   
	protected int  age;  
	protected double  price;
	public Customer(String n, int a,double p){
		name =n;
		age =a;
		price=p;}
    
	public void  setNewPrice(double p) { price = p; }
	abstract public double readPrice();
}
//---------------------------------------------
class CustomerFactory
{
    public Customer getCustomer(String n, int a, double p)
    {
        if (a < 17)
            return new ChildCustomer(n, a,p);

        else return new RegularCustomer(n, a,p);
    }
}
//---------------------------------------------------
class ChildCustomer : Customer
{
    public ChildCustomer(String n, int a, double p) : base(n, a, p)
    {
    }
    override public double readPrice()
    {
        return price* 0.5;
    }
}
//-----------------------------------------------
class RegularCustomer : Customer
{
    public RegularCustomer(String n, int a, double p) : base(n, a,p)
    { }
    override public double readPrice()
    {
        return price;
    }
}
public class Ex1
{
    public static void Main()
    {
        double origPrice = 62.48;
        CustomerFactory cfactory = new CustomerFactory();
        Console.Write("Enter Name:");
        string name=Console.ReadLine();
        Console.Write("Enter Age:");
        string temp = Console.ReadLine();
        int age=Convert.ToInt32(temp);
        Customer c = cfactory.getCustomer(name,age,origPrice);
        int choice=1; double val=0;
        while (choice != 4)
        {
            Console.WriteLine("1: Enter New Price");
            Console.WriteLine("2: Read Price");
            Console.WriteLine("3: Enter new age");
            Console.WriteLine("4: Exit");
            Console.WriteLine("Enter Choice:");
            temp = Console.ReadLine();
            choice = Convert.ToInt32(temp);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Price");
                    temp = Console.ReadLine();
                    val = Convert.ToDouble(temp);
                    c.setNewPrice(val);
                    break;
                case 2:
                    double res = (double)c.readPrice();
                    Console.WriteLine("Price: " + res);
                    break;
                case 3:
                    double p = (double)c.readPrice();
                    if (a>65) { p= (p*100)/75;}
                    if (age < 17) p *= 2;
                    Console.Write("Enter Age:");
                    temp = Console.ReadLine();
                    age = Convert.ToInt32(temp);
                    c = cfactory.getCustomer(name, age, p);
                    break;
            }
        }
    }
}