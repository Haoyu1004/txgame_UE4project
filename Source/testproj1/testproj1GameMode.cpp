// Copyright Epic Games, Inc. All Rights Reserved.

#include "testproj1GameMode.h"
#include "testproj1Ball.h"

Atestproj1GameMode::Atestproj1GameMode()
{
	// set default pawn class to our ball
	DefaultPawnClass = Atestproj1Ball::StaticClass();
}
