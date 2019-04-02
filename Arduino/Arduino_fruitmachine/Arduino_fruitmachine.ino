String Message = "ADD_FINGERPRINT";
uint8_t ID = 2;
int disk = 1;
unsigned long endTimeMotor;
bool motorRunning = false;
bool motorIsDown = false;
bool startMotor = false;
bool stopMotor = false;
void setup() {
  Serial.begin(9600);
  StartFingerprintscanner();
}

void loop() {
  //String message = CheckMessage();
  if (Message != "ADD_FINGERPRINT") {
    ReadFingerprint();
  }
  else if (Message == "ADD_FINGERPRINT") {
    Serial.print("Enrolling ID #");
    Serial.println(ID);
    AddFingerprint(ID);
    Message = "";
  }
  else if (Message.startsWith("SWITCH_DISK:")){
    SwitchDisk(disk);
  }
  else if (Message == "CUT_START"){
    motorStart = true;
  }
  else if (Message == "CUT_STOP"){
    StopMotor = true;
  }

  if(motorStart && motorIsDown == false){
    RunMotor2(40, 8);
  }
  else if(motorStart && motorIsDown){
    RunMotor2(40, 8);
    //inverse!!!
  }
  
 
 delay(50);

}
