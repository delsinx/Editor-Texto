namespace EditorHtml;

public class Viewer
{
    public static void Visualizador()
    {
        Console.Clear();                                                                    
        Console.BackgroundColor = ConsoleColor.Black;                                       
        Console.ForegroundColor = ConsoleColor.Green;                                       
        var read = File.ReadAllText(@"C:\Users\Delsin\Desktop\C#\EditorHTML\arquivo.txt");  
        Console.WriteLine(read);                                                            
        Console.ReadLine();                                                                 
        Fechar.Close();                                                                     
    }
}