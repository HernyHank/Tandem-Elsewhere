using UnrealBuildTool;

public class Tandem_ElsewhereEditorTarget : TargetRules
{
	public Tandem_ElsewhereEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Tandem_Elsewhere");
	}
}
