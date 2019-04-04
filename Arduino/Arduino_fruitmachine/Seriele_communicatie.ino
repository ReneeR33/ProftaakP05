bool messageWrite = false;
String message = "";

String CheckMessage()
{
  String messageDone = "";
  if (Serial.available() > 0)
  {
    char incomingByte = (char) Serial.read();
    if (incomingByte == '|')
    {
      messageWrite = true;
      incomingByte = "";
    }
    else if (incomingByte == '~')
    {
      messageDone = message;
      message = "";
      messageWrite = false;
    }
    else if (messageWrite == true)
    {
      message = message + incomingByte;
    }
  }
  return messageDone;
}

void UseMessage(String messageDone) {
 
 
  if (messageDone == "ADD_FINGERPRINT") {
    Serial.print("Enrolling ID #");
    Serial.println(ID);
    AddFingerprint(ID);
  }
  else if (messageDone.startsWith("SWITCH_DISK:")) {
    SwitchDisk(disk);
  }
  else if (Message == "CUT_START") {
    weigthMotorOn = true;
  }
  else if (Message == "CUT_STOP") {
    weigthDirection = false;
  }

}
