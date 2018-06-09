// This sketch uses the servo library to arm the Hacker X-5 Pro ESC.

#include <Servo.h> 
 
Servo motore1;
Servo motore2;
Servo motore3;
Servo motore4;
 
int arm = 1000;    // defines pulse width of 1000 us
int speedvalue;
int steady = 300;
int initiate = 0;
void throttleUp();
 
void tutti(int val){
  motore1.writeMicroseconds(val);
  motore2.writeMicroseconds(val);
  motore3.writeMicroseconds(val);
  motore4.writeMicroseconds(val);
}

void tutti2(){
  motore1.detach();
  motore2.detach();
  motore3.detach();
  motore4.detach();
}
 
void setup() 
{
  motore1.attach(9);   
  motore2.attach(11);  
  motore3.attach(3);  
  motore4.attach(10);
  tutti(arm);
 delay(3000);
 /*  Once armed the setup could also be used to specify the 
     run speed of the motor. The commented out lines provide 
     a 2 second delay between changes in speed.
  delay(2000);
  esc.writeMicroseconds(1200);
  delay(2000);
  esc.writeMicroseconds(1300);
  delay(2000);
  esc.writeMicroseconds(1400);
  delay(2000);
 */
 throttleUp();
} 

void loop() 
{
  
  
/*
  Calls a sub to throttle up motor from 0 rpm to a steady running value.
  The if statement is used to run the throttle up once.
*/ 
  if (initiate < 1){
    //throttleUp();
    initiate = 1;
  }
 
 /*
    You can then change the speed in the main loop by changing the pulse width.
    If nothing else is going on in the loop, a delay must be included otherwise
    the servo writeMicroseconds is called to fast and there is not the proper
    time delay between pulses (I think this is the case...need to check this 
    on a scope. The minimum delay is 15 ms. The lines below use a 1 second delay
    between speed settings. The loop also causes this to be run once
*/ 

  if (initiate < 2){
    for (int count = 0; count < 5; count++){
      speedvalue = speedvalue+50;
      tutti(speedvalue);
      delay(1000);
    }
    for (int count = 0; count < 12; count++){
      speedvalue = speedvalue-50;
      tutti(speedvalue);
      delay(1000);
    }
    initiate = 2;
  }
  if (initiate=2) {tutti(arm); initiate=2;}
  //if (initiate=3) {tutti(1500); initiate=4;}
  void tutti2();

}  
  
  
//**************************************************

void throttleUp(){
  speedvalue = arm;
  for (int count = 0; count < steady; count++){
    tutti(speedvalue);
    speedvalue = speedvalue + 1;
    delay(15);
  }delay(2000);}
   
