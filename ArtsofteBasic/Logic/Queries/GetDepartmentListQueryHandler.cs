using ArtsofteBasic.Domain;
using ArtsofteBasic.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArtsofteBasic.Logic.Queries;

public record GetDepartmentListQuery() : IRequest<IQueryable<Department>>;

public class GetDepartmentListQueryHandler : IRequestHandler<GetDepartmentListQuery, IQueryable<Department>>
{
    private readonly IArtsofteContext _dbContext;
    
    public GetDepartmentListQueryHandler(IArtsofteContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<IQueryable<Department>> Handle(GetDepartmentListQuery query, CancellationToken cancellationToken)
    {
        var list = _dbContext.Departments;
        
        return await Task.FromResult(list); 
    } 
}

