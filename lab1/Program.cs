using System;

namespace lab1
{
    public class SV
    {
        public int ID, Age;
        public string Name;
        public SV() { }
        public SV(int id, string name,int age )
        {
            ID = id;
            Name = name;
            Age = age;
        }
        public void invs() 
        {
            Console.WriteLine("ID = {0} , Name = {1} va Age = {2} ", ID , Name , Age);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            SV h1 = new SV(1, "nhan" , 20);
            SV h2 = new SV(2, "minh", 20);
            SV h3 = new SV(3, "khoa", 22);
            h1.invs();
            h2.invs();
            h3.invs();
            Console.WriteLine("hello ");

        }
    }
}
