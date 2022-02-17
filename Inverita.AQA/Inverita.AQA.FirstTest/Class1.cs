using System;

namespace Inverita.AQA.FirstTest
{
    public class MyCalculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        
        
        public static int Add(int num1, int num2) => num1 + num2;

        public int Add() => FirstNumber + SecondNumber;
    }
}