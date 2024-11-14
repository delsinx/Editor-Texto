using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Editor Mode");
            Console.WriteLine("Press F1 to save");
            Console.WriteLine("To exit text editor mode press ESC after saving");
            Console.WriteLine("=====================================");
            Start( );

        }
        
        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
                
            }while(Console.ReadKey().Key != ConsoleKey.F1);

            {
                
               string path = @"C:\Users\Delsin\Desktop\C#\EditorHTML\arquivo.txt";
                var arquivo = file.ToString();
                File.WriteAllText(path, arquivo);
                Console.WriteLine("=====================================");
                Console.WriteLine("File saved successfully!");
                Console.WriteLine("=====================================");
                Console.WriteLine($"File save on: {path}");
                Console.WriteLine("=====================================");
                
            }
            Console.WriteLine("Press ESC 2 times to exit");
            while (Console.ReadKey().Key == ConsoleKey.Escape) 
            {                                                  
                                                   
                Fechar.Close();                                
                                                   
            }                                                  
              
            
            
           
            
        }
    }
}