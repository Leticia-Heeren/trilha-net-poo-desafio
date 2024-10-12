using DesafioPOO.Models;

using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone iphone = new Iphone("111111111", "iPhone 13");
        iphone.Ligar();
        iphone.InstalarAplicativo("WhatsApp");

        Smartphone nokia = new Nokia("222222222", "Nokia 3310");
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");
    }
}