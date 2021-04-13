using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("Lütfen bir harf giriniz: ");
		string harf = Console.ReadLine();

		switch (harf)
		{
			case "a":
				Console.WriteLine("Ahmet, Aleyna, Yağmur, Bilal, Deniz");
				break;
			case "b":
				Console.WriteLine("Can, Yusuf, Aslı, Mehmet, Ayşe");
				break;
			case "c":
				Console.WriteLine("Barbaros, Ceren, Duygu, Berkan, Seda");
				break;
			case "d":
				Console.WriteLine("Derya, Metin, Emine, Mustafa, Dilek");
				break;
			default:
				Console.WriteLine("Bu karakterle uyuşan isim bulunamadı.");
				break;
		}
	}
}
