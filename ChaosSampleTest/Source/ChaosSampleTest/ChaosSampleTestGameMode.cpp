// Copyright Epic Games, Inc. All Rights Reserved.

#include "ChaosSampleTestGameMode.h"
#include "ChaosSampleTestCharacter.h"
#include "UObject/ConstructorHelpers.h"

AChaosSampleTestGameMode::AChaosSampleTestGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
