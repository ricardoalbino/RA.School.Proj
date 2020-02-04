using RA.School.Proj.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RA.School.Proj.Domain.Interfaces
{
   public  interface ICursoRepository : IRepository<Curso>
   {
        Task<Curso> ObterCursoPorAluno(int CPF);
        Task<Curso> ObterCursoPorProfesssor(int CPF);
    }
}
