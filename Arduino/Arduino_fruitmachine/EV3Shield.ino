#include <Wire.h>
#include <EVShield.h>

unsigned long endTimeMotor1;
unsigned long endTimeMotor2;

bool weigthMotorOn = false; //true = motor voor gewicht aan, false = uit
bool weigthDirection = true; //true = naar beneden, false = naar boven
int weigthElevation = 30; //30 = boven, 0 = beneden

EVShield          evshield(0x34, 0x36);
int currentDisk = 1;

void RunMotor1Left()
{
  evshield.bank_b.motorRunDegrees(SH_Motor_1,
                                  SH_Direction_Forward,
                                  8,
                                  120 * 5,
                                  SH_Completion_Wait_For,
                                  SH_Next_Action_BrakeHold);
}

void RunMotor1Right()
{
  evshield.bank_b.motorRunDegrees(SH_Motor_1,
                                  SH_Direction_Reverse,
                                  8,
                                  120 * 5,
                                  SH_Completion_Wait_For,
                                  SH_Next_Action_BrakeHold);
}

void RunMotor2Down()
{
  evshield.bank_b.motorRunRotations(SH_Motor_2,
                                    SH_Direction_Forward,
                                    100,
                                    1,
                                    SH_Completion_Wait_For,
                                    SH_Next_Action_BrakeHold);
  weigthElevation--;
  if (weigthElevation <= 0)
  {
    weigthDirection = false;
  }
}

void RunMotor2Up()
{
  evshield.bank_b.motorRunRotations(SH_Motor_2,
                                    SH_Direction_Reverse,
                                    100,
                                    1,
                                    SH_Completion_Wait_For,
                                    SH_Next_Action_BrakeHold);
  weigthElevation++;
  if (weigthElevation >= 30)
  {
    weigthDirection = true;
    weigthMotorOn = false;
  }
}

void WeigthMotorMove()
{
  if (weigthMotorOn)
  {
    switch (weigthDirection)
    {
      case true:
        RunMotor2Down();
        break;

      case false:
        RunMotor2Up();
        break;
    }
  }
}

void SwitchDisk(int disk) {
  if ((disk = currentDisk + 1 && disk != 3) || (disk == 1 && currentDisk == 3)) {
    //RunMotor1(120, 8);
  }
  else {
    //RunMotor1(240, 8);
  }
}
