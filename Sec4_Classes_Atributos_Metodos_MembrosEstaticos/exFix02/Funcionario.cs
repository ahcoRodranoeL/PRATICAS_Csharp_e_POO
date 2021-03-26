namespace exFix02
{
     class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }
        public void AumentoSalario(double porcentagem){
            SalarioBruto += SalarioBruto*(porcentagem/100);
        }
        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2");
        } 
    }
}