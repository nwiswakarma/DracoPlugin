/*
 DracoPlugin 0.0.1
 -----
 
*/
using System.IO;
using System.Collections;
using UnrealBuildTool;

public class DracoPlugin: ModuleRules
{
    public DracoPlugin(ReadOnlyTargetRules Target) : base(Target)
	{
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        Definitions.AddRange(new string[] {
            "DRACO_MESH_COMPRESSION_SUPPORTED",
            "DRACO_STANDARD_EDGEBREAKER_SUPPORTED",
            "DRACO_PREDICTIVE_EDGEBREAKER_SUPPORTED"
        });

		PublicDependencyModuleNames.AddRange(
            new string[] {
                "Core",
                "CoreUObject",
                "Engine"
            });

		PrivateDependencyModuleNames.AddRange(new string[] { });

        string ThirdPartyPath = Path.Combine(ModuleDirectory, "../../ThirdParty");

        // -- Draco include and lib path

        string DracoPath = Path.Combine(ThirdPartyPath, "Draco");
        string DracoInclude = Path.Combine(DracoPath, "include");
        string DracoLib = Path.Combine(DracoPath, "lib");

		PublicIncludePaths.Add(Path.GetFullPath(DracoInclude));
        PublicLibraryPaths.Add(Path.GetFullPath(DracoLib));

        PublicAdditionalLibraries.Add("draco.lib");
	}
}
