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
            Console.WriteLine("\nMasukkan Data");
            String Data = Console.ReadLine();
            DataGeneric<String> data = new DataGeneric<string>(Data);
            data.PrintData();
        }
    }

    public class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("\nHalo user " + x);
        }
    }
    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("\nData yang tersimpan adalah: " + this.data);
        }
    }
}

