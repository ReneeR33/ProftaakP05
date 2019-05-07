//--FINGERPRINT--
//---------------
// BLACK - GND
// RED - 5V
// GREEN - 2
// WHITE - 4
//---------------
#include <EVShield.h>
#include <Wire.h>

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
bool fingerprintDetected = false;

void setup() {
  Serial.begin(9600);
  StartFingerprintscanner();
  Wire.begin();
  evshield.init( SH_HardwareI2C );
  evshield.bank_a.motorReset();
  evshield.bank_b.motorReset();

}

void loop() {
  //button1Value = digitalRead(buttonPin1);
  //button2Value = digitalRead(buttonPin2);
  String message = CheckMessage();
  UseMessage(message);

  if (message.startsWith("ADD_FINGERPRINT:") !=  true && millis() > endTimeFingerprint) {
    if (ReadFingerprint() != -1) {
      fingerprintDetected = true;
      Serial.println("true");
    }

    endTimeFingerprint = millis() + 50;
  }

  if (button1Value == HIGH) {
    SwitchDisk(nextDisk);
  }

  if (button2Value == HIGH) {
    SwitchWeightMotorOn();
  }

  if (fingerprintDetected && message.startsWith("FINGERPRINT:")) {
    char messageChar[20];
    message = "|" + message + "&";
    message.toCharArray(messageChar, 20);
    Wire.beginTransmission(9);
    for (int i = 0; i < 20; i++) {
      Wire.write(messageChar[i]);
    }
    Wire.endTransmission();
    Serial.println(messageChar);
    fingerprintDetected = false;
    Serial.println("false");
  }

}
