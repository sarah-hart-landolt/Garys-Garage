using System;

namespace Gary_s_Wholesale_Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram Classic1500= new Ram();

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine("");
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
Console.WriteLine("");
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
Console.WriteLine("");
            Classic1500.Drive();
            Classic1500.Turn();
            Classic1500.Stop();
            
        }
    }
}