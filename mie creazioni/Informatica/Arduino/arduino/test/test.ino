// This sketch uses the servo library to arm the Hacker X-5 Pro ESC.
// Once loaded this code will rearm the ESC after its power has been 
// turned off and on without being re-run. 
// What is going on????

#include <Servo.h> 
 
Servo myservo;
Servo myservo2;
Servo myservo3;
Servo myservo4;

int valore = 60;
// 51 MINIMO ASSOLUTO PER FARE GIRARE LE ELICHE!
// 60 BUON VALORE DI MINIMO!
 
void setup() 
{ 
  // NULLA PER ORA
} 

void loop() 
{
// ASSEGNO I PIN (ARMO)
myservo.attach(3);
myservo2.attach(9);
//myservo3.attach(10);
myservo4.attach(11); 
// DO UN VALORE!
myservo.write(valore);
myservo2.write(valore);
//myservo3.write(valore);
myservo4.write(valore);
delay(3000);
// TOLGO I PIN ASSEGNATI (DISARMO)
myservo.detach();
myservo2.detach();
//myservo3.detach();
myservo4.detach();
delay(3000);
} 
 
