// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ChaosSampleTest : ModuleRules
{
	public ChaosSampleTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
