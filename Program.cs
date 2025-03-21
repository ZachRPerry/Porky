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



var Quotes = new[]
{
    "I'm NAAASSSTTTTYYYYY ~ Karina",
    "Bad Girls don't get cuddles ~ Step",
    "If we win this one, we win! ~ Karina",
    "I talk when I play with my friends - Candi",
    "Salt life is life - Dawn"
};

app.MapGet("/Quotes", () =>
{
    Random random = new Random();
        string randomItem = Quotes.ElementAt(random.Next(Quotes.Length));
        
    return randomItem;
})
.WithName("Quotes");

app.Run();


