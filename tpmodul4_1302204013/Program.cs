using System;

namespace tpmodul4_1302204013
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            HaloGeneric<string> halo = new HaloGeneric<string>();
            Console.WriteLine("Masukkan Nama User");
            String x = Console.ReadLine();
            halo.SapaUser(x);
        }
    }

    public class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("\nHalo user " + x);
        }
    }
}
