Console.Write("Zadej délku hesla:");
int delkahesla = Convert .ToInt32(Console.ReadLine());

string filepath = @"D:\Jakub\Hesla\heslo.txt";
string cisla = "0123456789";
string abeceda = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string oboji = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string vygenerovaneHeslo = "";

int delka = abeceda.Length;
int delka1 = cisla.Length;
int delka2 = oboji.Length;
Console.Clear();

Console.WriteLine("chcete v heslu mít znaky,čísla nebo obojí?");
string odpoved = Console.ReadLine();
Console.Clear();

if (odpoved == "znaky")
{
    for (int i = 0; i < delkahesla; i++)
    {
        Random rand = new Random();
        int randomCislo = rand.Next(0, delka);
        vygenerovaneHeslo += abeceda[randomCislo];
    }
    Console.WriteLine($"tvé vygenerované heslo je : {vygenerovaneHeslo} ");
}

if (odpoved == "čísla")
{
    for (int i = 0; i < delkahesla; i++)
    {
        Random rand = new Random();
        int randomCislo = rand.Next(0, delka1);
        vygenerovaneHeslo += cisla[randomCislo];
    }
    Console.WriteLine($"tvé vygenerované heslo je : {vygenerovaneHeslo} ");
}

if (odpoved == "obojí")
{
    for (int i = 0; i < delkahesla; i++)
    {
        Random rand = new Random();
        int randomCislo = rand.Next(0, delka2);
        vygenerovaneHeslo += oboji[randomCislo];
    }
    Console.WriteLine($"tvé vygenerované heslo je : {vygenerovaneHeslo} ");
}

File.WriteAllText(filepath, vygenerovaneHeslo);






