namespace TextEditor;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Criar arquivo");
        Console.WriteLine("2 - Abrir arquivo");
        Console.WriteLine("0 - Sair");

        short option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                Editar();
                break;
            case 2:
                Abrir();
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
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine()!;

            try
            {
                using (var file = new StreamReader(path))
                {
                    string text = file.ReadToEnd();
                    Console.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("________________________");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            try
            {
                using (var file = new StreamWriter(path))
                {
                    file.Write(text);
                }

                Console.WriteLine($"Arquivo {path} salvo com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar o arquivo: {ex.Message}");
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso");
            Menu();
        }
    }
}