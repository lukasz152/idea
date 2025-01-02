
using Application;
using Core;
using FastEndpoints;
using System.Diagnostics;

Activity.DefaultIdFormat = ActivityIdFormat.W3C; // Trace Id (ma liste) -> Span Id standaryzuje jak
// ma wygladac ten id w jakim standardzie 
Activity.ForceDefaultIdFormat = true; //wymusza format W3C i nadpisuje deafulta wczenisjenszego

var builder = WebApplication.CreateBuilder(args);

//openTelemetry dodanie logow itp 

builder.Services
    .AddCore()
    .AddApplication()
    .AddControllers();

builder.Services
   .AddCore()
   .AddApplication();
//.AddInfrastructure(builder.Configuration);

builder.Services
    .AddFastEndpoints(options => options.IncludeAbstractValidators = true)
    .AddResponseCaching();
//Health?

builder.Services
    .AddHttpContextAccessor();
    //.AddAuthorization();
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
