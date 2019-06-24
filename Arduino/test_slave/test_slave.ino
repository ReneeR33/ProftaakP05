// --LCD--
//-----------
// 5V - 5V
// MISO - pin 12
// SCK - pin 13
// MOSI - pin 11
// LCD CS - pin 10
// SD CS - pin 4
// D/C - pin 9
// RESET - pin 8
// BL - 5V
// GND - GND
//-----------

// --MASTER--
//-------------
// pin A5 - pin A5
// pin A4 - pin A4
// GND - GND
// 5V - 5V
//-------------

#include <Wire.h>
String Message = "";

void setup() {
  Wire.begin(9);
  Wire.onReceive(receive_event);
  StartScreen();
  Serial.begin(9600);
  Serial.println("start");
  //ScreenBegin();
  ScreenMain();
}

void receive_event(int bytes) {
  Message = CheckMessage();
  //Serial.println(Message);
  if (Message.startsWith("FINGERPRINT:")) {
    WriteText("hallo", 30, 10, 3);
    Message.remove(0, 12);
    WriteText(Message, 60, 10, 3);
    delay(3000);
    Refresh();
    ScreenMain();
  }
  
  else if(Message == "SCREEN:MAIN"){
    ScreenMain();
    Serial.println("MAIN");
  }
  else if(Message == "SCREEN:CUT"){
    ScreenCut();
    Serial.println("CUT");
  }
  else if(Message == "SCREEN:CUT_ADD"){
    ScreenCutAdd();
    Serial.println("ADD");
  }
  else if(Message.startsWith("FRUIT_AMOUNT:")){
    Message.replace("FRUIT_AMOUNT:", "");
    Serial.println(Message);
    UpdateFruitAmount(Message);
  }
  
}

void loop() {
  //nope
}
