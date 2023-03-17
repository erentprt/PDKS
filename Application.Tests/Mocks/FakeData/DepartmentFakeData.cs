using Core.Test.Application.FakeData;
using Domain.Entities;

namespace Application.Tests.Mocks.FakeData;

public class DepartmentFakeData : BaseFakeData<Department>
{
    public override List<Department> CreateFakeData()
    {
        var data = new List<Department>()
        {
            new(1, "IT", "Information Technology"),
            new(2, "HR", "Human Resources"),
        };
        return data;
    }
}
