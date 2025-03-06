// See https://aka.ms/new-console-template for more information
 namespace BaiTapTuan3_Bai1
{
    public class PerSon
    {
        public string hoten, gioitinh, diachi;
        public int namsinh;
        public int stt;

        public PerSon() { }
        public PerSon (string hoten, string gioitinh, string diachi, int namsinh)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.namsinh = namsinh;
        }
        public virtual void inputInfo()
        {
            Console.Write("Nhap ho va ten : ");
            hoten = Console.ReadLine();
            Console.Write("Nhap gioi tinh : ");
            gioitinh = Console.ReadLine();
            Console.Write("Nhap dia chi : ");
            diachi  = Console.ReadLine();
            Console.Write("Nhap nam sinh : ");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap stt : ");
            stt = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void showInfo()
        {
            Console.WriteLine("HO TEN : " + hoten);
            Console.WriteLine("GIOI TINH : " + gioitinh);
            Console.WriteLine("DIA CHI : " + diachi);
            Console.WriteLine("NAM SINH : " + namsinh);
        }

    }
    
}
