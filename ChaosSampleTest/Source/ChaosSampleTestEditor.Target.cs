// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ChaosSampleTestEditorTarget : TargetRules
{
	public ChaosSampleTestEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("ChaosSampleTest");

        bCompileChaos = true;
        bUseChaos = true;
    }
}
