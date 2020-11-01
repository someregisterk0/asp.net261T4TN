using System;

namespace BaoBuaKeo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quy ước
            Console.WriteLine("0: Bao");
            Console.WriteLine("1: Bua");
            Console.WriteLine("2: Keo");

            string[] chon = { "Bao", "Bua", "Keo" };

            string[,] ketQua =
            {
                {"Hoa", "Thang", "Thua" },
                {"Thua", "Hoa", "Thang" },
                {"Thang", "Thua", "Hoa" }
            };

            // máy nhập
            Random rand = new Random();
            int com = rand.Next(0, 3);

            // người nhập
            Console.Write("Moi ban nhap: ");
            int hum = int.Parse(Console.ReadLine());

            // kiểm tra kết quả
            Console.WriteLine($"Nguoi chon: {chon[hum]}");
            Console.WriteLine($"May chon: {chon[com]}");
            Console.WriteLine($"Ket qua: nguoi {ketQua[hum, com]}");
        }
    }
}
