using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Games a = new Doom(1,"Doom 1", 1993);
            Doom b = new Doom(2, "Doom Eternal",2016);
            a.Janr();
            b.Janr();
            a.Print();
            b.Print();
            a.Achivmend();
            b.Achivmend();
            Console.ReadLine();

        }
    }
    public abstract class Games
    {
        private int _id;
        private int _year;
        private string _name;
        public abstract string Raiting { get; }
        public Games(int id, string name,int year)
        {
            _id = id;
            _name = name;
            _year = year;
        }
        public abstract void Janr();
        public virtual void Print()
        {
            Console.WriteLine("Year realize" + _year);
        }
        public void Achivmend()
        {
            Console.WriteLine("game over");
        }

    }
    public class Doom : Games
    {
        public Doom(int id, string name,int year) : base(id, name, year) { }
        public override string Raiting => "10.0";
        public override void Janr()
        {
            Console.WriteLine("shooter");
        }
        public override void Print()
        {
            Console.WriteLine(" new method xdxd, дум вечен теперь без года");
        }
        public new void Achivmend()
        {
            Console.WriteLine("START NEW GAAAAAME DOOM FOREVER");
        }


    }
}
