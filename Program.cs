using System;
using System.Collections.Generic;

namespace collectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = {0,1,2,3,4,5,6,7,8,9};
            foreach(int num in arr){
                Console.Write(num);
            }

            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            foreach(string members in names){
                Console.WriteLine($"{members} is a member");
            }

            for(int i = 0; i<=10 - 1; i++){
                if(i%2==0){
                    Console.WriteLine("True");
                }
                else{
                    Console.WriteLine("False");
                }
            }

            List<string> flavor = new List<string>();//Creating a string list
            flavor.Add("Chocolate"); //using the .Add() to add ice cream flavors to flavor
            flavor.Add("Pineapple");
            flavor.Add("Vanilla");
            flavor.Add("Mint");
            flavor.Add("Strawberry");
            Console.WriteLine($"{flavor.Count}");//counts how many flavors are stored in flavor
            Console.WriteLine(flavor[2]);
            flavor.Remove(flavor[2]);//used the method .Remove() to take out a flavor from the list.
            foreach(string iceCream in flavor){
                Console.Write($" {iceCream}");
            }




        }
    }
}
