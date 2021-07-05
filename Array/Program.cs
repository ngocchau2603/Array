using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstNumber = new List<int>();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(lstNumber);
            }
        }
        private static bool MainMenu(List<int> lstNumber)
        {
            var program = new Program();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Nhap mang");
            Console.WriteLine("2) Thong tin mang");
            Console.WriteLine("3) Tinh trung binh");
            Console.WriteLine("4) Tim phan tu lon nhat");
            Console.WriteLine("5) So luong phan tu = 5");
            Console.WriteLine("6) Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    program.AddInfo(lstNumber);
                    return true;
                case "2":
                    program.PrintOrigin(lstNumber);
                    return true;
                case "3":
                    program.CalculateAvarage(lstNumber);
                    return true;
                case "4":
                    program.PrintMax(lstNumber);
                    return true;
                case "5":
                    program.CountEqual5(lstNumber);
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }
        private void PrintOrigin(List<int> lstNumber)
        {
            Console.WriteLine(string.Join(" ", lstNumber));
        }
        private void PrintMax(List<int> lstNumber)
        {
            Console.WriteLine($"So lon nhat: {lstNumber.Max()}");
        }
        private void CalculateAvarage(List<int> lstNumber)
        {
            var tong = lstNumber.Sum();
            var trungBinh = (double)tong / lstNumber.Count();
            Console.WriteLine($"Trung binh cong: {trungBinh}");
        }
        private void CountEqual5(List<int> lstNumber)
        {
            var count = lstNumber.Count(x => x == 5);
            Console.WriteLine($"So luong phan tu bang 5: {count}");
        }
        private void AddInfo(List<int> lstNumber)
        {
            Console.WriteLine("1) Nhap chieu dai mang: ");
            var doDai = Console.ReadLine();
            if (Int32.TryParse(doDai, out int iDoDai))
            {
                for (int i = 0; i < iDoDai; i++)
                {
                    var newNumber = Console.ReadLine();
                    lstNumber.Add(Convert.ToInt32(newNumber));
                }
            }
        }
    }
}
