var builder = WebApplication.CreateBuilder(args);

// Ajouter les services dans le conteneur

var app = builder.Build();

// Configuration des requêtes HTTP pour la pipeline

app.Run();
