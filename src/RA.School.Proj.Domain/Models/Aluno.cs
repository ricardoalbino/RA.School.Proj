using System;
using System.Collections.Generic;
using System.Text;

namespace RA.School.Proj.Domain.Models
{
    public class Aluno : Entity
    {
        /*Chaves estrangeiras*/
        public Guid CursoId             { get; set; }
        public Guid UsuarioId           { get; set; }

        public string Nome              { get; set; }
        public string CPF               { get; set; }
        public string Email             { get; set; }
        public string Telefone          { get; set; }
        public char Sexo                { get; set; }
        public DateTime DataNascimento  { get; set; }

        /*EF RELATION 1 - 1*/
        public Curso Curso              { get; set; }
        public Usuario Usuario          { get; set; }



    }
}
