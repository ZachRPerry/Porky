var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var rikkis = new[]
{
    "It has been 0 Games Since Rikki shot Karina!",
    "It has been 0 games since Rikki shot a teammate",
    "RAWRRR",
    "Have you ever had a hawaiian bowl? MMM [emote:3341441:porksliceRikki]"
};

app.MapGet("/Rikki", () =>
{
    Random random = new Random();
        string randomItem = rikkis.ElementAt(random.Next(rikkis.Length));
        
    return randomItem;
})
.WithName("Rikki");



var Karinas = new[]
{
    "I'm NAAASSSTTTTYYYYY",
    "Don't be a lil rat, $(randomuser)",
    "If we win this one, we win!",
    "@Karina7702's battery is currently on Rand[0,5]"
};

app.MapGet("/Karina", () =>
{
    Random random = new Random();
        string randomItem = Karinas.ElementAt(random.Next(Karinas.Length));
        
    return randomItem;
})
.WithName("Karina");

app.Run();


