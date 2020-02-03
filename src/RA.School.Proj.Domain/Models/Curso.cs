using System;
using System.Collections.Generic;
using System.Text;

namespace RA.School.Proj.Domain.Models
{
    public class Curso : Entity
    {

        public string Nome { get; set; }
        


        /*EF RELATION 1 Aluno - N Cursos*/
        public IEnumerable<Aluno> Alunos { get; set; }
    }
}
