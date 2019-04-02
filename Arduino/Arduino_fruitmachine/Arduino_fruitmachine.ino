String Message = "ADD_FINGERPRINT";
uint8_t ID = 2;
int disk = 1;
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
 
 delay(50);

}
