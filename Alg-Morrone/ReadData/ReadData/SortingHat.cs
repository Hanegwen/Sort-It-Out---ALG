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


            Console.WriteLine("Press 1 for Insertion by ID");
            Console.WriteLine("Press 2 for Insertion by Guid");
            Console.WriteLine("Press 3 for Insertion by Double");
            Console.WriteLine("Press 4 for Bubble by ID");
            Console.WriteLine("Press 5 for Bubble by Guid");
            Console.WriteLine("Press 6 for Bubble by Double");

            //Console.WriteLine("Else Try Again");
            string InputValue = Console.ReadLine();

            switch (InputValue)
            {
                case "1":
                    InsertionbyId(ValuesToSort);
                    break;
                case "2":
                    InsertionByGuid(ValuesToSort);
                    break;
                case "3":
                    InsertionByDouble(ValuesToSort);
                    break;
                case "4":
                    BubbleByID(ValuesToSort);
                    break;
                case "5":
                    BubbleByGuid(ValuesToSort);
                    break;
                case "6":
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
                    Console.WriteLine(Values[j]);
                }
            }
            Console.WriteLine(DateTime.Now);
            
        }

        void InsertionByGuid(List<Tuple<int, Guid, double>> Values) //works
        {
            Console.WriteLine(DateTime.Now);
            for (int i = 0; i < Values.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    double doubleValue = (splitUpGuid(Values[j].Item2.ToString("N")));
                    double doubleValue2 = (splitUpGuid(Values[j - 1].Item2.ToString("N")));
                    if (doubleValue2 > doubleValue)
                    {
                        Tuple<int, Guid, double> temp;
                        temp = Values[j - 1];
                        Values[j - 1] = Values[j];
                        Values[j] = temp;
                    }
                    Console.WriteLine(Values[j]);
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
                    Console.WriteLine(Values[j]);
                }
            }

            Console.WriteLine(DateTime.Now);
        }


        void BubbleByID(List<Tuple<int, Guid, double>> Values)  //https://en.wikipedia.org/wiki/Bubble_sort
        {
            Console.WriteLine(DateTime.Now);
            Tuple<int, Guid, double> temp;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < Values.Count - 1; j++)
                {
                    if (Values[j].Item1 > Values[j + 1].Item1)
                    {
                        temp = Values[j + 1];
                        Values[j + 1] = Values[j];
                        Values[j] = temp;
                    }
                    Console.WriteLine(Values[j]);
                }
            }

            Console.WriteLine(DateTime.Now);
        }
                                                               
        void BubbleByGuid(List<Tuple<int, Guid, double>> Values)
        {

            Console.WriteLine(DateTime.Now);
            Tuple<int, Guid, double> temp;
            for (int i = 0; i < Values.Count; i++)
            {
                
                for (int j = 0; j < Values.Count - 1; j++)
                {
                    double doubleValue = (splitUpGuid(Values[j].Item2.ToString("N")));
                    double doubleValue2 = (splitUpGuid(Values[j + 1].Item2.ToString("N")));
                    if (doubleValue > doubleValue2)
                    {
                        temp = Values[j + 1];
                        Values[j + 1] = Values[j];
                        Values[j] = temp;

                    }
                    Console.WriteLine(Values[j]);
                }
            }

            Console.WriteLine(DateTime.Now);
        }
        /// <summary>
        /// This is used to split up the Hexadecimals because they were too big to convert to any numerical types
        /// https://docs.microsoft.com/en-us/dotnet/api/system.guid.parse?view=netframework-4.7.2
        /// https://docs.microsoft.com/en-us/dotnet/api/system.string.substring?redirectedfrom=MSDN&view=netframework-4.7.2#System_String_Substring_System_Int32_System_Int32_
        /// </summary>
        long splitUpGuid(string hexVal)
        {
            string foo = hexVal;
            List<long> listValue = new List<long>();
            int startingIndex;
            int length = 2;
            long total = 0;
            for(int i = 0; i < 16; i++)
            {

                    startingIndex = i + (i * 1);
                    string substring = foo.Substring(startingIndex, length);
                    long decValue = int.Parse(substring, System.Globalization.NumberStyles.HexNumber);
                    listValue.Add(decValue);;

            }
            for (int n = 0; n < listValue.Count; n++)
            {
                total = total + listValue[n];
                
            }
            return total;

        }


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
                    Console.WriteLine(Values[j]);
                }
            }

            Console.WriteLine(DateTime.Now);
        }
    }
}
