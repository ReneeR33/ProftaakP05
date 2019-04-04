String Message = "ADD_FINGERPRINT";
uint8_t ID = 2;
int disk = 1;
unsigned long endTimeMotor;
bool motorStart = false;
bool motorRunning = false;
bool motorIsDown = false;

void setup() {
  Serial.begin(9600);
  StartFingerprintscanner();
}

void loop() {
  String message = CheckMessage();
  UseMessage(message);
  
  if (message != "ADD_FINGERPRINT") {
    ReadFingerprint();
  }
}
