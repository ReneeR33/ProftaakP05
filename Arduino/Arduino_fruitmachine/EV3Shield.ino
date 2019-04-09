#include <Wire.h>
#include <EVShield.h>

unsigned long endTimeMotor1;
unsigned long endTimeMotor2;

bool weigthMotorOn = false; //true = motor voor gewicht aan, false = uit
bool weigthDirection = true; //true = naar beneden, false = naar boven
int weigthElevation = 20; //20 = boven, 0 = beneden

int currentDisk = 1;

void RunMotor1Left()
{
  evshield.bank_a.motorRunDegrees(SH_Motor_1,
                                  SH_Direction_Forward,
                                  40,
                                  120 * 5,
                                  SH_Completion_Wait_For,
                                  SH_Next_Action_BrakeHold);
}

void RunMotor1Right()
{
  evshield.bank_a.motorRunDegrees(SH_Motor_1,
                                  SH_Direction_Reverse,
                                  40,
                                  120 * 5,
                                  SH_Completion_Wait_For,
                                  SH_Next_Action_BrakeHold);
}

void RunMotor2Down()
{
  evshield.bank_a.motorRunRotations(SH_Motor_2,
                                    SH_Direction_Reverse,
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
  evshield.bank_a.motorRunDegrees(SH_Motor_2,
                                    SH_Direction_Forward,
                                    100,
                                    381,
                                    SH_Completion_Wait_For,
                                    SH_Next_Action_BrakeHold);
  weigthElevation++;
  if (weigthElevation >= 20)
  {
    weigthDirection = true;
    weigthMotorOn = false;
  }
}

void WeigthMotorMove()
{
  if (weigthMotorOn)
  {
    if(weigthDirection)
    {
      RunMotor2Down();
    }
    else
    {
      RunMotor2Up();
    }
    Serial.print(weigthDirection); Serial.print("\t");
    Serial.println(weigthElevation);
  }
}

void SwitchDisk(int disk) {
  if ((disk == currentDisk + 1) || (disk == 1 && currentDisk == 3)) {
    RunMotor1Left();
  }
  else if ((disk == currentDisk - 1) || (disk == 3 && currentDisk == 1)){
    RunMotor1Right();
  }
  else
  {
    Serial.println("Disk already Selected");
  }
  currentDisk = disk;
  if(currentDisk == 3){
    nextDisk = 1;
  }
  else{
    nextDisk = currentDisk + 1;
  }
  Serial.print("Next Disk: ");
  Serial.println(nextDisk);
}

void SwitchWeightMotorOn()
{
  weigthMotorOn = true;
}
