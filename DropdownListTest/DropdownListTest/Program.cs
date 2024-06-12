using DropdownListTest.Data;
using DropdownListTest.EntityClasses;
using DropdownListTest.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IDatahelper<Book>, BookEntity>();
builder.Services.AddSingleton<IDatahelper<Author>, AuthorEntity>();
builder.Services.AddSingleton<IDatahelper<AuthorPost>, AuthorPostEntity>();



builder.Services.AddMvc(x => x.EnableEndpointRouting = false) ;
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
