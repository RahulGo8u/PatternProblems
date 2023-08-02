using System;

namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern1(4);
        }
        //*
        //**
        //***
        //****
        static void Pattern1(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(  "*");
                }
                Console.WriteLine();
            }
        }
    }
}
