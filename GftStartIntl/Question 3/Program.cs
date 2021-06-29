using System;
using System.Runtime.InteropServices;

namespace Question_3
{
    
    class Program
    {
        private static ICMS _icms = new ICMS();
        private static IPI _ipi = new IPI();
        private static COFINS _cofins = new COFINS();
        private static double _userNumber;
        static void Main(string[] args)
        {
            TakeUserInput();
            CalculateTaxes();
        }
        private static void TakeUserInput()
        {
            Console.WriteLine($"Digite o valor: ");
            _userNumber = Convert.ToDouble(Console.ReadLine());

        }
        private static void CalculateTaxes()
        {
            double Icms = _icms.CalculateTaxes(_userNumber);
            double Cofins = _cofins.CalculateTaxes(_userNumber) == _userNumber ? 0 : _cofins.CalculateTaxes(_userNumber);
            double Ipi = _ipi.CalculateTaxes(_userNumber);

            Console.WriteLine($"ICMS: {Icms} ");
            Console.WriteLine($"IPI: {Ipi} ");
            Console.WriteLine($"COFINS: {Cofins} ");
            Console.WriteLine($"Valor Final: {_userNumber+Icms+Ipi+Cofins}");
        }
    }
}
