﻿using System;

namespace SQSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SQSOperations operations = new SQSOperations();
            operations.AddTags();
            Console.ReadLine();
        }
    }
}
