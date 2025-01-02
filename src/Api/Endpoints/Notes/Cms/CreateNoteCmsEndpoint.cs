using Application.Notes.Cms.Contracts.Requests;
using Application.Notes.Cms.Contracts.Responses;
using MediatR;
using FastEndpoints;
using Application.Notes.Cms.Commands;
namespace Api.Endpoints.Notes.Cms
{
    public sealed class CreateNoteCmsEndpoint : Endpoint<CreateNoteRequest, NoteCreatedResponse>
    {
        private readonly ISender _sender;

        public override void Configure()
        {
            Post("cms/notes");

            Description(b => b
                    .Accepts<CreateNoteRequest>("multipart/form-data")
                    .Produces<NoteCreatedResponse>(201, "application/json")
                    .Produces(401) // ale u mnie nie ma uprawenien na ta chwile ;p
                    .Produces(403) // jaka roznica 401 a 403 ? (niezalogowany albo brak uprawnein?)
                    .ProducesProblemDetails(500),
                clearDefaults: true); //usuwa ustawnienia domyslne wiec trzeba samemu dac kody bledow

            //jakas rola ? Roles ()
            AllowAnonymous();

            AllowFormData();
            Summary(s =>
            {
                s.Summary = "Create note.";
                s.Description = "Create note.";
            });
        }
        public override async Task HandleAsync(CreateNoteRequest req, CancellationToken ct)
        {
            var command = new CreateNoteCommand(req.userId ,req.TopicOfNote, req.Description,
                req.Status, req.Status?.DateTofinish);

            var result = await _sender.Send(command, ct); // wysyla komenede do odpowiedniego handlera Mediatr

            await SendCreatedAtAsync<CreateNoteCmsEndpoint>(result, result, cancellation: ct); //wysyla do uzytkownika kod bledu
            ///pierwszy argument to co zwrocone zostanie uzytkownikowi , drugi tez ?        
        }
    }
}
