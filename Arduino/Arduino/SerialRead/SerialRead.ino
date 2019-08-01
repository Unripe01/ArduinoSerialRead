#define OUT_PIN 13
#define SWITCH_PIN 12

void setup() {
  //シリアルポート読み込み開始
  Serial.begin(9600);
  // initialize digital pin LED_BUILTIN as an output.
  pinMode(OUT_PIN, OUTPUT);
  pinMode(SWITCH_PIN, INPUT_PULLUP);
}

// the loop function runs over and over again forever
void loop() {

  if (Serial.available() > 0) {
    char inChar = Serial.read();
    switch (inChar) {
      case 'h':
        digitalWrite(OUT_PIN, HIGH);
        break;
      case 'l':
        digitalWrite(OUT_PIN, LOW);
        break;
      default:
        digitalWrite(OUT_PIN, LOW);
        break;
    }
  }
  
  //スイッチが押されたらオフる
  if (digitalRead(SWITCH_PIN) == LOW)
  {
    digitalWrite(OUT_PIN, LOW);
  }
  
}
