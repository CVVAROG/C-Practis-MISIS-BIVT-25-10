using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLinClass
{
    public class SixSeven
    {
        private int _six;
        private string _mem;
        
        private int[] _rewiev;
        public int[] Rewiev => _rewiev.ToArray();
        public int Six => _six;
        public string Mem => _mem;
        public SixSeven(int six,string seven)
        { 
            _six = six;
            _mem = seven;
            _rewiev = new int[0];
        }
        public void AddRewiev(int six)
        {
            Array.Resize(ref _rewiev, _rewiev.Length+1);
            _rewiev[_rewiev.Length - 1] = six;
        }
    }
    public class SixSevenDTO
    {
        public string SixSevenType {  get; set; }
        public int Six { get; set; }
        public string Mem { get; set; }
        public int[] Rewiev {  get; set; }

        public SixSevenDTO()
        {

        }
        
        public SixSevenDTO(SixSeven a)
        {
            SixSevenType = a.GetType().Name;
            Six = a.Six;
            Mem = a.Mem;
            Rewiev = a.Rewiev;
        }




    }    
    internal class Program
    {
        static void Main(string[] args)
        {
            SixSeven V1 = new SixSeven(6, "HIHIHAHA");
            SixSevenDTO V2 = new SixSevenDTO(V1);
            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = Path.Combine(folderpath, "SixSeven.xml");

            var serializer = new XmlSerializer(typeof(SixSevenDTO));
            //сериализация
            using(var writer = new StreamWriter(filepath))
            {
                serializer.Serialize(writer, V2);
            }
            V1.AddRewiev(3);
            V1.AddRewiev(1);
            V1.AddRewiev(4);
            V1.AddRewiev(2);
            V1.AddRewiev(5);
            SixSevenDTO DesiarV1;
            //десериализация
            using(var reader = new StreamReader(filepath))
            {
                DesiarV1 = (SixSevenDTO)serializer.Deserialize(reader);
            }

            SixSeven V11 = new SixSeven(DesiarV1.Six, DesiarV1.Mem);
            foreach (int six in V1.Rewiev)
            {
                V11.AddRewiev(six);

            }
            Console.WriteLine(string.Join(" ", V1.Rewiev));
            Console.WriteLine(String.Join(" ", V11.Rewiev));

            if (CompareTrue(V1, V11))
            {
                Console.WriteLine("apruved");
            }
            else
            {
                Console.WriteLine("Non apruved");
            }

            
        }
        public static bool CompareTrue(SixSeven V1, SixSeven V11)
        {
            if (V1.Six != V11.Six && V1.Mem != V11.Mem)  return false;
            if (V1.Rewiev.Length != V11.Rewiev.Length) return false;
            for (int i = 0;i< V1.Rewiev.Length; i++)
            {
                if (V1.Rewiev[i]!= V11.Rewiev[i]) return false;
            }
            


            return true; 
        }
    }
    

}
