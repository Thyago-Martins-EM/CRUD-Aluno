﻿using System;
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
                _matricula = value != 0 ? value : throw new ArgumentNullException("O campo de matricula não pode está em branco ou ser 0");
            }
        }
        public string Nome 
        { 
            get => _nome;
            set 
            {
                _nome = value != "" ? value : throw new ArgumentNullException("O campo do nome não pode está em branco");
            } 
        }
        public string CPF
        {
            get => _cpf;
            set
            {
                _cpf = DomainUtilitarios.ValidaCPF(value) ? value : throw new ArgumentException("O CPF informado não é valido");
            }
        }
        public DateTime Nascimento { 
            get => _nascimento; 
            set 
            {
                _nascimento = DomainUtilitarios.ValidaNascimento(value) ? value : throw new ArgumentException("Data Informada Incorreta");
            } 
        }
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
            int hashCode = -1073629611;
            hashCode = hashCode * -1521134295 + Matricula.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CPF);
            hashCode = hashCode * -1521134295 + Nascimento.GetHashCode();
            hashCode = hashCode * -1521134295 + Sexo.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {

            string aluno = $"({this.Matricula},'{this.Nome}',{this.Sexo},'{this.Nascimento}','{this.CPF}')";
            return aluno;
        }

    }
}
