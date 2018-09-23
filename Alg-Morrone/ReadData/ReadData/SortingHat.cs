using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadData
{
    
    class SortingHat
    {

        public List<Tuple<int, Guid, double>> DoTheSorting(List<Tuple<int, Guid, double>> ValuesToSort)
        {
            string InputValue = Console.ReadLine();



            Console.WriteLine("Press 1 for Insertion by ID");
            Console.WriteLine("Press 2 for Insertion by Double");
            Console.WriteLine("Press 3 for Bubble by ID");
            Console.WriteLine("Press 5 for Bubble by Double");

            Console.WriteLine("Else Try Again");

            switch (InputValue)
            {
                case "1":
                    InsertionbyId(ValuesToSort);
                    break;
                case "2":
                    InsertionByDouble(ValuesToSort);
                    break;
                case "3":
                    BubbleByID(ValuesToSort);
                    break;
                //case "4":
                //    BubbleByGuid(ValuesToSort);
                //    break;
                case "5":
                    BubbleByDouble(ValuesToSort);
                    break;
                default:
                    DoTheSorting(ValuesToSort);
                    break;
            }


            return ValuesToSort;

        }


        public void DataReader(List<string> DataToPrint)
        {
            Console.WriteLine("Write The Line Number that you would like to read");

            int InputValue = int.Parse(Console.ReadLine());

            if (InputValue > DataToPrint.Capacity - 1)
            {
                DataReader(DataToPrint);
            }


            Console.WriteLine(DataToPrint[InputValue]);



        }

        void InsertionbyId(List<Tuple<int, Guid, double>> Values) //http://anh.cs.luc.edu/170/notes/CSharpHtml/sorting.html //Works
        {
            Console.WriteLine(DateTime.Now);
            for (int i = 0; i < Values.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (Values[j - 1].Item1 > Values[j].Item1)
                    {
                        Tuple<int, Guid, double> temp;
                        temp = Values[j - 1];
                        Values[j - 1] = Values[j];
                        Values[j] = temp;
                    }
                }
            }
            Console.WriteLine(DateTime.Now);
        }

        void InsertionByDouble(List<Tuple<int, Guid, double>> Values) //works
        {
            Console.WriteLine(DateTime.Now);
            for (int i = 0; i < Values.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (Values[j - 1].Item3 > Values[j].Item3)
                    {
                        Tuple<int, Guid, double> temp;
                        temp = Values[j - 1];
                        Values[j - 1] = Values[j];
                        Values[j] = temp;
                    }
                }
            }

            Console.WriteLine(DateTime.Now);
        }


        void BubbleByID(List<Tuple<int, Guid, double>> Values)  //https://en.wikipedia.org/wiki/Bubble_sort
        {
            Console.WriteLine(DateTime.Now);
            Tuple<int, Guid, double> temp;

            for (int i = 0; i < Values.Count; i++)
            {
                for (int j = 0; j < Values.Count - 1; j++)
                {
                    if (Values[j].Item1 > Values[j + 1].Item1)
                    {
                        temp = Values[j + 1];
                        Values[j + 1] = Values[j];
                        Values[j] = temp;
                    }
                }
            }

            Console.WriteLine(DateTime.Now);
        }

        //void BubbleByGuid(List<Tuple<int, Guid, double>> Values)
        //{

        //    Console.WriteLine(DateTime.Now);
        //    Tuple<int, Guid, double> temp;



        //    for (int i = 0; i < Values.Count; i++)
        //    {
        //        for (int j = 0; j < Values.Count - 1; j++)
        //        {

        //            if (Values[j].Item2 > Values[j + 1].Item2)
        //            {
        //                temp = Values[j + 1];
        //                Values[j + 1] = Values[j];
        //                Values[j] = temp;
        //            }
        //        }
        //    }

        //    Console.WriteLine(DateTime.Now);
        //}

        void BubbleByDouble(List<Tuple<int, Guid, double>> Values)
        {
            Console.WriteLine(DateTime.Now);
            Tuple<int, Guid, double> temp;

            for (int i = 0; i < Values.Count; i++)
            {
                for (int j = 0; j < Values.Count - 1; j++)
                {
                    if (Values[j].Item3 > Values[j + 1].Item3)
                    {
                        temp = Values[j + 1];
                        Values[j + 1] = Values[j];
                        Values[j] = temp;
                    }
                }
            }

            Console.WriteLine(DateTime.Now);
        }
    }
}
