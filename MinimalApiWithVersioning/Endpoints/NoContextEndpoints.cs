namespace MinimalApiWithVersioning.Endpoints;

public static class NoContextEndpoints
{
	public static void MapNoContextEndpoints(this IEndpointRouteBuilder app)
	{
		app.MapGet("GetHelloWorld", () =>
		{
			return "Hello World";
		});

		app.MapGet("GetGoodByeWorld", () =>
		{
			return "Good Bye World";
		});
	}
}
