using System;
using Assembly1;
namespace Day_4
{
public class Day4
{
//method
public void Display()
{
Console.WriteLine("Hi, i am a sample assembly")
}
//function
static void Main()
{
 AssemblyClass assemblyClass = new AssemblyClass();
            Console.WriteLine(assemblyClass.Sum(1, 2));
            Console.WriteLine(assemblyClass.Sub(4, 2));
            Console.WriteLine(assemblyClass.Mul(3, 2));
            Console.WriteLine(assemblyClass.Div(8, 2));
            Console.ReadLine();
        }
    }