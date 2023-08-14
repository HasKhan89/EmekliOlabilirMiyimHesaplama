//for (int i = -4; i <= 2; i++)
//0{

//    Console.WriteLine(i);
//}

//sbyte nYas;
//Console.WriteLine("Kaç Yaşındasınız");
//nYas = sbyte.Parse(Console.ReadLine());

//if (nYas >= 18)
//{
//    Console.WriteLine("Ehliyet Alabilirsiniz !");
//}
//else
//{
//    Console.WriteLine("Yaşınız Ehliyet almak için küçük");
//}

//sbyte nYas;
//string szCinsiyet;

//Console.Write("Kaç yaşındasınız? ");
//nYas = sbyte.Parse(Console.ReadLine());
//Console.Write("Cinsiyetiniz? (KADIN / ERKEK)");
//szCinsiyet = Console.ReadLine();

//if ((szCinsiyet == "ERKEK" && nYas > 18) || (szCinsiyet == "KADIN" && nYas > 16))
//{
//    Console.WriteLine("Evlenebilir");
//}
//else
//{
//    Console.WriteLine("Evlenemez");
//}

sbyte[] nYas = new sbyte[4];
sbyte x;
Console.WriteLine("İşe Giriş yılınızı Giriniz");
short iseGirisYili = short.Parse(Console.ReadLine());
Console.WriteLine("Prim Gününüzü Giriniz");
int primGun = int.Parse(Console.ReadLine());

for (x = 1; x < 5; x++)
{
    Console.Write(x.ToString());
    Console.Write(". kişinin yaşı? ");
    nYas[x-1] = sbyte.Parse(Console.ReadLine());
}
for (x = 1;x < 5; x++)
{
    if (nYas[x-1] >= 60 && iseGirisYili <= 2008 && primGun <=7000)
    {
        Console.Write(x.ToString());
        Console.WriteLine(". kişi emekli olabilir");
    }
    else 
    { 
        Console.Write(x.ToString()); 
        Console.WriteLine(". kişi emekli olamaz");
    }
}

Console.ReadLine();