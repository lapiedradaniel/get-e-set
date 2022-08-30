using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Mensalidade
    {
        string curso;
        double valor;
        int dia;
        double calcular;

        public void SetCurso(string curco)
        {
            this.curso = curco;
        }
        public string GetCurso()
        {
            return curso;
        }
        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public double GetValor()
        {
            return valor;
        }
        public void SetDia(int dia)
        {
            this.dia = dia;
        }
        public int GetDia()
        {
            return this.dia;
        }
        public double Calcular()
        {
            if (this.valor<=5)
            {
                return this.valor * 0.95;
            }
            else
            {
                if (this.dia>10)
                {
                    return this.valor * 1.02;
                }
                else
                {
                    return this.valor;
                }




            }
        }


    }
}
