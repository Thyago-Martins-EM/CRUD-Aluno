using NUnit.Framework;
using System;

namespace EM.Domain.Testes
{
    [TestFixture]
    public class DomainTests
    {
        Aluno aluno1 = new Aluno() { Matricula = 1, Nome = "Thyago", Sexo = 0, Nascimento = DateTime.Parse("30/09/1990"), CPF = "30494948086" };
        Aluno aluno2 = new Aluno() { Matricula = 1, Nome = "Thyago", Sexo = 0, Nascimento = DateTime.Parse("30/09/1990"), CPF = "30494948086" };
        Aluno aluno3 = new Aluno() { Matricula = 4, Nome = "Tiago", Sexo = 0, Nascimento = DateTime.Parse("30/09/1990"), CPF = "30494948086" };
        Aluno aluno4 = new Aluno() { Matricula = 3, Nome = "Tyago", Sexo = 0, Nascimento = DateTime.Parse("30/09/1990"), CPF = "30494948086" };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestaPropriedades()
        {
            Aluno aluno1 = new Aluno()
            {
                Matricula = 1,
                Nome = "Thyago",
                Sexo = 0,
                Nascimento = DateTime.Parse("30/09/1990"),
                CPF = "11111111111"
            };
        }

        [Test]
        public void ValidaCPF()
        {
            var resultado = DomainUtilitarios.ValidaCPF("30494948086");
            Assert.AreEqual(true, resultado);
        }

        [TestCase("12345678900", ExpectedResult = false, TestName = "CPF invalido")]
        [TestCase("12345", ExpectedResult = false, TestName = "CPF faltando digitos")]
        [TestCase("123456789000", ExpectedResult = false, TestName = "CPF com digitos a mais")]
        public bool InformaCpfInvalido(string cpf)
        {
            return DomainUtilitarios.ValidaCPF(cpf);
        }

        [Test]
        public void TestaMetodoEquals()
        {
            Assert.IsTrue(aluno1.Equals(aluno2), "Os dois alunos são os mesmos");
            Assert.IsFalse(aluno2.Equals(aluno3), "Os alunos são diferentes");
        }

        [Test]
        public void TestaMetodoGetHashCode()
        {
            Assert.AreEqual(aluno1.GetHashCode(), aluno2.GetHashCode(), "Testa o metodo GetHashCode da classe Aluno");
        }
    }
}