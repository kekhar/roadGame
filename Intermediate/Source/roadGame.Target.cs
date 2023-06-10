using UnrealBuildTool;

public class roadGameTarget : TargetRules
{
	public roadGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("roadGame");
	}
}
