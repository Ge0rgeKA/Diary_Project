using Diary_Project.PL.API.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                   .AddJwtBearer(options =>
                   {
                       options.RequireHttpsMetadata = false;
                       options.TokenValidationParameters = new TokenValidationParameters
                       {
                           // ��������, ����� �� �������������� �������� ��� ��������� ������
                           ValidateIssuer = true,
                           // ������, �������������� ��������
                           ValidIssuer = AuthOptions.ISSUER,

                           // ����� �� �������������� ����������� ������
                           ValidateAudience = true,
                           // ��������� ����������� ������
                           ValidAudience = AuthOptions.AUDIENCE,
                           // ����� �� �������������� ����� �������������
                           ValidateLifetime = true,

                           // ��������� ����� ������������
                           IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                           // ��������� ����� ������������
                           ValidateIssuerSigningKey = true,
                       };
                   });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
