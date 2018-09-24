using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadData
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.ReadLine();

            SortingHat sortingHat = new SortingHat();

            string[] TheBaseData = System.IO.File.ReadAllLines(@"C:\workspace\writeLine.txt");
            //string[] TheBaseData = System.IO.File.ReadAllLines(@"E:\Columbia\Senior\Algorithms\writeLine.txt"); //For Mike's Computer
            //string[] TheBaseData = System.IO.File.ReadAllLines(@"C:\Workspace\writeLine.txt"); //For Luke's Computer



            List<Tuple<int, Guid, double>> TheFinalData = new List<Tuple<int, Guid, double>>();

            List<string> TheFinalSortedData = new List<string>();

            int i = 0;
            foreach (string data in TheBaseData)
            {
                string[] values = TheBaseData[i].Split(',');



                TheFinalData.Add(new Tuple<int, Guid, double>(Int32.Parse(values[0]), Guid.Parse(values[1]), Double.Parse(values[2])));
                i++;
            }


            TheFinalData =  sortingHat.DoTheSorting(TheFinalData);



            
            foreach (Tuple<int, Guid, double> data in TheFinalData )
            {
                TheFinalSortedData.Add(data.Item1.ToString() + ", " + data.Item2.ToString() + ", " + data.Item3.ToString());
                
            }
            
            
            
            System.IO.File.WriteAllLines(@"C:\workspace\writeLine1.txt", TheFinalSortedData);
            //System.IO.File.WriteAllLines(@"E:\Columbia\Senior\Algorithms\writeLine.txt", TheFinalSortedData); //For Mike's Computer
            //System.IO.File.WriteAllLines(@"C:\Workspace\writeLine.txt", TheFinalSortedData); //For Mike's Computer



            sortingHat.DataReader(TheFinalSortedData);

            Console.ReadLine();
        }
    }
}
