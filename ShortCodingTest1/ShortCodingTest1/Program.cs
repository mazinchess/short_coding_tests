using ShortCodingTest1.impl;
using System;

namespace ShortCodingTest1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var listCustom = new ListifyCustom(100, 200);
            var listFromIList = new ListifyFromIList(100, 200);
            var val1 = listCustom.GetElementAtPosition(10);
            var val2 = listCustom[10];
            var val3 = listFromIList[10];
            Console.WriteLine(val1);
            Console.WriteLine(val2);
            Console.WriteLine(val3);
        }
    }
}