// See https://aka.ms/new-console-template for more information
Console.WriteLine("N değerini giriniz:");

int n = Convert.ToInt32(Console.ReadLine());

int kalan = n % 12;

List<int> ciftSayilar = new List<int>();
List<int> tekSayilar = new List<int>();

// Çift sayıları ekler.
for (int i = 2; i <= n; i += 2)
{

	ciftSayilar.Add(i);

}

// Kalanın 3 ve 9 olması durumunda çalışan kod.
if (kalan == 3 || kalan == 9)
{
	for (int i = 1; i <= n; i += 2)
	{
		tekSayilar.Add(i);
	}

	// 2 sayısını listenin sonuna al.
	for (int i = 0; i < ciftSayilar.Count; i++)
	{
		if (ciftSayilar[i] == 2)
		{
			ciftSayilar.Remove(2);
		}
	}
	ciftSayilar.Add(2);
	// 1 ve 3 ün yerini değiştir.
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

// Kalan 2 için çalışır.
if (kalan == 2)
{
	// Tek sayılara öncelikle 3 ve 1 i ekle.
	tekSayilar.Add(3);
	tekSayilar.Add(1);

	// Eğer i = 1 yada 3 ise listeden çıkart.
	for (int i = 7; i < n + 1; i += 2)
	{
		tekSayilar.Add(i);
		if (i == 1 || i == 3)
		{
			tekSayilar.Remove(i);
		}
	}
	// 5 sayısını sona almak için en son 5 sayısını ekle.
	for (int i = 0; i < tekSayilar.Count; i++)
	{
		if (tekSayilar[i] == 5)
		{
			tekSayilar.Remove(i);
		}
	}
	tekSayilar.Add(5);
}

// Kalan 8 ise çalış.
if (kalan == 8)
{
	for (int i = 1; i < n + 1; i += 2)
	{
		tekSayilar.Add(i);
	}
	// Tek sayıların bir sonraki sayı ile yerini değiştir.
	for (int i = 0; i < tekSayilar.Count - 1; i += 2)
	{
		int temp = tekSayilar[i];
		tekSayilar[i] = tekSayilar[i + 1];
		tekSayilar[i + 1] = temp;
	}
}

// Ekrana bas.
foreach (int sayi in ciftSayilar)
{
	Console.Write(sayi + " ");
}
foreach (int sayi in tekSayilar)
{
	Console.Write(sayi + " ");
}

Console.ReadLine();


