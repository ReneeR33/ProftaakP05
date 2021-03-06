#include <EVShield.h>

EVShield  evshield(0x34, 0x36);

String Message = "ADD_FINGERPRINT";
uint8_t ID = 2;
int disk = 1;
unsigned long endTimeMotor;
unsigned long endTimeFingerprint = 0;
bool motorStart = false;
bool motorRunning = false;
bool motorIsDown = false;

void setup() {
  Serial.begin(9600);
  StartFingerprintscanner();
  evshield.init( SH_HardwareI2C );
  evshield.bank_a.motorReset();
  evshield.bank_b.motorReset();
}

void loop() {
  String message = CheckMessage();
  UseMessage(message);
  WeigthMotorMove();
  
  if (message != "ADD_FINGERPRINT" && millis() > endTimeFingerprint) {
    ReadFingerprint();
    endTimeFingerprint = millis() + 50;
  }
  
}
