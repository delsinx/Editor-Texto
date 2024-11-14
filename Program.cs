using System;
using System.ComponentModel.Design;

namespace EditorHtml;

class Program
{
    static void Main(string[] args)
    {
        Menu.Show();
        Menu.Linha();
        Menu.Coluna();
        Menu.Linha();
        Menu.Opcoes();
        Console.SetCursorPosition(10, 10);

        short escolha = short.Parse(Console.ReadLine());
        if (escolha == 1)
        {
            Console.Clear();
            Editor.Show();
            Editor.Start();
        }
        else if (escolha == 2)
        {
              Viewer.Visualizador(); 
              
              
        }
    }
}

