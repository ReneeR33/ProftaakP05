void setup() {
  Serial.begin(9600);
  StartFingerprintscanner();
}

void loop() {
  String Message = CheckMessage();
  ReadFingerprint();
  delay(50);

}
