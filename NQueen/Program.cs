// See https://aka.ms/new-console-template for more information
Console.WriteLine("N değerini giriniz:");

int n = Convert.ToInt32(Console.ReadLine());

int kalan = n % 12;

List<int> ciftSayilar = new List<int>();
List<int> tekSayilar = new List<int>();

// ALGORİTMA KALAN 3 İÇİN ÇALIŞIYOR.
// ALGORİTMA KALAN 2 İÇİN ÇALIŞIYOR.
// ALGORİTMA KALAN 8 İÇİN ÇALIŞIYOR.

for (int i = 2; i <= n; i += 2)
{
	
	ciftSayilar.Add(i);
	
}

if (kalan == 3 || kalan == 9)
{
	for (int i = 0; i < ciftSayilar.Count; i++)
	{
		if (ciftSayilar[i] == 2)
		{
			ciftSayilar.Remove(2);
		}
	}
	ciftSayilar.Add(2);
}


if (kalan == 2)
{
	tekSayilar.Add(3);
	tekSayilar.Add(1);
	for (int i = 7; i < n+1; i+=2)
	{
		tekSayilar.Add(i);
		if (i == 1 || i == 3)
		{
			tekSayilar.Remove(i);
		}
	}
	for (int i = 0; i < tekSayilar.Count; i++)
	{
		if (tekSayilar[i] == 5)
		{
			tekSayilar.Remove(i);
		}
	}
	tekSayilar.Add(5);
}

if (kalan == 3 || kalan == 9)
{
	for (int i = 0; i < tekSayilar.Count; i++)
	{
		if (tekSayilar[i] == 3 || tekSayilar[i] == 9)
		{
			tekSayilar.Remove(i);
		}
	}
	tekSayilar.Add(1);
	tekSayilar.Add(3);
}

if (kalan == 8)
{
	for (int i = 1; i < n+1; i+=2)
	{
		tekSayilar.Add(i);
	}
	for (int i = 0; i < tekSayilar.Count - 1; i+=2)
	{
		int temp = tekSayilar[i];
		tekSayilar[i] = tekSayilar[i + 1];
		tekSayilar[i + 1] = temp;
	}
}


foreach (int sayi in ciftSayilar)
{
	Console.Write(sayi + " ");
}
foreach (int sayi in tekSayilar)
{
	Console.Write(sayi + " ");
}

Console.ReadLine();


