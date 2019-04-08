uint8_t ID = 2;

void setup() {
  Serial.begin(9600);
  StartFingerprintscanner();

}

void loop() {
  String message = CheckMessage();
  UseMessage(message);

  if (message != "ADD_FINGERPRINT") {
    ReadFingerprint();
    delay(50);
  }
  else{
    ReadFingerprint();
  }

}
