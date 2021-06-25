using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EM.Domain;

namespace EM.Repository
{
    public class RepositorioAluno : RepositorioAbstrato<Aluno>
    {
        public Aluno GetByMatricula(int matricula)
        {
            return;
        }

        public IEnumerable<Aluno> GetByContendoNoNome(string parteDoNome)
        {
            return ;
        }
    }
}
