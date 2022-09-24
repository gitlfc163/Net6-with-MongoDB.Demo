
using Microsoft.Extensions.Options;
using Net6.with.MongoDB.Demo.Models;
using Net6.with.MongoDB.Demo.Services;

var builder = WebApplication.CreateBuilder(args);

// AutoMapper Settings
builder.Services.AddAutoMapper(typeof(MappingConfigs));

var appSetting = new AppSetting();
builder.Configuration.GetSection("AppSetting").Bind(appSetting);

//��AppSettingʵ��ע�뵽����,�����ڹ��캯����ʹ��IOptionsSnapshot<AppSetting> options
builder.Services.Configure<AppSetting>(builder.Configuration.GetSection("AppSetting"));

// MongoDB Settings
builder.Services.Configure<AppSetting>(
    builder.Configuration.GetSection(nameof(AppSetting)));
builder.Services.AddSingleton<IAppSetting>(sp =>
    sp.GetRequiredService<IOptions<AppSetting>>().Value);

// Add services to the container.
builder.Services.AddSingleton<IBookService, BookService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
