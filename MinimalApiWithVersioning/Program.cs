using Asp.Versioning;
using Asp.Versioning.Builder;
using MinimalApiWithVersioning.Configuration;
using MinimalApiWithVersioning.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddApiVersioning(options =>
{
	options.DefaultApiVersion = new ApiVersion(1);
	options.ApiVersionReader = new UrlSegmentApiVersionReader();
});

var app = builder.Build();

app.UseHttpsRedirection();
ApiVersionSet versionSet = VersionSetCreator.CreateVersionSet(app);
RouteGroupBuilder neutralRouteGroup = RouteGroupCreator.ContextNeutralRouteGroup(app);

neutralRouteGroup.MapNoContextEndpoints();

app.Run();
