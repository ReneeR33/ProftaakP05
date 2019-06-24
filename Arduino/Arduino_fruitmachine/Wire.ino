void SendToSlave(String message) {
  
  if (message.length() > 20) {
    return;
  }
  char messageChar[20];
  message.toCharArray(messageChar, 20);
  Wire.beginTransmission(9);
  for (int i = 0; i < message.length(); i++) {
    Wire.write(messageChar[i]);
  }
  Wire.endTransmission();
}
