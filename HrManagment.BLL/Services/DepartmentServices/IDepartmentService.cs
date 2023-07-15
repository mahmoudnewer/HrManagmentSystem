﻿using HrManagment.DAL.Models;

namespace HrManagment.BLL.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAsync();
        Task insertAsync(Department department);
        Task updateAsync(Department department);
         Task DeleteAsync(int  departmentId);
        public  Task<string>GetDeptName(int departmentId);
        public Task<Department> GetByIdAsync(int departmentId);

    }
}
