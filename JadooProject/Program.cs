using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Concrete;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Repositories;
using JadooProject.Features.CQRS.Handlers.BrandHandlers;
using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using JadooProject.Features.CQRS.Handlers.FetaureHandlers;
using JadooProject.Features.CQRS.Handlers.ManuelHandlers;
using JadooProject.Features.CQRS.Handlers.NewsLetterHandlers;
using JadooProject.Features.CQRS.Handlers.TestimonialHandlers;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Oluþturduðumuz ctorlarý burada geçmek zorundayýz

builder.Services.AddDbContext<JadooContext>();

builder.Services.AddScoped<GetDestinationByIdQueryHandler>();
builder.Services.AddScoped<GetDestinationQueryHandler>();
builder.Services.AddScoped<GetDestinationHomeQueryHandler>();
builder.Services.AddScoped<CreateDestinationCommandHandler>();
builder.Services.AddScoped<RemoveDestinationCommandHandler>();
builder.Services.AddScoped<JadooProject.Features.Mediator.Handlers.DestinationHandlers.GetDestinationByIdQueryHandler>();
builder.Services.AddScoped<UpdateDestinationCommandHandler>();
builder.Services.AddScoped<GetLastDestinationQueryHandler>();
//builder.Services.AddScoped<GetDestinationForDashboardQueryHandler>();

builder.Services.AddScoped<GetFeatureQueryHandler>();
builder.Services.AddScoped<GetFeatureByIdQueryHandler>();
builder.Services.AddScoped<UpdateFeatureCommandHandler>();
builder.Services.AddScoped<CreateFeatureCommandHanler>();
builder.Services.AddScoped<RemoveFeatureCommandHandler>();

builder.Services.AddScoped<GetManuelQueryHandler>();
builder.Services.AddScoped<CreateManuelCommandHandler>();
builder.Services.AddScoped<GetManuelByIdQueryHandler>();
builder.Services.AddScoped<UpdateManuelCommandHandler>();
builder.Services.AddScoped<RemoveManuelCommandHandler>();

builder.Services.AddScoped<GetTestimonialQueryHandler>();
builder.Services.AddScoped<CreateTestimonialCommandHandler>();
builder.Services.AddScoped<GetTestimonialByIdQueryHandler>();
builder.Services.AddScoped<UpdateTestimonialCommandHandler>();
builder.Services.AddScoped<GetTestimonialQueryHandler>();
builder.Services.AddScoped<RemoveTestimonialCommandHandler>();
//builder.Services.AddScoped<GetTestimonailForDashboradQueryHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

builder.Services.AddScoped<GetNewsLetterQueryHandle>();
builder.Services.AddScoped<UpdateNewsLetterCommandHandler>();
builder.Services.AddScoped<CreateNewsLetterCommandHandler>();
builder.Services.AddScoped<RemoveNewsLetterCommandHandler>();
builder.Services.AddScoped<GetNewsLetterByIdQueryHandle>();

builder.Services.AddScoped<ITestimonial, EfTestimonialDal>();
//builder.Services.AddScoped<GetDashboardStatisticQueryHandler>();


builder.Services.AddScoped<INewsLetterDal, EfNewsLetterDal>();
builder.Services.AddScoped<IDestinationDal, EfDestinationDal>();
builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<IBrandDal, EfBrandDal>();
builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();


builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
});





builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));  //her entity için interface ve sýnýf yazmak yerine bunu yazdýk  typeof diyerek yazdýðýmýz türün örneðini almasý gerektiðini söyledik
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
