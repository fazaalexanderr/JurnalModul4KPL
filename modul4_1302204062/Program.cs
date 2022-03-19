using System;

namespace modul4_1302204062
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<float>(13f, 02f, 20f));
            SimpleDataBase<float> data1 = new SimpleDataBase<float>();
            data1.AddNewData(13f);
            data1.AddNewData(02f);
            data1.AddNewData(20f);
            data1.PrintAllData();
        }
    }

    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T A, T B, T C)
        {
            dynamic tempA = A;
            dynamic tempB = B;
            dynamic tempC = C;
            return tempA + tempB + tempC;
        }
    }

    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T inputData)
        {
            storedData.Add(inputData);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            int i = 0;
            foreach(T data in storedData)
            {
                i++;
                Console.WriteLine("Data " + i + " berisi: " + data + ", yang disimpan pada waktu UTC: " + inputDates[i - 1] + " AM");
            }
        }
    }
}