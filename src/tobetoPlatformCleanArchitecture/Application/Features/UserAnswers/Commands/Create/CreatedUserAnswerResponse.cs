using Core.Application.Responses;
using Core.Security.Entities;
using Domain.Entities;

namespace Application.Features.UserAnswers.Commands.Create;

public class CreatedUserAnswerResponse : IResponse
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public Guid ChoiceId { get; set; }
    public Guid QuestionId { get; set; }
    public string AnswerText { get; set; }
   
}