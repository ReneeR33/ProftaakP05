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

void WriteText(String string, int row, int column, int textSize) {
  char value[15];
  string.toCharArray(value, 15);
  myScreen.setTextSize(textSize);
  myScreen.text(value, column, row);
}

void Refresh() {
  myScreen.background(0, 0, 0);
}

//Screen layout/refresh
////////////////////////////
void ScreenBegin() {
  Refresh();
  myScreen.stroke(255, 255, 255); // outline the rectangle with a white line
  myScreen.rect(0, 20, myScreen.width(), 80); // draw a fat rectangle
}

// Main menu:
void ScreenMain() {
  Refresh();
  myScreen.stroke(255, 255, 255);
  WriteText("Fruit", 5, 0, 1);
  WriteText("Portion", 5, 115, 1);
  WriteText("Cut", 115, 140, 1);
  WriteText("Quit", 115, 0, 1);
  WriteText("Welcome", 50, 40, 2);
  myScreen.stroke(255, 238, 76);
  WriteText("Bob", 70, 70, 1);
}

// Cut screen:
void ScreenCut() {
  Refresh();
  myScreen.stroke(255, 255, 255);
  WriteText("Add", 5, 0, 1);
  WriteText("Clear", 5, 130, 1);
  WriteText("Cut", 115, 140, 1);
  WriteText("Quit", 115, 0, 1);
  WriteText("Cut", 50, 30, 2);
  myScreen.stroke(255, 238, 76);
  //WriteText("Fruit", 30, 90, 1);
  //WriteText("Fruit", 40, 90, 1);
  //WriteText("Fruit", 50, 90, 1);

}

void ScreenCutAdd() {
  Refresh();
  myScreen.stroke(255, 255, 255);
  WriteText("+", 5, 5, 2);
  WriteText("-", 5, 140, 2);
  WriteText("Next", 115, 135, 1);
  WriteText("Done", 115, 0, 1);
  WriteText("Cut", 50, 30, 2);
  WriteText("Strawberry", 50, 75, 1);
  myScreen.stroke(255, 238, 76);
  WriteText("X2", 60, 75, 2);
}
//////////////////////////
