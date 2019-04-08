#include <Adafruit_Fingerprint.h>

SoftwareSerial mySerial(2, 4);
Adafruit_Fingerprint finger = Adafruit_Fingerprint(&mySerial);

bool addedFingerprint = false;
void StartFingerprintscanner() {
  
  while (!Serial); 
  delay(100);
 
  finger.begin(57600);

  Serial.println("Waiting for valid finger...");
}

int ReadFingerprint() {
  uint8_t p = finger.getImage();
    if (p != FINGERPRINT_OK)  return -1;

    p = finger.image2Tz();
    if (p != FINGERPRINT_OK)  return -1;

    p = finger.fingerFastSearch();
    if (p != FINGERPRINT_OK)  return -1;

    // found a match!
    Serial.print("|Fingerprint_Detected:");
    Serial.print(finger.fingerID);
    Serial.print("&");
    return finger.fingerID;
    
}

uint8_t AddFingerprint(uint8_t id) {
  int p = -1;
  Serial.print("Waiting for valid finger to enroll as #"); Serial.println(id);
  while (p != FINGERPRINT_OK) {
    p = finger.getImage();
    if(p == FINGERPRINT_OK){
      Serial.println("Image taken");
    }
    
  }

  // OK success!

  p = finger.image2Tz(1);
  if(p != FINGERPRINT_OK){
    return p;
  }
  else{
     Serial.println("Image converted");
  }
  

  Serial.println("Remove finger");
  delay(2000);
  p = 0;
  while (p != FINGERPRINT_NOFINGER) {
    p = finger.getImage();
  }
  Serial.print("ID "); Serial.println(id);
  p = -1;
  Serial.println("Place same finger again");
  while (p != FINGERPRINT_OK) {
    p = finger.getImage();
    if(p == FINGERPRINT_OK){
      Serial.println("Image taken");
    }
  }

  // OK success!

  p = finger.image2Tz(2);
  if(p != FINGERPRINT_OK){
    return p;
  }
  else{
     Serial.println("Image converted");
  }

  // OK converted!
  Serial.print("Creating model for #");  Serial.println(id);

  p = finger.createModel();
  if(p != FINGERPRINT_OK){
    return p;
  }
  else{
    Serial.println("Prints matched!");
  }
  

  Serial.print("ID "); Serial.println(id);
  p = finger.storeModel(id);
  if (p == FINGERPRINT_OK) {
    Serial.println("Stored!");
  }
  else{
    return p; 
  }
}
