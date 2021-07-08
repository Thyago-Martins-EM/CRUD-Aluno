using System;
using System.Collections.Generic;

namespace EM.Domain
{
    public class Aluno : IEntidade
    {
        private int _matricula;
        private string _nome;
        private string _cpf;
        private DateTime _nascimento;

        public int Matricula {
            get => _matricula;
            set
            {                
                if (value != 0)
                {
                    _matricula = value;
                }
                else
                {
                    throw new Exception("O campo de matricula não pode está em branco");
                }
            }
        }
        public string Nome 
        { 
            get => _nome;
            set 
            {
                if (value != "") 
                {
                    _nome = value;
                }
                else
                {
                    throw new Exception("O campo do nome não pode está em branco");
                }
            } 
        }
        public string CPF
        {
            get => _cpf;
            set
            {
                //_cpf = DomainUtilitarios.ValidaCPF(cpf: value) ? value : throw new Exception("CPF não é valido");
                if (DomainUtilitarios.ValidaCPF(value))
                {
                    _cpf = value;
                }
                else
                {
                    throw new Exception("O CPF informado não é valido");
                }
            }
        }
        public DateTime Nascimento { get; set; }
        public EnumeradorSexo Sexo { get; set; }


        public override bool Equals(object obj)
        {
            return obj is Aluno aluno &&
                   Matricula == aluno.Matricula &&
                   Nome == aluno.Nome &&
                   CPF == aluno.CPF &&
                   Nascimento == aluno.Nascimento &&
                   EqualityComparer<EnumeradorSexo>.Default.Equals(Sexo, aluno.Sexo);
        }

        public override int GetHashCode()
        {
            int hashCode = 17;
            hashCode *= Matricula.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {

            string aluno = $"({this.Matricula},'{this.Nome}',{this.Sexo},'{this.Nascimento}','{this.CPF}')";
            return aluno;
        }

    }
}
