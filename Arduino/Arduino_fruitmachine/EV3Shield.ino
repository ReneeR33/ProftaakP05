#include <Wire.h>
#include <EVShield.h>

EVShield          evshield(0x34, 0x36);

void RunMotorA(int Degrees, int MotorSpeed){
   evshield.bank_b.motorRunDegrees(SH_Motor_1,
                                    SH_Direction_Forward,
                                    MotorSpeed,
                                    Degrees,
                                    SH_Completion_Wait_For,
                                    SH_Next_Action_BrakeHold);
}

void RunMotorB(int Rotations, int MotorSpeed){
  evshield.bank_b.motorRunRotations(SH_Motor_2,
                                    SH_Direction_Forward,
                                    MotorSpeed,
                                    Rotations,
                                    SH_Completion_Wait_For,
                                    SH_Next_Action_BrakeHold);
}
