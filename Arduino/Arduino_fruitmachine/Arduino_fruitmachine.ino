#include <EVShield.h>

uint8_t ID = 2;
#define buttonPin1 7
#define buttonPin2 8

EVShield  evshield(0x34, 0x36);

String Message = "";
int button1Value;
int button2Value;
unsigned long endTimeMotor;
unsigned long endTimeFingerprint = 0;
int nextDisk = 2;

void setup() {
  Serial.begin(9600);
  StartFingerprintscanner();
  evshield.init( SH_HardwareI2C );
  evshield.bank_a.motorReset();
  evshield.bank_b.motorReset();
  evshield.bank_a.motorRunDegrees(SH_Motor_2,
                                    SH_Direction_Forward,
                                    100,
                                    200,
                                    SH_Completion_Wait_For,
                                    SH_Next_Action_BrakeHold);
}

void loop() {
  button1Value = digitalRead(buttonPin1);
  button2Value = digitalRead(buttonPin2);
  String message = CheckMessage();
  UseMessage(message);

  if (message.startsWith("ADD_FINGERPRINT:") !=  true && millis() > endTimeFingerprint) {
    ReadFingerprint();
    endTimeFingerprint = millis() + 50;
  }

  if(button1Value == HIGH){
    SwitchDisk(nextDisk);
  }

  if(button2Value == HIGH){
    SwitchWeightMotorOn();
  }
  
  WeigthMotorMove();
  
  
  
}
