using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhCanChi
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };

            string[] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };

            Console.WriteLine("Moi ban nhap mot nam bat ky: ");

            year = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", year, Can[year % 10], Chi[year % 12]);

            Console.ReadLine();
        }
    }
}
