using Application.Notes.Cms.Contracts.Requests;
using FluentValidation;

namespace Application.Notes.Cms.Contracts.Validators
{
    internal sealed class CreateNoteRequestValidator : AbstractValidator<CreateNoteRequest>
    {
        public CreateNoteRequestValidator()
        {
            RuleFor(request => request.TopicOfNote)
                .NotEmpty()
                .MinimumLength(1)
                .MaximumLength(200);

            RuleFor(request => request.Description)
                .NotEmpty()
                .MinimumLength(1)
                .MaximumLength(200);
        }
    }
}
