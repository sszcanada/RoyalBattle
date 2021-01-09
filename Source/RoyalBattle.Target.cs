// © Human Codeable. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RoyalBattleTarget : TargetRules
{
	public RoyalBattleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "RoyalBattle" } );
	}
}
