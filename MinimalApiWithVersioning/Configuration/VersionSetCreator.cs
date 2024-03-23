using Asp.Versioning;
using Asp.Versioning.Builder;

namespace MinimalApiWithVersioning.Configuration;

public static class VersionSetCreator
{
	public static ApiVersionSet CreateVersionSet(WebApplication app) => 
		app.NewApiVersionSet()
			.HasApiVersion(new ApiVersion(1))
			 .ReportApiVersions()
			  .Build();
}
