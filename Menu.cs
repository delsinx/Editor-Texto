
using System.Diagnostics;
using System.Security.Cryptography;

namespace EditorHtml
{
   public static class Menu
   {
      public static void Show()
      {
         Console.Clear();
         Console.BackgroundColor = ConsoleColor.Black;
         Console.ForegroundColor = ConsoleColor.Red;
         Console.Title = "Editor HTML";

         

      }

      public static void Linha()
      {
         Console.Write("*");
         for (int i = 0; i <= 35; i++)
         {
            Console.Write("*");
           
         }
         Console.Write("*");
         Console.Write("\n");
         
         
      }

      public static void Coluna()
      {
         for (int i = 0; i <= 12 ;i++)
         {
            Console.Write("|");
            for (int j = 0; j <= 35; j++)
            {
               Console.Write(" ");
            }
            Console.WriteLine("|");
         }
      }

      public static void Opcoes()
      {
         Console.SetCursorPosition(2, 2);
         Console.WriteLine("Editor HTML");
         Console.SetCursorPosition(3,3);
         Console.WriteLine("=====================");
         Console.SetCursorPosition(3,4);
         Console.WriteLine("Selecione uma opção abaixo");
         Console.SetCursorPosition(3,6);
         Console.WriteLine("1 - Novo arquivo");
         Console.SetCursorPosition(3,7);
         Console.WriteLine("2 - Abrir");
         Console.SetCursorPosition(3,8);
         Console.WriteLine("0 - Sair");
         Console.SetCursorPosition(3,10);
         Console.Write("Opção: ");
         
      }
      
      
   }
}


