using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7_IMC
{
    public class IMC
    {
        public double Peso;

        public double Altura;

        public double CalcIMC()
        {
            return Peso / (Altura * Altura);
        }
        public string FaixasIMC()
        {
            var res = CalcIMC();
            if (res < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (res < 25) 
            {
                return "Peso ideal";
            }
            else if (res < 30)
            {
                return "Sobrepeso";
            }
            else if (res < 30)
            {
                return "Obesidade Grau I";
            }
            else if (res < 35)
            {
                return "Obesidade Grau II";
            }
            else 
            {
                return "Obesidade Grau III";
            }
        }
    }
}
