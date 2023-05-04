using ArtsofteBasic.Domain;
using ArtsofteBasic.DTOs;

namespace ArtsofteBasic.Logic.Services
{
    public class EmployeeService 
    {
        public IQueryable<EmployeeDto> DomainToDtos(IQueryable<Employee> deps)
        {
            var dtos = deps.Select(employee => new EmployeeDto()
            {
                Id = employee.Id
            });
            return dtos;
        }

        public EmployeeDto DomainToDto(Employee employee)
        {
            return DomainToDtos(new[] { employee }.AsQueryable()).Single();
        }
    }
}
