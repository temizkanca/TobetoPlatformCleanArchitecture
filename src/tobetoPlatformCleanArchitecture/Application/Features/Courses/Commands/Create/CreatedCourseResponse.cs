using Core.Application.Responses;

namespace Application.Features.Courses.Commands.Create;

public class CreatedCourseResponse : IResponse
{
    public Guid Id { get; set; }
    public int TotalTime { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}