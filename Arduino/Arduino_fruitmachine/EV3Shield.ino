#include <Wire.h>
#include <EVShield.h>

EVShield          evshield(0x34, 0x36);
int currentDisk = 1;

void RunMotor1(int Degrees, int MotorSpeed){
   evshield.bank_b.motorRunDegrees(SH_Motor_1,
                                    SH_Direction_Forward,
                                    MotorSpeed,
                                    Degrees,
                                    SH_Completion_Wait_For,
                                    SH_Next_Action_BrakeHold);
}

void RunMotor2(int Rotations, int MotorSpeed){
  evshield.bank_b.motorRunRotations(SH_Motor_2,
                                    SH_Direction_Forward,
                                    MotorSpeed,
                                    Rotations,
                                    SH_Completion_Wait_For,
                                    SH_Next_Action_BrakeHold);
}

void SwitchDisk(int disk){
  if((disk = currentDisk + 1 && disk != 3) || (disk == 1 && currentDisk == 3)){
    RunMotor1(120, 8);
  }
  else{
    RunMotor1(240, 8);
  }
}
