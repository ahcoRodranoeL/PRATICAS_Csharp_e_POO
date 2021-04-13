namespace exFix04
{
    public class ConversorDeMoeda
    {
        public static double Iof = 6.00;

        public static double TotalEmReais(double cotacaoDolar, double compraDolares){
            return (compraDolares *(Iof/100) + compraDolares) * cotacaoDolar; 
        }
    }
}