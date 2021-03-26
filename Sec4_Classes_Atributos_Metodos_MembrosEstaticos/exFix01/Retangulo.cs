using System;

namespace exFix01
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area(){
            return Largura * Altura;
        }

        public double Perimetro(){
            return (Largura + Altura)*2.0;
        }

        public double Diagonal(){
            return Math.Sqrt(Math.Pow(Largura,2) + Math.Pow(Altura,2));
        }
    }
}