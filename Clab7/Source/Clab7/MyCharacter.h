#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "MyCharacter.generated.h"

UCLASS()
class CLAB7_API AMyCharacter : public ACharacter
{
	GENERATED_BODY()

public:

	AMyCharacter();

protected:

	virtual void SetupPlayerInputComponent(class UInputComponent* PlayerInputComponent) override;


	void MoveForward(float Value);
	void MoveRight(float Value);


	void Turn(float Value);
	void LookUp(float Value);

public:

	UPROPERTY(VisibleAnywhere)
	class USpringArmComponent* SpringArm;


	UPROPERTY(VisibleAnywhere)
	class UCameraComponent* Camera;
};