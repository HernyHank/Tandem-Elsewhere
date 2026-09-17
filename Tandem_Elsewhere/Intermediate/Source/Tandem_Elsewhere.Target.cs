using UnrealBuildTool;

public class Tandem_ElsewhereTarget : TargetRules
{
	public Tandem_ElsewhereTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Tandem_Elsewhere");
	}
}
