using CarBook.BusinessLayer.Abstract;
using CarBook.BusinessLayer.Concrete;
using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.EntityFramework;
using CarBook.EntityLayer.Concrete;
using CarBook.PresentationLayer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CarBookContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<CarBookContext>().AddErrorDescriber<CustomIdentityValidator>();

builder.Services.AddScoped<IBrandDAL, EFBrandDAL>();
builder.Services.AddScoped<IBrandService, BrandManager>();

builder.Services.AddScoped<IStatusDAL, EFStatusDAL>();
builder.Services.AddScoped<IStatusService, StatusManager>();

builder.Services.AddScoped<ICarDAL, EFCarDAL>();
builder.Services.AddScoped<ICarService, CarManager>();

builder.Services.AddScoped<IPriceDAL, EFPriceDAL>();
builder.Services.AddScoped<IPriceService, PriceManager>();

builder.Services.AddScoped<IServiceDAL, EFServiceDAL>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

builder.Services.AddScoped<IHowItWorksStepDAL, EFHowItWorksStepDAL>();
builder.Services.AddScoped<IHowItWorksStepService, HowItWorksStepManager>();

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();