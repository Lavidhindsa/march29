using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("download");
            Download();
            Console.ReadLine():
            

            
        }
        static async void Download()
        {
<<<<<<< HEAD
            await Network.download();
            Console.WriteLine("download complete");
        }


        class Network
        {
            static public Task download()
            {
                return Task.Run(
                () => ThreadStaticAttribute.Sleep(60000));
            }
        }
    } }
=======
            Thread.Sleep(66000);
            Console.WriteLine("download complete...");
        }
    }
}
>>>>>>> 18ab89d3edbff724322ebfbd439e05f9c839c449
