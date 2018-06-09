const int pin1 = 6;
const int pin2 = 4;
const int pin3 = 5;
const int pin4 = 6;
const int pin5  = 7;
const int pin = A0;

volatile byte index =0;
volatile unsigned long results_1;
volatile unsigned long results_2;
volatile unsigned long results_3;
volatile unsigned long results_4;
volatile unsigned long results_5;

void setup()
{
pinMode(pin1, INPUT);
pinMode(pin2, INPUT);
pinMode(pin3, INPUT);
pinMode(pin4, INPUT);
pinMode(pin, INPUT);

Serial.begin(9600);

}

void loop()
{
int val = 0;
val = analogRead(pin);
results_1 = pulseIn(pin1,HIGH);
results_2 = pulseIn(pin2,HIGH);
results_3 = pulseIn(pin3,HIGH);
results_4 = pulseIn(pin4,HIGH);
results_5 = pulseIn(pin5,HIGH);

if (results_1 >= 1520) 
Serial.println(results_1);
//Serial.println(results_2);
//Serial.println(results_3);
//Serial.println(results_4);
//Serial.println(results_5);
//Serial.println(val);
Serial.println("________________________________________");
delay(10);
}
