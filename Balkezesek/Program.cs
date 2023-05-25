

using Balkezesek;

internal class orai
{
    static List<Class1> BalosLista = new List<Class1>();

    static void Main(string[] args)
    {
        StreamReader beolvas = new StreamReader("Balkezesek");
        BalosLista.Skip(1);
        while (!beolvas.EndOfStream) ;
        {
            string[] data = beolvas.ReadLine().Split(';');
            Console.WriteLine(data);
        }
        beolvas.Close();
    }



}
