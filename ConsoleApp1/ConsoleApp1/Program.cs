using System;
using System.Collections;
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
            download();
            Console.ReadLine():
            

            
        }
        static async void download()
        {
            await Network.download();
            Console.WriteLine("download complete");
        }


        class Network
        {
            static ArrayList WebPageContents = new ArrayList();
            public static async Task download()
            {
                HttpClient client = new HttpClient();
                var data = await client.GetStringAsnyc("http://torontopubliclibrary.ca");
                //Console.WriteLine(data);
                foreach (var i in data)
                {
                    WebPageContents.Add(i);
                }
            }
        }
    } }