namespace TextEditor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hello");
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("1 - Criar arquivo");
        Console.WriteLine("0 - Sair");

        short option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                Abrir();
                break;
            case 2:
                Editar();
                break;
            case 0:
                System.Environment.Exit(0);
                break;

            default:
                break;
        }

        static void Abrir()
        {
            Console.Clear();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Menu();
        }
    }
}