using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        int[] arr = list.ToArray();

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append("hallo");
        stringBuilder.Append(" ");
        stringBuilder.Append("welt");


        string str = stringBuilder.ToString()

        list = arr.ToList();
        Console.WriteLine("NOTIZBUCH");
        Console.WriteLine("Was möchten Sie tun?");
        Console.WriteLine("1...Notiz hinzufügen");
        Console.WriteLine("2...Notiz löschen");
        Console.WriteLine("3...Notiz suchen");
        int eingabe = int.Parse(Console.ReadLine());

        if (eingabe == 1)
        {
            AddNote();
        }
        else if (eingabe == 2)
        {
            DelNote();
        }
        else if (eingabe == 3)
        {
            SearchNote();
        }
        else
        {
            Console.WriteLine("Keine gültige Eingabe! Bitte achte darauf, eine Zahl zwischen 1 und 3 einzugeben.");
        }
    }

    static void AddNote()
    {
        Console.WriteLine("Notiztitel eingeben: ");
        string titel = Console.ReadLine();

        Console.WriteLine("Notizinhalt eingeben: ");
        string inhalt = Console.ReadLine();

        Console.WriteLine("Neue Notiz: ");
        Console.WriteLine(titel);
        Console.WriteLine(inhalt);      
    }
    static void DelNote()
    {
        
    }

    static void SearchNote()
    {
        
    }
}
