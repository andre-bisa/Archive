#include <Servo.h>

Servo m1;

void setup() {                
   m1.attach(11);
   delay(1);
   m1.write(60);
}

void loop() {
  m1.write(55);
  
}
