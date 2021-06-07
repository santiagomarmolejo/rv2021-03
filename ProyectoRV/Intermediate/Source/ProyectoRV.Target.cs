using UnrealBuildTool;

public class ProyectoRVTarget : TargetRules
{
	public ProyectoRVTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProyectoRV");
	}
}
