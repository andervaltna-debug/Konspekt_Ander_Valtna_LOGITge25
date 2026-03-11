// See https://aka.ms/new-console-template for more information
    //Ülesanne 1
    int vanus;
    do
    {
    Console.WriteLine("Sisesta siia oma vanus: ");
    vanus = int.Parse(Console.ReadLine());
    if (vanus <= 0)
    {
        Console.WriteLine("Arv peab olema suurem kui 0. ");
    }
}   while (vanus <= 0);
    Console.WriteLine("Sinu vanus on: " + vanus);

     //Ülesanne 2
     int aasta;
     Console.WriteLine("Sisesta aastaarv vahemikus 1000 - 2025: ");
{
    aasta = int.Parse(Console.ReadLine());
    while (aasta < 1000 || aasta > 2025)
    {
        Console.WriteLine("Arve peab olema neljakohaline ja vahemikus 1000 - 2025");
        Console.WriteLine("Proovi uuesti: ");
        aasta = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Sisestasid sobiva aastarvu:" + aasta);

    //Ülesanne 3
    string[] jõuluKingiIdeed = { "sokid", "kampsun", "iphone 17", "käekell", "piparkoogid" };

    for (int i = 0; i < jõuluKingiIdeed.Length; i++)
    {
        Console.WriteLine((i + 1) + ". " + jõuluKingiIdeed[i]);
    }

    //Ülesanne 4
    int[] täisArvud = { 3, 4, 6, 7, 8 };
    int korrutis = 1;
    foreach (int arv in täisArvud)
    {
        korrutis = korrutis * arv;
    }
    Console.WriteLine("Kõigi elementide massiivi korrutis on: " + korrutis);

}
