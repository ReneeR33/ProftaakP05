bool messageWrite = false;
String message = "";

String CheckMessage()
{
  String messageDone = "";
  while (Serial.available() > 0)
  {
    char incomingByte = (char) Serial.read();
    if (incomingByte == '|')
    {
      messageWrite = true;
      incomingByte = "";
    }
    else if (incomingByte == '&')
    {
      messageDone = message;
      message = "";
      messageWrite = false;
      break;
    }
    else if (messageWrite == true)
    {
      message = message + incomingByte;
    }
  }
  return messageDone;
}

void UseMessage(String messageDone) {
 
 
  
  if (messageDone.startsWith("SWITCH_DISK:")) {
    messageDone.remove(0, 12);
    SwitchDisk(messageDone.toInt());
  }
  else if (messageDone == "CUT_START") {
    SwitchWeightMotorOn();
  }
  else if (messageDone == "CUT_STOP") {
    weigthDirection = false;
  }
  else if (messageDone.startsWith("ADD_FINGERPRINT:")) {
    Serial.print("Enrolling ID #");
    messageDone.remove(0, 16);
    //Serial.println(ID);
    AddFingerprint(messageDone.toInt());
  }

}
