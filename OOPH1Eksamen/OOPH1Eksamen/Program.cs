﻿using System;
using System.Collections.Generic;

#pragma warning disable 
namespace OOPH1Eksamen
{
    /*
     * I alle de følgende opgaver er der en tilstødende klasse. Det er
     * den der skal arbejdes med i den givne opgave.
     * Navnene på klasserne er irrelevante for jer og må IKKE ændres
     * 
    */


    class Program {
        public static void Main() {
            //Denne funktion kan du bruge til at teste din kode
            Console.WriteLine("Hello World!");
        }
    }

    //OPG Tilføj en property for Alder kaldet "age" til den følgende class
    class B
    {
        public string name = "";
        public int legs = 2;
        public int age = 8;
    }

    //OPG Tilføj en string property kaldet 'brand' til følgende class
    class E
    {
        public string brand = ("");
    }

    //OPG Tilføj en metode der kan forstørre 'a' med 1 hver gang den kaldes
    class C
    {
        public int a;
        for (int a = 0; a < 10; a++)
        {
        
        }

    }

    //OPG Tilføj en metode kaldet "getA" der kan returnere værdien i a
    class G
    {
        string a = "Hello!";
        string getA = a;
        return getA;
    }

    //OPG Tilføj en metode der kan tilføje et tal til numbers. Numbers skal
    //forblive private.
    class F
    {
        List<int> numbers = new List<int>();

    }

    //OPG Implementer encapsulation i denne klasse, men gør således det stadig 
    //er muligt at læse værdierne 'a' og 'b'
    class D
    {
        public int a;
        public string b;
    }

    //OPG Lav en constructor der sætter alle properties af følgende klasse
    class A
    {
        public int a;
        public string b;
        public double c;
    }

    //OPG klassen H skal have en reference til klasse A, kaldet 'a'. Lav en constructor der
    //sætter denne til reference til et objekt af A
    class H
    {
        
    }

    //OPG Ændre funktionen PrintM, således at den ikke crasher programmet hvis den køres.
    class I 
    {
        public string text;

        public void PrintM(){
            Console.WriteLine("Text is " + text.Length + "long");
        }
    }

    //OPG Invoke kan faile hvis der gives en null værdi til dens constructor.
    //sørg for at dette ikke kan forekomme ved kun at ændre på Invoke
    class J
    {
        public I i;

        public void Invoke() {
            i.PrintM();
        }

        public J(I i) {
            this.i = i;
        }
    }

    //OPG Herunder skal du selv implementere en class kaldet MyClass der
    //er subclass til C. Tilføj et public string felt kaldet 'myString'.

    class MyClass
    {
        
    }



}
