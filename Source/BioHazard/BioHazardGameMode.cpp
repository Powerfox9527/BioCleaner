// Copyright Epic Games, Inc. All Rights Reserved.

#include "BioHazardGameMode.h"
#include "BioHazardCharacter.h"
#include "UObject/ConstructorHelpers.h"

ABioHazardGameMode::ABioHazardGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPerson/Blueprints/BP_FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

}
