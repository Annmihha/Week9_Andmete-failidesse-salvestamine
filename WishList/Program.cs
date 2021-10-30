using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count); // loeb üle mitu rida on loetelus, enne lisamist on 0

            myWishList.Add("coffee machine"); // loetelusse kirje lisamine
            myWishList.Add("new pair of socks");
            myWishList.Add("box of chocolates");
            myWishList.Add("new pillow");

            Console.WriteLine(myWishList.Count); // loeb üle mitu rida on loetelus, peale lisamist on 4

            //Console.WriteLine(myWishList[0]); // konsool loetleb sisestatud nemed asukoha indeksi järgi
            //Console.WriteLine(myWishList[1]);
            //Console.WriteLine(myWishList[2]);
            //Console.WriteLine(myWishList[3]);

            foreach(string wish in myWishList) // konsool loetleb nimekirja foreach funktsiooniga
            {
                Console.WriteLine(wish);
            }



        }
    }
}
