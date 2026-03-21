// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Clab7 : ModuleRules
{
	public Clab7(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Clab7",
			"Clab7/Variant_Platforming",
			"Clab7/Variant_Platforming/Animation",
			"Clab7/Variant_Combat",
			"Clab7/Variant_Combat/AI",
			"Clab7/Variant_Combat/Animation",
			"Clab7/Variant_Combat/Gameplay",
			"Clab7/Variant_Combat/Interfaces",
			"Clab7/Variant_Combat/UI",
			"Clab7/Variant_SideScrolling",
			"Clab7/Variant_SideScrolling/AI",
			"Clab7/Variant_SideScrolling/Gameplay",
			"Clab7/Variant_SideScrolling/Interfaces",
			"Clab7/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
