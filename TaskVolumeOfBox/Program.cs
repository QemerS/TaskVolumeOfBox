using System;

namespace TaskVolumeOfBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Sizes box = new Sizes();
           
            int a = box.CalculateVolume(1,2,3);
            Console.WriteLine(a);
        }
    }
}
