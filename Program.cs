using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtema_5
{
    
    internal class Program
    {
        static string nombreArchivo = "listaproductos.txt";
        static void Main(string[] args)
        {
            agregarnuevosproductos();
        }
        static void agregarnuevosproductos()
        {
            StreamWriter nuevodocumento = new StreamWriter(nombreArchivo,true);
            Console.Write("ingrese el nombre del producto a registarar: ");
            string producto = Console.ReadLine();
            nuevodocumento.WriteLine(producto);
            nuevodocumento.Close();

        }
    }
}
