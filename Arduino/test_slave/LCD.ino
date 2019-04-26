#include <TFT.h>
#include <SPI.h>

#define CS   10
#define DC   9
#define RESET  8

TFT myScreen = TFT(CS, DC, RESET);

int previousSize;
int previousRow;
int previousSpace;
char printout[5];
char previous[5];

unsigned long LCDEndTime;

void StartScreen() {
  myScreen.begin();
  myScreen.background(0, 0, 0);
  myScreen.setTextSize(3);
  myScreen.stroke(255, 255, 255);
}

void WriteDynamicText(String string, int row, int space, int textSize) {
  if (millis() > LCDEndTime) {
    LCDEndTime = millis() + 1000;
    string.toCharArray(printout, 5);
    if (previous[0] != NULL) {
      myScreen.stroke(0, 0, 0);
      myScreen.setTextSize(previousSize);
      myScreen.text(previous, previousSpace, previousRow);
    }
    myScreen.stroke(255, 255, 255);
    myScreen.setTextSize(textSize);
    myScreen.text(printout, space, row);
    int i;
    for (i = 4; i >= 0; i -= 1) {
      previous[i] = printout[i];
    }
    previousSize = textSize;
    previousRow = row;
  }

}

void WriteText(String string, int row, int space, int textSize) {
  char value[15];
  string.toCharArray(value, 15);
  myScreen.stroke(255, 255, 255);
  myScreen.setTextSize(textSize);
  myScreen.text(value, space, row);
}

void Refresh() {
  myScreen.background(0, 0, 0);
}

void ScreenBegin(){
  myScreen.stroke(255,255,255); // outline the rectangle with a white line
  myScreen.rect(0,20,myScreen.width(),80); // draw a fat rectangle
}
