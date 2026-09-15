using UnrealBuildTool;

public class Tandem_Elsewhere : ModuleRules
{
	public Tandem_Elsewhere(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
