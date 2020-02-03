using System;
using System.Collections.Generic;
using System.Text;

namespace RA.School.Proj.Domain.Models
{
    public class Endereco : Entity
    {
        public Guid AlunoId { get; set; }

        public string Lagradouro    { get; set; }
        public string Numero        { get; set; }
        public string Complemento   { get; set; }
        public string CEP           { get; set; }
        public string Bairro        { get; set; }
        public string Cidade        { get; set; }
        public string Estado        { get; set; }

        /*EF RELAÇÃO 1 - 1*/
        public Aluno Aluno { get; set; }

    }
}
