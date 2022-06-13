using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio3
{
    internal class CuentaBancaria
    {
        private int NroCuenta { get; set; }
        private int NroCliente { get; set; }
        private string Moneda { get; set; }
        private decimal Saldo { get; set; }

        public CuentaBancaria(int unNroCuenta, int unNroCliente, string unaMoneda, decimal unSaldo)
        {
            NroCuenta = unNroCuenta;
            NroCliente = unNroCliente;
            Moneda = unaMoneda;
            Saldo = unSaldo;
        }

        public void Operacion(string operacion, decimal monto = 0)
        {
            switch (operacion)
            {
                case "Depositar":
                    Saldo= +monto;
                    break;

                case "Retirar":
                    if (this.Saldo < monto) Console.WriteLine("La cuenta no posee fondos suficientes para realizar la operación.");
                    else this.Saldo= -monto;
                    break;

                case "Informar":
                  Informar();
                    break;
               
                
            }
        }

        public void Informar()
        {
            Console.WriteLine("La cuenta bancaria tiene los siguientes datos:");
            Console.WriteLine($"Número de cuenta: {NroCuenta}");
            Console.WriteLine($"Número de Cliente {NroCliente}");
            Console.WriteLine($"Moneda: {Moneda}");
            Console.WriteLine($"Saldo Actual: {Saldo}");
        }
    }
}