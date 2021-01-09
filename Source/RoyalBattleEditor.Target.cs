// © Human Codeable. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RoyalBattleEditorTarget : TargetRules
{
	public RoyalBattleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "RoyalBattle" } );
	}
}
