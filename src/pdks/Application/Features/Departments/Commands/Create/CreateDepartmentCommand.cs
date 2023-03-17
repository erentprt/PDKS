using Application.Features.Departments.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Departments.Commands.Create;

public class CreateDepartmentCommand:IRequest<CreatedDepartmentResponse>
{
    public string Name { get; set; }
    public string? Description { get; set; }
    
    
    public class CreateDepartmentCommandHandler:IRequestHandler<CreateDepartmentCommand,CreatedDepartmentResponse>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        private readonly DepartmentBusinessRules _departmentBusinessRules;


        public CreateDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper, DepartmentBusinessRules businessRules)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
            _departmentBusinessRules = businessRules;
        }

        public async Task<CreatedDepartmentResponse> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            await _departmentBusinessRules.DepartmentNameCanNotBeDuplicatedWhenInserted(request.Name);

            Department mappedDepartment = _mapper.Map<Department>(request);
            Department createdDepartment = await _departmentRepository.AddAsync(mappedDepartment);
            CreatedDepartmentResponse createdDepartmentDto = _mapper.Map<CreatedDepartmentResponse>(createdDepartment);
            return createdDepartmentDto;
        }
    }
}