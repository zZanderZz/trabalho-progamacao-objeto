namespace TRABALHOANDER
{
   
    public class Funcionario:DadosEssenciais
    {
       
        private double salario;
        public Funcionario(){
        }


        public Funcionario(string cpf, string nome, string rg, string dataNascimento, Endereco endereco, double salario): base(){
        }
        public double GetSalario(){
            return salario;
        }
        public void SetSalario(double salario){
            this.salario = salario;
        }
        public void DadosSalario(){
            Console.WriteLine("Digite seu salario: ");
            salario = double.Parse(Console.ReadLine());
       
       }
    }
}

    
