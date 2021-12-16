using System;
using System.Diagnostics;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Process.GetProcessesByName("sdk-desktop").Length > 0)
            {
                Process.GetProcessesByName("sdk-desktop")[0].Kill();
                Console.WriteLine("Processo Fechado Com sucesso ");
                if (Environment.Is64BitOperatingSystem == true)
                {
                    Process.Start(@"\Program Files (x86)\e-Sec\SDK-Desktop\sdk-desktop.exe");
                    Console.WriteLine("Processo Aberto Com Sucesso (X64)");
                }
                else
                {
                    Process.Start(@"\Program Files\e-Sec\SDK-Desktop\sdk-desktop.exe");
                    Console.WriteLine("Processo Aberto Com Sucesso (X32)");
                }
               
            }
            else {
                Console.WriteLine("Processo Não Encontrado ");
                if (Environment.Is64BitOperatingSystem == true)
                {
                    Process.Start(@"\Program Files (x86)\e-Sec\SDK-Desktop\sdk-desktop.exe");
                    Console.WriteLine("Processo Aberto Com Sucesso (X64)");
                }
                else
                {
                    Process.Start(@"\Program Files\e-Sec\SDK-Desktop\sdk-desktop.exe");
                    Console.WriteLine("Processo Aberto Com Sucesso (X32)");
                }
            }
            
        }
    }
}
