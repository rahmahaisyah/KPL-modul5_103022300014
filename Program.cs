using System;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static modul5_103022300014.Program;

namespace modul5_103022300014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PemrosesData pb = new PemrosesData();
            SimpleDataBase<string> db= new SimpleDataBase<string>();
            db.AddNewData("12");
            db.AddNewData("30");
            db.AddNewData("22");
            double d1 = 10, d2 = 30, d3 = 22;
            
            Console.WriteLine(pb.DapatkanNilaiTerbesar(d1, d2, d3));
            db.PrintAllData();
        }
        public class PemrosesData
        {

            public double DapatkanNilaiTerbesar<T>(T a1, T a2, T a3)
            {
                dynamic n1 = a1;
                dynamic n2 = a2;
                dynamic n3 = a3;
                dynamic jumlah = n1;

                if (jumlah < n2)
                {
                    jumlah = n2;
                }
                if (jumlah < n3)
                {
                    jumlah = n3;
                }
                return jumlah;
            }
        }

        public class SimpleDataBase<T>
        {
            private List<T> storedData;
            private List<DateTime> inputDates;

            public SimpleDataBase() { 
                this.storedData = new List<T>();
                this.inputDates = new List<DateTime>();
            }

            public void AddNewData(T storeData )
            {
                storedData.Add(storeData);
                DateTime dateTime = DateTime.Now;
                inputDates.Add(dateTime);
            }

            public void PrintAllData()
            {
                int i = 1;
                foreach ( T storeData in storedData)
                {
                    Console.WriteLine($"Data {i} berisi {storeData}, yang " +
                        $"tersimpan pada waktu UTC: {DateTime.Now}");
                    i++;
                }
                
            }
        }
    }
}
