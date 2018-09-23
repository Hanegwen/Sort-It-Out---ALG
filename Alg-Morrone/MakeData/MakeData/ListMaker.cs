using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeData
{
    class ListMaker
    {
        int localNumber = 0;
        List<string> TheDataList = new List<string>();
        Random ranNum = new Random();
        public void MakeTheList(int DataAmount)
        {

            for (int i = 0; i < DataAmount; i++)
            {
                TheDataList.Add(MakeTheData());
                localNumber++;
            }


            System.IO.File.WriteAllLines(@"C:\workspace\writeLine.csv" , TheDataList);
        }

        string MakeTheData()
        {
            int rowNumber = localNumber;

            Guid localGuid = Guid.NewGuid();

           

            double localDouble = ranNum.NextDouble();

            

            string OutputString = rowNumber +", " + localGuid + ", " + localDouble;

            return OutputString;
        }
    }
}
