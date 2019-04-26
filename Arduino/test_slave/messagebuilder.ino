bool messageWrite = false;
String message = "";

String CheckMessage()
{
  String messageDone = "";
  while (Wire.available() > 0)
  {
    char incomingByte = (char) Wire.read();
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
