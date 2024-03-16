using System;
using System.Linq;
using System.Collections.Generic;
//using Regnemaskine;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace RegnemaskineNS 
{ 

public class Regnemaskine
{
    private int a, b;


    public Regnemaskine() { a = 0; b = 0; }
    public Regnemaskine(int _a, int _b)
    {
        a = _a;
        b = _b;
    }

    public int plus(int _a, int _b) { return _a + _b; }
    public int minus(int _a, int _b) { return _a - _b; }
    //lav gange
    public int gange(int _a, int _b) { return _a * _b; }
    //lav dividere
    public int divider(int _a, int _b) { return _a / _b; }
    }

    public class Program
{

    public static void Main(String[] args)
    {
        Regnemaskine r = new Regnemaskine();
        Console.WriteLine("Jeg vil nu lægge to tal sammen");
        Console.WriteLine("1+2=" + r.plus(1, 2));
        Console.WriteLine("1-2=" + r.minus(1, 2));
        Console.WriteLine("1*2=" + r.gange(1, 2));
            //lav dividere
    }


}

}