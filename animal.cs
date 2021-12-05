using System;

class Animal //clase base
{
    public void eat()
    {
        Console.WriteLine("Se alimenta");
    }
}

class Bird : Animal //clase heredada
{
    public void takeOff()
    {
        Console.WriteLine("Comienza a batir sus alas");
    }
    public void land()
    {
        Console.WriteLine("aterriza y guarda sus alas");
    }
    public void fly()
    {
        Console.WriteLine("Bate sus alas para impulsarse con las corrientes de aire");
    }
    public void buildNest()
    {
        Console.WriteLine("En la copa de un arbol utilizando ramas crea su nido");
    }
    public void layEggs()
    {
        Console.WriteLine("En el nido deposita sus huevos");
    }
}
abstract class Kryptonian : Animal//clase que solo funciona para ser heredada
{
    
}

class Superman : Kryptonian //esta clase hereda de una clase que hereda de otra
{
    public void takeOff()
    {
        Console.WriteLine("Da un gran salto");
    }
    public void land()
    {
        Console.WriteLine("aterriza sobre alguna superficie");
    }
    public void fly()
    {
        Console.WriteLine("comienza a flotar con el poder del sol");
    }
    public void leapBuilding()
    {
        Console.WriteLine("En la cima de un edificio realiza un gran salto");
    }
    public void stopBullet()
    {
        Console.WriteLine("Se mueve mas rapido que la bala y es capaz de pararla con su piel");
    }
}

class prueba //tester class
{
    static void Main()
    {
        Console.Clear();
        Bird ciguaPalmera = new Bird();
        Superman clarkKent = new Superman();
        Console.WriteLine("****OBJETO DE TIPO BIRD****");
        ciguaPalmera.takeOff();
        ciguaPalmera.fly();
        ciguaPalmera.land();
        ciguaPalmera.buildNest();
        ciguaPalmera.layEggs();
        ciguaPalmera.eat();
        Console.WriteLine("****OBJETO DE TIPO KRYPTONIAN****");
        clarkKent.takeOff();
        clarkKent.land();
        clarkKent.fly();
        clarkKent.leapBuilding();
        clarkKent.stopBullet();
        clarkKent.eat();
    }
}