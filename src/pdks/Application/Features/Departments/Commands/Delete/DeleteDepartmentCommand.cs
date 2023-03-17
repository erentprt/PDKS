using Application.Features.Departments.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Departments.Commands.Delete;

public class DeleteDepartmentCommand:IRequest<DeletedDepartmentsResponse>
{
    public int Id { get; set; }
    
    public class DeleteDepartmentCommandHandler:IRequestHandler<DeleteDepartmentCommand,DeletedDepartmentsResponse>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        private readonly DepartmentBusinessRules _departmentBusinessRules;


        public DeleteDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper, DepartmentBusinessRules departmentBusinessRules)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
            _departmentBusinessRules = departmentBusinessRules;
        }

        public async Task<DeletedDepartmentsResponse> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            await _departmentBusinessRules.DepartmentIdShouldExistWhenSelected(request.Id);
            Department mappedDepartment = _mapper.Map<Department>(request);
            Department deletedDepartment = await _departmentRepository.DeleteAsync(mappedDepartment);
            DeletedDepartmentsResponse deletedDepartmentDto = _mapper.Map<DeletedDepartmentsResponse>(deletedDepartment);
            return deletedDepartmentDto;
        }
    }
}