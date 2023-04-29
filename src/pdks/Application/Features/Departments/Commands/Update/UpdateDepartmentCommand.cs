using Application.Features.Departments.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Departments.Commands.Update;

public class UpdateDepartmentCommand:IRequest<UpdatedDepartmentResponse>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    
    public class UpdateDepartmentCommandHandler:IRequestHandler<UpdateDepartmentCommand,UpdatedDepartmentResponse>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        private readonly DepartmentBusinessRules _departmentBusinessRules;

        public UpdateDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper, DepartmentBusinessRules departmentBusinessRules)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
            _departmentBusinessRules = departmentBusinessRules;
        }

        public async Task<UpdatedDepartmentResponse> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            Department? department = await _departmentRepository.GetAsync(x => x.Id == request.Id);
            _departmentBusinessRules.DepartmentIdShouldExistWhenSelected(department);

            _mapper.Map(request, department);
            await _departmentBusinessRules.DepartmentNameCanNotBeDuplicatedWhenUpdated(department);
            
            Department updatedDepartment = await _departmentRepository.UpdateAsync(department);
            UpdatedDepartmentResponse updatedDepartmentDto = _mapper.Map<UpdatedDepartmentResponse>(updatedDepartment);
            return updatedDepartmentDto;
        }
    }
}