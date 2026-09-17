using UnrealBuildTool;

public class Tandem_ElsewhereClientTarget : TargetRules
{
	public Tandem_ElsewhereClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Tandem_Elsewhere");
	}
}
