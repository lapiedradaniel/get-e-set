using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Aluno al = new Aluno();
            Mensalidade men = new Mensalidade();


            Console.WriteLine("Digite o nome : ");
            al.SetNome(Console.ReadLine());

            Console.WriteLine("Digite o endereco : ");
            al.SetEndereco(Console.ReadLine());
            Console.WriteLine("Digite o Cpf : ");
            al.SetCpf(Console.ReadLine());

            Console.WriteLine("Digite o RA : ");
            al.SetRa(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Digite o curso : ");
            men.SetCurso(Console.ReadLine());
            Console.WriteLine("Digite o valor : ");
            men.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite o dia do pagamento : ");
            men.SetDia(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Dados dos Alunos ");
            Console.WriteLine("RA:" + al.GetEndereco() + "CPF: " + al.GetCpf());
            Console.WriteLine("Curso: " + men.GetCurso() + "Valor da mensalidade: " + men.GetValor().ToString("C")
                + "Valor a pagar: " + men.Calcular().ToString("C"));






            Console.ReadKey();






        }
    }
}
