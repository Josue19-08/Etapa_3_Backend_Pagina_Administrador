Para crear la BD local:

En CMD:

		sqllocaldb
		sqllocaldb create "nonbreServer"


Luego en el el SSMS:
	
		(LOCALDB)\nombreServer o (localdb)\nombreServer

-------------------------------------------------------------------------

Administrar paquetes NuGet:

		DA =>	Microsoft.EntityFrameworkCore
		API =>	Microsoft.EntityFrameworkCore.SqlServer
		API =>  Microsoft.EntityFrameworkCore.Tools

-------------------------------------------------------------------------

Dependencias:

	BC = NADA
	BW = BC
	DA = BW
	SG = BC / BW
	API = BC / BW / DA / SG


--------------------------------------------------------------------------

En Program.cs:
	
 Importante tener
	builder.Services.AddHttpClient();
	
	//Inyección de dependencias
		builder.Services.AddTransient<IGestionarOrdenBW, GestionarOrdenesBW>();
		builder.Services.AddTransient<IGestionarOrdenDA, GestionarOrdenDA>();

		builder.Services.AddTransient<IGestionarClientesBW, GestionarClientesBW>();
		builder.Services.AddTransient<IGestionarClienteDA, GestionarClienteDA>();

		builder.Services.AddTransient<IGestionarRecetasBW, GestionarRecetasBW>();
		builder.Services.AddTransient<IGestionarRecetaDA, GestionarRecetaDA>();

		builder.Services.AddTransient<IGestionarRecetasBW, GestionarRecetasBW>();
		builder.Services.AddTransient<IGestionarRecetasSG, GestionarRecetaSG>();

			//Conexión a BD
		builder.Services.AddDbContext<RealizarOrdenContext>(options =>
		{
			// Usar la cadena de conexión desde la configuración
			var connectionString = "Server = (LocalDB)\\LocalServerJosue; Database = EaseOrder; Trusted_Connection =True;TrustServerCertificate=True;";
			options.UseSqlServer(connectionString);
			// Otros ajustes del contexto de base de datos pueden ser configurados aquí, si es necesario
		});

		var app = builder.Build();

		// Importante
		app.UseCors("AllowOrigin");
		app.UseCors(options =>
		{
			options.AllowAnyOrigin();
			options.AllowAnyMethod();
			options.AllowAnyHeader();
		});

		using (var scope = app.Services.CreateScope())
		{
			var context = scope.ServiceProvider.GetRequiredService<RealizarOrdenContext>();
			context.Database.Migrate();
		}






