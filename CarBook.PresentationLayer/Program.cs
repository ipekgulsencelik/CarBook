using CarBook.BusinessLayer.Abstract;
using CarBook.BusinessLayer.Concrete;
using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.EntityFramework;
using CarBook.EntityLayer.Concrete;
using CarBook.PresentationLayer.Models;
using FluentValidation.AspNetCore;
using System.Text.Json.Serialization;

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

builder.Services.AddScoped<ICategoryDAL, EFCategoryDAL>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<ICarDetailDAL, EFCarDetailDAL>();
builder.Services.AddScoped<ICarDetailService, CarDetailManager>();

builder.Services.AddScoped<ICarFeatureDAL, EFCarFeatureDAL>();
builder.Services.AddScoped<ICarFeatureService, CarFeatureManager>();

builder.Services.AddScoped<ICommentDAL, EFCommentDAL>();
builder.Services.AddScoped<ICommentService, CommentManager>();

builder.Services.AddScoped<ITestimonialDAL, EFTestimonialDAL>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<IContactInfoDAL, EFContactInfoDAL>();
builder.Services.AddScoped<IContactInfoService, ContactInfoManager>();

builder.Services.AddScoped<IContactFormDAL, EFContactFormDAL>();
builder.Services.AddScoped<IContactFormService, ContactFormManager>();

builder.Services.AddScoped<ITeamDAL, EFTeamDAL>();
builder.Services.AddScoped<ITeamService, TeamManager>();

builder.Services.AddScoped<IAboutDAL, EFAboutDAL>();
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<IHistoryDAL, EFHistoryDAL>();
builder.Services.AddScoped<IHistoryService, HistoryManager>();

builder.Services.AddControllersWithViews().AddFluentValidation();

builder.Services.AddControllersWithViews().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

builder.Services.AddAutoMapper(typeof(Program));

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();