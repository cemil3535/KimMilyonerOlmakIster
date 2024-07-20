// See https://aka.ms/new-console-template for more information

//Degiskenlerin tanimlanmasi
string verilenCevap;
int dogruCevapSay = 0;
int yanlisCevapSay = 0;

Console.WriteLine("Kim Milyoner Olmak yarismasina hos geldinz. Sorulan 3 sorunun 2'sini dogru bildiginizde buyuk odul olan 1 Milyon TL. Kazanacaksiniz. Hadi hemen yarismaya baslayalim!!!!");

// Yarismayica birinci sorunun sorulup, dogru ve yanlis cevap sayilarinin sayaca atanmasi
Console.WriteLine("1. Soru-> Kizinca tukuren hayvan hangisidir? \na) Lama  b) Deve");
verilenCevap = Console.ReadLine().ToUpper();
if (verilenCevap == "A")
{
    Console.WriteLine("Dogru cevap verdiniz. Tebrikler!!!");
    dogruCevapSay++;
}

else
{

    Console.WriteLine("Yanlis cevap verdiniz. Uzgunum!!!");
    yanlisCevapSay++;
}

// Yarismayica ikinci sorunun sorulup, dogru ve yanlis cevap sayilarinin sayaca atanmasi
Console.WriteLine("2. Soru-> Dunyaya en yakin gezegen hangisidir? \na) Venus  b) Mars");
verilenCevap = Console.ReadLine().ToUpper();
if (verilenCevap == "A")
{
    Console.WriteLine("Dogru cevap verdiniz. Tebrikler!!!");
    dogruCevapSay++;
}

else
{

    Console.WriteLine("Yanlis cevap verdiniz. Uzgunum!!!");
    yanlisCevapSay++;
}
// Dogru veya yanlis cevap sayisinin 2 ye  esit olup olmadiginin kontrol edilmesi. Dogru cavap sayisi 2 ye esitse yarismaciya ikramiyeyi kazandigi, yanlis cevap sayaci 2 ye esitse yarismaciya ikramiyeyi kaybettigi mesajinin gosterilmesi

if (dogruCevapSay == 2)
{
    Console.WriteLine("Tebrikler!!! 2 soruya dogru cevap verdiniz. 1 Milyon TL. buyuk odulu kazandiniz. Iyi gunlerde harcayin:)))");

}
if (yanlisCevapSay == 2)
    Console.WriteLine("Uzgunum 2 soruya  yanlis cevap verdiniz. 1 Milyon TL buyuk odulu kaybettiniz!!!.");

// Dogru veya yanlis sayisindan birisi 2 den kucukse 3. sorunun yarismaciya sorulmasi 

if ((dogruCevapSay < 2 ) && (yanlisCevapSay < 2) )
{

    Console.WriteLine("3. Soru-> 5 * 2 + 8 / 2 - 2 isleminin sonucu kactir ? \na) 7  b) 12");
    verilenCevap = Console.ReadLine().ToUpper();
    if (verilenCevap == "B")
    {
        Console.WriteLine("Dogru cevap verdiniz. Tebrikler!!!");
        dogruCevapSay++;
    }

    else
    {

        Console.WriteLine("Yanlis cevap verdiniz. Uzgunum!!!");
    }
    if (dogruCevapSay == 2)
    {
        Console.WriteLine("Tebrikler!!! 2 soruya dogru cevap verdiniz. 1 Milyon TL. buyuk odulu kazandiniz. Iyi gunlerde harcayin:)))");
    }
    else
        Console.WriteLine("Uzgunum 2 soruya yanlis cevap verdiniz. 1 Milyon TL buyuk odulu kaybettiniz!!!.");
}

