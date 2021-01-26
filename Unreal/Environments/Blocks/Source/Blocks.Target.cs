// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BlocksTarget : TargetRules
{
	public BlocksTarget(TargetInfo Target) : base(Target)
	{
		System.Console.WriteLine("bDebugBuildsActuallyUseDebugCRT " + bDebugBuildsActuallyUseDebugCRT);
		this.bDebugBuildsActuallyUseDebugCRT = true;
		System.Console.WriteLine("bDebugBuildsActuallyUseDebugCRT " + bDebugBuildsActuallyUseDebugCRT);
		Type = TargetType.Game;
		ExtraModuleNames.AddRange(new string[] { "Blocks" });

		//bUseUnityBuild = false;
		if (Target.Platform == UnrealTargetPlatform.Linux)
			bUsePCHFiles = false;
	}
}
