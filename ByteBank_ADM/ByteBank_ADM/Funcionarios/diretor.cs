﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class diretor:funcionario
    {
        public diretor(string cpf) : base(cpf, 5000)
        {
            
        }
        public override void AumentarSalario()
        {
            this.salario *= 1.15;
        }
        public override double getBonificacao()
        {
            return salario * 0.5;
        }
        
       
        
    }
}
    

