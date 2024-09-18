using BUS;
using BUS.interfaces;
using DAL;
using DAL.interfaces;
using DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddTransient<I_AccountRespository, AccountResponsitory>();
builder.Services.AddTransient<I_AccountBUS, AccountBUS>();
builder.Services.AddTransient<I_NVResponsitory, NVResponsitory>();
builder.Services.AddTransient<I_NVBUS, NVBUS>();
builder.Services.AddTransient<I_SPResponsitory, SPResponsitory>();
builder.Services.AddTransient<I_SPBUS, SPBUS>();
builder.Services.AddTransient<I_loaiSPResponsitory, loaiSPResponsitory>();
builder.Services.AddTransient<I_loaiSPBUS, loaiSPBUS>();
builder.Services.AddTransient<I_KHResponsitory, KHResponsitory>();
builder.Services.AddTransient<I_KHBUS, KHBUS>();
builder.Services.AddTransient<I_NCCResponsitory, NCCResponsitory>();
builder.Services.AddTransient<I_NCCBUS, NCCBUS>();
builder.Services.AddTransient<I_hdbResponsitory, hdbResponsitory>();
builder.Services.AddTransient<I_hdbBUS, hdbBUS>();
builder.Services.AddTransient<I_hdnResponsitory, hdnResponsitory>();
builder.Services.AddTransient<I_hdnBUS, hdnBUS>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
