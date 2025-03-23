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
    "Porksicle ~Queen",
    "Hahahahaha snorts ~Rikki",
    "Gluck Gluck MF Gluck Gluck ~Rikki"
};

app.MapGet("/Quotes", () =>
{
    Random random = new Random();
        string randomItem = Lines.ElementAt(random.Next(Lines.Length));
        
    return randomItem;
})
.WithName("Quotes");


var Lines = new[]
{
    "I was feeling off today, but you just totally turned me on",
" If I buy you dinner, will you be dessert?",
"If I was a judge, I’d sentence you to my bed.",
"I’m adding you to my to-do list. Can I check you off tonight?",
"Are you undressing me with your eyes?!",
"Nice pants. Can I talk you out of them?",
"It feels like it’s going to be one of those nights where neither of us get any sleep.",
"That body is yours for the rest of your life; I just want it for tonight.",
"Do you like bacon? Wanna strip?",
"I’ve been super on top of things lately. Would you like to be one of them?",
"I volunteer as your victim tonight since you're clearly dressed to kill.",
"Do you believe in karma? Because I know some good 'Karma' Sutra positions we can try.",
"Did you make your bed this morning? Wanna unmake it together?",
"I find your lack of nudity disturbing.",
"Is your car battery dead? Because I'd like to jump you right now.",
"You remind me of Disneyland because I want to ride you all day long.",
"Do you work at Dick’s? Because you’re sporting my favorite goods.",
"There’s a big sale at my house right now—clothes are 100 percent off. Wanna come?",
"What’s a nice person like you doing in a dirty mind like mine?",
"Your body is 60 percent water…and I’m thirsty.",
"Your bed or mine?",
"Do you like volcanoes? Because I might erupt later.",
"I put the std in stud and all i need is u.",
"Do you know the difference between a boner and a cheeseburger? You're not giving me a cheeseburger right now.",
"If I flip a coin, what are the chances of me getting head?"
};
app.MapGet("/Lines", () =>
{
    Random random = new Random();
        string randomItem = Lines.ElementAt(random.Next(Lines.Length));
        
    return randomItem;
})
.WithName("Lines");

app.Run();


