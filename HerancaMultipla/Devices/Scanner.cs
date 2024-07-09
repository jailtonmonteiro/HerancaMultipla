using System;

namespace HerançaMultipla.Devices
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Scanner Processing: {document}");
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}