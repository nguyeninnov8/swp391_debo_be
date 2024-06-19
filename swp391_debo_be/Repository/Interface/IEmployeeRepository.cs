﻿using swp391_debo_be.Dto.Implement;
using swp391_debo_be.Entity.Implement;

namespace swp391_debo_be.Repository.Interface
{
    public interface IEmployeeRepository
    {
        public List<User> GetDentistBasedOnTreamentId(int treatmentId);
        public Task<List<CreateEmployeeDto>> GetEmployeeWithBranch(int page, int limit);
        public Task<CreateEmployeeDto> GetEmployeeById(Guid id);
    }
}
