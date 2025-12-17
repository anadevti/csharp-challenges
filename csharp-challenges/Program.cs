using csharp_challenges.Lambda_Function;

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


var challenge = new EasyLevelChallengeLambdas();
// lambda function tests
challenge.LambdaChallengeNumbers();
challenge.LambdaChallengeNamesList();
challenge.LambdaChallengeWordsList();
challenge.LambdaChallengeAgeList();

var challenge2 = new IntermediateLevelChallenge();
// lambda function tests intermediate
challenge2.GetProductsElectronics();

app.UseHttpsRedirection();

app.Run();