using System;
namespace Day_4
{
class X
{
protected int x;
public X()
{
x = 10;
}
}
class Y:X
{
public int getX()
{
return x;
}
}
class Program
{
public static void Main()
{
X obj1 = new X();
Y obj2 = new Y();
Console.WriteLine("Value of x : "+obj2.getX());
Console.ReadLine();
}
}
}