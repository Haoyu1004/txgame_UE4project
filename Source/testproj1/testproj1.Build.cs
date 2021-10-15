// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class testproj1 : ModuleRules
{
    public testproj1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
