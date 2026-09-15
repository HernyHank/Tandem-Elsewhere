using UnrealBuildTool;

public class Tandem_ElsewhereServerTarget : TargetRules
{
	public Tandem_ElsewhereServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Tandem_Elsewhere");
	}
}
