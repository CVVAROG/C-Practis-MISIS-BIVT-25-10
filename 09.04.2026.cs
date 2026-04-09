using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public abstract class Purple
    {
        private string _input;
        public string Input => _input;
        protected static char[] _punk;


        protected Purple(string input) 
        { 
            _input = input;

        
        }
        public abstract void Review();
        public virtual void ChangeText(string input)
        {
            _input = input;
            Review();
        }

    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Task1 : Purple
    {
        private int _output;
        public int Output => _output;
        public Task1(string input) : base(input)
        {
            _output = default(int);
        }

        public override void Review()
        {
            _output = 134;
        }
        public override string ToString()
        {
            return "way cho za DOLMAAAAAA";
        }

    }
}



namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exsample ex = new Exsample(12);
            Exsample ex1 = new Exsample(12,"auf");
            Exsample ex2 = new Exsample(12,"EEEEEboIIIIIIII");
            Task1 e1 = new Task1("Zavodi sharmanku");
            Console.WriteLine(e1.Output);
            e1.Review();
            Console.WriteLine(e1.Output);
            Console.WriteLine(e1);

        }
    }
    public class Exsample
    {
        private int _number;
        private string _name;
        public Exsample(int number,string world = "skuka")
        {
            _number = number;
            _name = world;

        }
    }
    
}
