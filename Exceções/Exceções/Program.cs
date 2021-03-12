using System;
using System.IO;

namespace Exceções
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\file.zip");
                var content = streamReader.ReadToEnd();
                throw new Exception("OOPS");
            }catch(Exception e)
            {
                Console.WriteLine("Erro inesperado");
            }finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }
        }
    }
}
