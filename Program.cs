using System;
using System.Runtime.Intrinsics.X86;

namespace modul5_103022300014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PemrosesData pb = new PemrosesData();
            double d1 = 10, d2 = 30, d3 = 22;
            
            Console.WriteLine(pb.DapatkanNilaiTerbesar(d1, d2, d3));
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
    }
}
