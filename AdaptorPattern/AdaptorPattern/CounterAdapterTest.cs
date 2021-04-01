using System;

public class Test
{
    public static void Main()
    {
        int option = 0;
        Counter c =new Counter(10);  //upper_limit 15
        while (option != 4)
        {
            Console.WriteLine("Choose Option\n-------------");
            Console.WriteLine("1.      Increment");
            Console.WriteLine("2.      Decrement");
            Console.WriteLine("3.      Read value");
            Console.WriteLine("4.      Exit");    
            option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                bool res=c.increment();
                if (res==false) Console.WriteLine("Cant be Incremented");
            }
            else if (option == 2)
            {
                bool res=c.decrement();
                if (res == false) Console.WriteLine("Cant be Decremented");
            }
            else if (option == 3)
            {
                int val = c.read_value();
                Console.WriteLine("Value = {0}", val);
            }
            else if (option != 4)
            {
                Console.WriteLine("Invalid Option");
            }
        }
    }
}