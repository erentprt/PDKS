using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Departments.Queries.GetById;

public class GetByIdDepartmentQuery:IRequest<GetByIdDepartmentResponse>
{
    public int Id { get; set; }

    public GetByIdDepartmentQuery()
    {
    }

    public GetByIdDepartmentQuery(int id)
    {
        Id = id;
    }


    public class GetByIdDepartmentResponseHandler:IRequestHandler<GetByIdDepartmentQuery,GetByIdDepartmentResponse>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;


        public GetByIdDepartmentResponseHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdDepartmentResponse> Handle(GetByIdDepartmentQuery request, CancellationToken cancellationToken)
        {
            Department? department = await _departmentRepository.GetAsync(x => x.Id == request.Id);
            GetByIdDepartmentResponse response = _mapper.Map<GetByIdDepartmentResponse>(department);
            return response;
        }
    }
    
}