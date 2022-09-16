using System;
public class Quiz {
        public string Name1;
        public string Name2;
        public string Address;
        public double Number;
        public string Name3;
        public long Number2;
}
class Program {
    static void Main(string[] args)
    {
            Quiz q1= new Quiz();
            Console.Write("Please input University Name :");
            q1.Name1 = Console.ReadLine();
            Console.Write("Please input Library Name : ");
            q1.Name2 = Console.ReadLine();
            Console.Write("Please input Address : ");
            q1.Address = Console.ReadLine();
            Console.Write("Please input Phone Number : ");
            q1.Number = double.Parse(Console.ReadLine());
            Console.Write("Please input Name-Last Name : ");
            q1.Name3 = Console.ReadLine();
            Console.Write("Please input ID Card Code : ");
            q1.Number2 = long.Parse(Console.ReadLine());

            Console.WriteLine("University Name : " + q1.Name1);
            Console.WriteLine("Library Name : " + q1.Name2);
            Console.WriteLine("Address : " + q1.Address);
            Console.WriteLine("Phone Number : " + q1.Number);
            Console.WriteLine("Name-Last Name : " + q1.Name3);
            Console.WriteLine("ID Card Code : " + q1.Number2);
    }
}