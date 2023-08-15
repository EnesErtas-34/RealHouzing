using Microsoft.Extensions.DependencyInjection;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.BusinessLayer.Concrete;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.Concrete;
using RealHouzing.DataAccessLayer.EntityFramework;
using RealHouzing.EntityLayer.Concrete;
using System.ComponentModel;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<ICategoryDal,EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IProductDal,EfProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();
builder.Services.AddScoped<IFeatureService, FeatureManager>();

builder.Services.AddScoped<IOurFieldDal, EfOurFieldDal>();
builder.Services.AddScoped<IOurFieldService, OurFieldManager>();

builder.Services.AddScoped<ISellRentDal, EfSellRentDal>();
builder.Services.AddScoped<ISellRentService, SellRentManager>();

builder.Services.AddScoped<IAboutUsVideoDal, EfAboutUsVideoDal>();
builder.Services.AddScoped<IAboutUsVideoService, AboutUsVideoManager>();

builder.Services.AddScoped<IPostPropertyDal, EfPostPropertyDal>();
builder.Services.AddScoped<IPostPropertyService, PostPropertyManager>();

builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<IBlogDal, EfBlogDal>();
builder.Services.AddScoped<IBlogService, BlogManager>();

builder.Services.AddScoped<ISubscribeDal,EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService,SubscribeManager>();

builder.Services.AddScoped<IAboutFeatureDal, EfAboutFeatureDal>();
builder.Services.AddScoped<IAboutFeatureService, AboutFeatureManager>();

builder.Services.AddScoped<ICoLivingDal, EfCoLivingDal>();
builder.Services.AddScoped<ICoLivingService, CoLivingManager>();

builder.Services.AddScoped<IProgressBarDal, EfProgressBarDal>();
builder.Services.AddScoped<IProgressBarService, ProgressBarManager>();

builder.Services.AddScoped<IMyTeamDal, EfMyTeamDal>();
builder.Services.AddScoped<IMyTeamService, MyTeamManager>();


builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IMessageDal, EfMessageDal>();
builder.Services.AddScoped<IMessageService, MessageManager>();

builder.Services.AddScoped<IServicesPostPropertyDal, EfServicesPostPropertyDal>();
builder.Services.AddScoped<IServicesPostPropertyService, ServicesPostPropertyManager>();

builder.Services.AddScoped<IExploreDal, EfExploreDal>();
builder.Services.AddScoped<IExploreService, ExploreManager>();

builder.Services.AddScoped<IServicesCategoriesDal, EfServicesCategoriesDal>();
builder.Services.AddScoped<IServicesCategoriesService, ServicesCategoriesManager>();



builder.Services.AddControllersWithViews()//aslýnda mappleme yapýyor
    .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
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
