namespace MinimalApiWithVersioning.Configuration;

public static class RouteGroupCreator
{
	public static RouteGroupBuilder ContextNeutralRouteGroup(WebApplication app) =>
		app.MapGroup("api/v{apiVersion:apiVersion}")
		    .WithApiVersionSet(VersionSetCreator.CreateVersionSet(app));
}
