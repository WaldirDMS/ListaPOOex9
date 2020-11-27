using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPOOex9
{
    class Comparador
    {
        private int valor1;
        private int valor2;
        private int maior;

        public void setValor1(int p)
        {
            valor1 = p;
        }

        public void setValor2(int p)
        {
            valor2 = p;
        }

        public int getMaior()
        {
            return maior;
        }

        public void CompararValores()
        {
            if(valor1==valor2)
            {
               Console.WriteLine("Os valoes são iguais");
            }

            else

                if (valor1 > valor2)
                {
                    maior = valor1;
                }

                else
                {
                     maior = valor2;
                }
        }
    }
}
