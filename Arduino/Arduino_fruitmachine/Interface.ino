int fruitIndex = 0;

void AddFruit(){
  if(fruitIndex != 6){
    fruitToCut[fruitIndex] = currentFruit + ":" + String(amount);
    fruitIndex++;
  }
}

int AddAmount(){
  if(amount != 6){
    amount++;
    return amount;
  }
}

int RetractAmount(){
  if(amount != 1){
    amount -= 1;
    return amount;
  }
}
