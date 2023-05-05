using ArtsofteBasic.Domain;
using ArtsofteBasic.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArtsofteBasic.Logic.Queries;

public class GetDepartmentQuery : IRequest<Department>
{
    public Guid Id { get; init; }
}

public class GetDepartmentQueryHandler : IRequestHandler<GetDepartmentQuery, Department>
{
    private readonly IArtsofteContext _dbContext;
    
    public GetDepartmentQueryHandler(IArtsofteContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Department> Handle(GetDepartmentQuery request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Departments.FirstOrDefaultAsync(department => department.Id == request.Id, cancellationToken);

        if (entity == null)
        {
            throw new Exception($"Department not found {request.Id}");
        }
            
        return entity; 
    } 
}

