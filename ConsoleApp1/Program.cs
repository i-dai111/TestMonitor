using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Assemblyからバージョン情報を取得
            var version = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

            Console.WriteLine($"アプリケーションのバージョン: {version}");
        }
    }

}
