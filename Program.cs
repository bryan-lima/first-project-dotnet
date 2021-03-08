using System;

namespace first_project_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopLimit = 5;

            for(int i = 0; i <= loopLimit; i++) {
                Console.WriteLine($"My first .NET project written in C#! >>{i}<<");
            }
        }
    }
}
