using System;

namespace EventDrivenProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente { Nome = "Samir Mourad", Idade = 32 };
            var conta = new ContaCorrente(cliente);

            conta.Notificar += NotificarEmail;
            conta.Notificar += GravarLog;
            conta.Notificar += EnviandoSMS;

            conta.Depositar(300.0M);
            conta.Depositar(1000.0M);
            conta.Sacar(100.00M);

            Console.ReadLine();
        }

        static void NotificarEmail(decimal valor)
        {
            Console.WriteLine($"E-mail enviado: Saque efetuado no valor de {valor}.");
        }

        static void GravarLog(decimal valor)
        {
            Console.WriteLine($"Gravando log: Saque efetuado no valor de {valor}.");
        }

        static void EnviandoSMS(decimal valor)
        {
            Console.WriteLine($"SMS para o número XXXX-XXXX: Saque efetuado no valor de {valor}.");
        }
    }
}
