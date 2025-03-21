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
    "Bad Girls don't get cuddles ~ Steph",
    "If we win this one, we win! ~ Karina",
    "I talk when I play with my friends - Candi",
    "Salt life is life - Dawn",
    "Damn Turtles!! ~ Rikki",
    "I like men ~ Porky",
    "You little rat ~Karina",
    "Ick ~Candi",
    "Ick ~Karina", 
    "FINISH HIM ~Zachypoo   I will ~Candi",
    "Meow ~Dobbie",
    "Meow ~Sirius",
    "I hope you shit your pants ~Porky   Name the time and place ~Caleb",
    "I love Pico Park ~Porky",
    "I love Pico Park 2 ~Porky"
};

app.MapGet("/Quotes", () =>
{
    Random random = new Random();
        string randomItem = Quotes.ElementAt(random.Next(Quotes.Length));
        
    return randomItem;
})
.WithName("Quotes");

app.Run();


