﻿using System;
using System.Collections.Generic;

namespace EM.Domain
{
    public class Aluno : IEntidade
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
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
