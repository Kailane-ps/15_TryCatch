using System;
using System.IO;

namespace _15_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Permissao permissao = new Permissao();
            permissao.Autorizar();

           try 
           {
               using (StreamReader sr= File.OpenText("data.txt") )
               {
                   Console.ForegroundColor = ConsoleColor.Magenta;
                   System.Console.WriteLine($"Primeira linha do arquivo: \n {sr.ReadLine()}" );
                   Console.ResetColor();
               }
           }
        
            catch(FileNotFoundException)
            {
                System.Console.WriteLine($"O arquive não foi encontrado");
            }
            catch(DirectoryNotFoundException)
            {
                System.Console.WriteLine($"O diretorio não foi encontrado");
            }
            catch(IOException)
            {
                System.Console.WriteLine($"O arquivo não pode ser aberto");
            }
        
        
        }
    }
}
