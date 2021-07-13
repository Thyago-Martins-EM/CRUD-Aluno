using NUnit.Framework;
using System;

namespace EM.Repository.Testes
{
    public class TestesRepositorioAluno
    {

        [SetUp]
        public void Setup()
        {
        }

        Domain.Aluno aluno = new Domain.Aluno()
        {
            Matricula = 999999999,
            Nome = "Robson",
            Sexo = 0,
            Nascimento = DateTime.Parse("30/09/1990"),
            CPF = "26923309000",
        };

        [Test]
        public void TesteConexaoBanco()
        {
            //Assert.IsTrue(new Conexao().GetConexao());
        }

        [Test]
        public void TestaMetodoAdd()
        {

            new RepositorioAluno().Add(aluno);

            Assert.IsNotNull(new RepositorioAluno().GetByMatricula(999999999));
         
        }

        [Test]
        public void TestaMetodoUpdate()
        {
            aluno.Nome = "Marisa";
            aluno.Sexo = (Domain.EnumeradorSexo)1;

            new RepositorioAluno().Update(aluno);

            Assert.IsNotNull(new RepositorioAluno().GetByContendoNoNome("Mari"));
        }

        [Test]
        public void TestaMetodoGet()
        {
            Assert.IsNotNull(new RepositorioAluno().Get(al => al.Matricula == 999999999));
        }

        [Test]
        public void TestaMetodoGetByMatricula()
        {
            Domain.Aluno alunoGetByMatricula = new Domain.Aluno()
            {
                Matricula = 999999998,
                Nome = "Robson",
                Sexo = 0,
                Nascimento = new DateTime (30,09,1990),
                CPF = "26923309000",
            };
            new RepositorioAluno().Add(alunoGetByMatricula);

            Assert.IsNotNull(new RepositorioAluno().GetByMatricula(999999998));

            new RepositorioAluno().Remove(alunoGetByMatricula);
        }

        [Test]
        public void TestaMetodoGetByContendoNoNome()
        {

            Domain.Aluno GetByContendoNoNome = new Domain.Aluno()
            {
                Matricula = 999999997,
                Nome = "Jose Agusto",
                Sexo = 0,
                Nascimento = new DateTime(30, 09, 1990),
                CPF = "26923309000",
            };
            new RepositorioAluno().Add(GetByContendoNoNome);

            Assert.IsNotNull(new RepositorioAluno().GetByContendoNoNome("Agusto"));

            new RepositorioAluno().Remove(GetByContendoNoNome);
        }

        [Test]
        public void TestaMetodoRemove()
        {
            new RepositorioAluno().Remove(aluno);
            Assert.IsNull(new RepositorioAluno().GetByMatricula(999999999));
        }
    }
}