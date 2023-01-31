using API_150122.Contexts;
using API_150122.Repositories;
using API_150122.Services;

using MediatR;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

using System.Text;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

//configure services

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IBusinessDBContext, BusinessDBContext>();
builder.Services.AddMediatR(typeof(Program));

builder.Services.AddDbContext<BusinessDBContext>(opt => { opt.UseSqlServer(configuration.GetConnectionString("SQLConn")); });

var validIssuer = configuration.GetSection("JWT").GetSection("Issuer").Value;
var validAudience = configuration.GetSection("JWT").GetSection("Audience").Value;

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer("JWTBearer",opt =>
{
    opt.TokenValidationParameters = new TokenValidationParameters()
    {
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("JWT").GetSection("SecretKey").Value)),
        ValidateIssuer = true,
        ValidIssuer = validIssuer,
        ValidateAudience = true,
        ValidAudience = validAudience
    };
});

var app = builder.Build();

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