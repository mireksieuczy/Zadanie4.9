string tekst;
Console.WriteLine("Wprowadź tekst");
tekst = Console.ReadLine();
int liczbaWyrazow = 1;
foreach (char litera in tekst)
    if (litera == ',') liczbaWyrazow++;
Console.WriteLine("Wprowadzony tekst zawiera {0} wyrazów", liczbaWyrazow);
Console.ReadKey();