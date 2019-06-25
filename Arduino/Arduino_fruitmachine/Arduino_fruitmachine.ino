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
#define buttonPin3 12
#define buttonPin4 10
#define ledPin 0

EVShield  evshield(0x34, 0x36);

String Message = "";
String screen = "START";
int button1Value;
int button2Value;
int button3Value;
int button4Value;
unsigned long endTimeMotor;
unsigned long endTimeFingerprint = 0;
int nextDisk = 2;
bool fingerprintDetected = false;

//interface
String currentFruit;
String fruitToCut[6];
int amount = 1;


void setup() {
  pinMode(buttonPin1, INPUT);
  pinMode(buttonPin2, INPUT);
  pinMode(buttonPin3, INPUT);
  pinMode(buttonPin4, INPUT);
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
  StartFingerprintscanner();
  Wire.begin();
  //evshield.init( SH_HardwareI2C );
  //evshield.bank_a.motorReset();
  //evshield.bank_b.motorReset();

}

void loop() {
  button1Value = digitalRead(buttonPin1);
  button2Value = digitalRead(buttonPin2);
  button3Value = digitalRead(buttonPin3);
  button4Value = digitalRead(buttonPin4);
  String message = CheckMessage();
  UseMessage(message);
  ReadFingerprint();

  if (message.startsWith("ADD_FINGERPRINT:") !=  false && millis() > endTimeFingerprint) {
    if (ReadFingerprint() != -1) {
      fingerprintDetected = true;
      Serial.println("true");
    }

    endTimeFingerprint = millis() + 50;
  }

  if (button1Value == HIGH || button2Value == HIGH || button3Value == HIGH || button4Value == HIGH) {
    //Wire.beginTransmission(9);
    if (button1Value == HIGH) {
      if (screen == "CUT") {
        //Wire.write("|SCREEN:CUT_ADD&");
        SendToSlave("|SCREEN:CUT_ADD&");
        screen = "CUT_ADD";
      }
      else if(screen == "CUT_ADD"){
        AddAmount();
        String message = "|FRUIT_AMOUNT:" + String(amount) + "&";
        SendToSlave(message);
      }

    }
    else if (button2Value == HIGH) {
      if(screen == "CUT_ADD"){
        RetractAmount();
        String message = "|FRUIT_AMOUNT:" + String(amount) + "&";
        SendToSlave(message);
      }
    }
    else if (button3Value == HIGH) {
      if (screen == "CUT") {
        //Wire.write("|SCREEN:MAIN&");
        SendToSlave("|SCREEN:MAIN&");
        screen = "MAIN";
      }
      else if(screen == "CUT_ADD"){
        //Wire.write("|SCREEN:CUT&");
        SendToSlave("|SCREEN:CUT&");
        screen = "CUT";
      }
    }
    else if (button4Value == HIGH) {
      if (screen == "MAIN") {
        //Wire.write("|SCREEN:CUT&");
        SendToSlave("|SCREEN:CUT&");
        screen = "CUT";
      }
    }
    //Wire.endTransmission();
    delay(300);
  }


  if (fingerprintDetected && message.startsWith("FINGERPRINT:")) {
    screen = "MAIN";
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
