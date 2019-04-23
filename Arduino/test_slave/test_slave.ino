#include <Wire.h>
String Message = "";
void setup() {
  Wire.begin(9); 
  Wire.onReceive(receive_event);
  StartScreen();
  Serial.begin(9600);
  Serial.println("start");
  ScreenBegin();
}

void receive_event(int bytes){
  Message = CheckMessage();
  Serial.println(Message);
  if(Message.startsWith("FINGERPRINT:")){
    WriteText("hallo", 30, 10, 3);
    Message.remove(0, 12);
    WriteText(Message, 60, 10, 3);
  }
}

void loop(){
  //nope
}
