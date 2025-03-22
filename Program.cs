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
    "I love Pico Park 2 ~Porky",
    "Never trust anything you read on the internet ~Abraham Lincoln",
    "Moist ~Keva",
    "I hope you stub your toe ~Porky", 
    "He's cheating!!! ~Karina",
    "What is wrong with you guys ~Porky",
    "It's so big ~Everyone who's dated v1",
    "The G-Spot exists ~Women's Magazines",
    "its key-vuh not kev-uh ~keva",
    "Red flags are hot ~Candi",
    "Stop fucking asking me to play COD ~Unknown",
    "If you say COD you will be BANNED ~Unknown",
    "It's me, I'm the problem ~Steph",
    "I'm on the pill its ok ~Women",
    "RAWR ~The Porkites",
    "It wasn't me ~OJ/Shaggy/Porky",
    "Got him right in the weiner ~Rikki",
    "I Just blew myself ~Karina",
    "I’ve been practicing like crazy and can now fit four adult farts in my mouth! ~Random",
    "Porksicle ~Queen"
};

app.MapGet("/Quotes", () =>
{
    Random random = new Random();
        string randomItem = Quotes.ElementAt(random.Next(Quotes.Length));
        
    return randomItem;
})
.WithName("Quotes");

app.Run();


