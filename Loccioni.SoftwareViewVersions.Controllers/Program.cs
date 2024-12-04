namespace Loccioni.SoftwareViewVersions.Controllers
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllers();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			builder.Services.AddCors(o =>
				o.AddDefaultPolicy(p => p
					.AllowAnyHeader()
					.AllowAnyMethod()
					.AllowAnyOrigin()
				));

			var app = builder.Build();

			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseAuthorization();
			app.UseCors();
			app.MapControllers();

			app.Run();
		}
	}
}