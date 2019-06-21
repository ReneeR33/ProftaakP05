String currentFruit;
String fruitToCut[6];
int amount = 1;

void AddFruit(){
  for(int i = 0; i < 6; i++){
    if(fruitToCut[i] == ""){
      fruitToCut[i] = currentFruit + ":" + String(amount);
    }
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
