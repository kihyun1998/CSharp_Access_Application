using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ForStartingApp
{
    class UsePassword
    {
        public static string _Path = @"C:\TEMP\Password.txt";

        // Modify와 같은 역할도 한다.
        public static void Save(PassworldTXT passworldTXT)
        {
            File.WriteAllText(_Path, passworldTXT._Passworld, Encoding.Default);
        }
    }
}
