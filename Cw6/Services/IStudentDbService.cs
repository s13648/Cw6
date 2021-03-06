﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Cw6.Dto;

namespace Cw6.Services
{
    public interface IStudentDbService
    {
        public Task<IEnumerable<Student>> GetStudents();

        Task<bool> Exists(string indexNumber);
        
        Task Create(EnrollStudent model, SqlTransaction sqlTransaction, int idEnrollment);
        
        Task<Student> GetByIndex(string index);
    }
}
