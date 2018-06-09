// This sketch uses the servo library to arm the Hacker X-5 Pro ESC.
// Once loaded this code will rearm the ESC after its power has been 
// turned off and on without being re-run. 
// What is going on????

#include <Servo.h> 
 
Servo myservo;
 
int arm = 46;    // supplies a pulse width of approximately 1000 us
 
void setup() 
{ 
  myservo.attach(9);  
  //for (int count = 0; count < 10; count++){
    myservo.write(arm);              
  //}
} 

void loop() 
{

} 
 
