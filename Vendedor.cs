namespace TRABALHOANDER{

    public class Vendedor:Funcionario{
        public Vendedor(){

        }
        public Vendedor(string cpf, string nome, string rg, string dataNascimento, Endereco endereco, double salario): base(cpf, nome, rg, dataNascimento, endereco, salario){   
        }
        public void CalculaSalarioVendedor(){
            base.GetSalario();
            SetSalario(GetSalario() * 1.2);
        }
    }
}