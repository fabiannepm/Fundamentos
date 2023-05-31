using System;
using System.Text;


public static class Editor
{

    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("--------");
        Start();
    }

    public static void Start()
    {
        var file = new StringBuilder();

        do 
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("--------");
        Console.WriteLine(@"Deseja salvar o arquivo? Informe 'S' para salvar!");

        var salvaArquivo = Console.ReadLine();
        if (salvaArquivo =="S")
        {
            Console.WriteLine(@"Informe o caminho do arquivo:");
            var caminhoArquivo = Console.ReadLine();
            using(var arquivo = new StreamWriter(caminhoArquivo)) 
            {
                arquivo.Write(file.ToString());
            }            
            Console.WriteLine("Arquivo salvo com sucesso!");
            Console.ReadLine();
        }

        Viewer.Show(file.ToString());                  
    }

}