using System;

namespace Lab5_02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte[] a = new byte[5];
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("a[{0}]=", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Khong duoc nhap ki tu cho mang so");
                return;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Khong duoc nhap gia tri nam ngoai mien 0-255");
                return;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Loi vuot qua pham vi cua mang");
                return;
            }
            for (int i = 0; i < 5; i++)
            Console.Write(" {0}", a[i]);
        }
    }
}