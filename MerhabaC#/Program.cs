﻿//Kullanıcıdan isim ve yaş al ekrana yazdır
string ad;
int yas;

Console.Write("isminiz: ");
ad = Console.ReadLine();
Console.Write("Yas : ");
yas = Convert.ToInt32(Console.ReadLine());
Console.Write(ad + " " + yas + " Yasinda");


//Kullanıcıdan iki sayı al kalanı ekrana yazdır
int x;
int y;

Console.Write("1.sayi: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("2.sayi : ");
y = Convert.ToInt32(Console.ReadLine());
Console.Write(x % y);

