
using System.Diagnostics;

Activity.DefaultIdFormat = ActivityIdFormat.W3C; // Trace Id (ma liste) -> Span Id standaryzuje jak
// ma wygladac ten id w jakim standardzie 
Activity.ForceDefaultIdFormat = true; //wymusza format W3C i nadpisuje deafulta wczenisjenszego

var builder = WebApplication.CreateBuilder(args); 

//RossmannService konfiguracja danych np jaki deparatmeny itp 

//builder.UseRossmannLogging() ...
//openTelemetry dodanie logow itp 

//builder.Services
//    .AddControllers()
//    .AddEndpointsApiExplorer()
//    .AddSwaggerGen();
 
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
