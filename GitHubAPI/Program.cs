using GitHubAPI.Service;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>

    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "GitHub API",
        Description = "An ASP.NET Core Web API to consume the GitHub API",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Contact-me on Linkedin ",
            Url = new Uri("https://www.linkedin.com/in/aldeir-maciel/")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }


    }));

builder.Services.AddHttpClient<GitHubApiService>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapControllers();

app.Run();


public partial class Program { }

