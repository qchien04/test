using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuan3_Bai1
{
    class Student : PerSon

    {
        public string masv;
        public double dtb;
        public string email;

        public Student() { }
        public Student(string hoten, string gioitinh, string diachi, int namsinh,string masv, double dtb, string email)
            : base (hoten, gioitinh, diachi, namsinh)
        {
            this.masv = masv;
            this.dtb = dtb;
            this.email = email;
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                {
                    throw new ArgumentException("Email không hợp lệ! Phải chứa ký tự '@'.");
                }
                email = value;
            }
        }
        public override void inputInfo()
        {
            base.inputInfo();
            Console.Write("Nhap ma sinh vien : ");
            masv = Console.ReadLine();
            Console.Write("Nhap diem trung binh : ");
            dtb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap email : ");
            email = Console.ReadLine();
        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine("MA SINH VIEN : " + masv);
            Console.WriteLine("DIEM TRUNG BINH : " + dtb);
            Console.WriteLine("EMAIL : " + email);
        }
        public double GetDTB()
        {
            return dtb;
        }
        public string GetMASV()
        {
            return masv;
        }
        public bool HocBong()
        {
            return dtb >= 8;
        }
    }
}
