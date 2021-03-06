using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string nome { get; set; }
        public string cpf { get; private set; }
        public double salario { get; protected set; }
        public static int TotaldeFuncionarios { get;  set; }
        public abstract void AumentarSalario();
        public abstract double getBonificacao();
        public string senha { get; set; }

        public Funcionario(string cpf, double salario)
        {
            cpf = cpf;
            salario = salario;
            TotaldeFuncionarios++;
        }

        public bool Autenticar(string senha)
        {
            return this.senha == senha;
        }

      

    }
}   


