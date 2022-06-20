using static System.Console;
namespace Prn_se1629;
public class Program
{
    public static void Main()
    {
        //1. Dong bo
        //PrintNumber();
        //WriteLine("======================================");
        //PrintNumber();
        //WriteLine("======================================");
        //PrintNumber();
        //WriteLine("======================================");
        //Console.ReadLine();

        //2. Tao ra 3 thread, moi thread thuc thi loi goi PrintNumber
        for (int i = 1; i <= 5; i++)
        {
            Thread t = new Thread(() => PrintNumber(i));
            t.Start();
        }
        //Thread t1 = new Thread(() => PrintNumber(1));
        //t1.Start();

        //Thread t2 = new Thread(() => PrintNumber(2));
        //t2.Start();

        //Thread t3 = new Thread(() => PrintNumber(3));
        //t3.Start();
    }

    public static void PrintNumber(int indexThread)
    {
        for (int i  = 1; i <= 5; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Thread {indexThread}: {i}");
        }
    }
}
