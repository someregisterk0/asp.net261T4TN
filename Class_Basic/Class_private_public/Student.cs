using System;
using System.Collections.Generic;
using System.Text;

namespace Class_private_public
{
    class Student
    {
        private string fullName;
        string email;
        public string address;

        public void Nhap()
        {
            Console.Write("Nhap ten: ");
            fullName = Console.ReadLine();
            Console.Write("Nhap email: ");
            email = Console.ReadLine();
            Console.Write("Nhap address: ");
            address = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine($"ten: {fullName}\nemail: {email}\naddress: {address}");
            DoThat();
        }

        void DoThat()
        {
            Console.WriteLine("Do That method");
            DoThis();
        }

        private void DoThis()
        {
            Console.WriteLine("do this method");
        }
    }
}
