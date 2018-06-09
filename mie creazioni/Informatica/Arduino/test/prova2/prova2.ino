const int pin1 = 4;
const int pin2 = 5;
const int pin3 = 6;
const int pin4 = 7;
const int pin  = A4;

volatile byte index =0;
volatile unsigned long results_1;
volatile unsigned long results_2;
volatile unsigned long results_3;
volatile unsigned long results_4;

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
results_1 = pulseIn(pin1,HIGH,25000);
results_2 = pulseIn(pin2,HIGH,25000);
results_3 = pulseIn(pin3,HIGH,25000);
results_4 = pulseIn(pin4,HIGH,25000);

//Serial.println(results_1);
//Serial.println(results_2);
//Serial.println(results_3);
//Serial.println(results_4);
Serial.println(val);
//Serial.println("________________________________________");
delay(100);
}
