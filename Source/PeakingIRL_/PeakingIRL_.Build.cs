// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PeakingIRL_ : ModuleRules
{
	public PeakingIRL_(ReadOnlyTargetRules Target) : base(Target)
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
			"PeakingIRL_",
			"PeakingIRL_/Variant_Horror",
			"PeakingIRL_/Variant_Horror/UI",
			"PeakingIRL_/Variant_Shooter",
			"PeakingIRL_/Variant_Shooter/AI",
			"PeakingIRL_/Variant_Shooter/UI",
			"PeakingIRL_/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
