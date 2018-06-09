#include <Servo.h> 
#include <Wire.h>

const int MPU=0x68;  // I2C address of the MPU-6050
int16_t AcX,AcY,AcZ,Tmp,GyX,GyY,GyZ;

Servo motore1; // PIN 3
Servo motore2; // PIN 9
Servo motore3; // PIN 10
Servo motore4; // PIN 11

int attacca();                      // AZIONO I MOTORI
int stacca();                       // STACCO I MOTORI
void AttivaMotori();                // ACCENDO I MOTORI, SOLO IN SETUP!!
int CalcolaPIN4();                  // DA VALORI AI MOTORI PER SINISTRA/DESTRA
int CalcolaPIN5();

bool attaccato = 0;                 // 1= MOTORI ACCESI
bool AutoAtterraggioAttivo = 0;     // 1= AUTO ATTERRAGGIO ATTIVO

int AutoAtterraggio(); // FUNZIONE PER FARLO ATTERRARE DA SOLO

int gas = 0; // VARIABILE GLOBALE

// VALORI DA PASSARE AI MOTORI
volatile int valore1;
volatile int valore2;
volatile int valore3;
volatile int valore4;

// VARIABILI PER DETERMINARE VALORI
volatile float temp1;
volatile float temp2;
volatile float temp3;
volatile float temp4;

const int pin2 = 2;     // LEVETTA SX SU/GIU      GAS
const int pin4 = 4;     // LEVETTA DX SX/DX
const int pin5 = 5;     // LEVETTA DX SU/GIU
const int pin6 = 6;     // LEVETTA SX SX/DX
const int modalita = 7; // MODALITA (0 / 1 / 2)

/********** MODALITA **********
 * numero | valore | descrizione
 *   0       1880~   Auto atterraggio
 *   1       1585~   Volo normale
 *   2       1090~   [NON ANCORA FATTA]
 ********** MODALITA **********/

// LETTURA RICEVENTE
// VEDI  pin2, pin4, pin5, pin6, modalita
volatile unsigned long results_2;
volatile unsigned long results_4;
volatile unsigned long results_5;
volatile unsigned long results_6;
volatile unsigned long results_7;

void setup() {
  pinMode(pin2, INPUT);
  pinMode(pin4, INPUT);
  pinMode(pin5, INPUT);
  pinMode(pin6, INPUT);
  pinMode(modalita, INPUT);
  
  Serial.begin(9600);
  
  //AttivaMotori();
}

int stacca()
{
  attaccato = 0;
  motore1.detach();
  motore2.detach();
  //motore3.detach();
  motore4.detach();
}

int attacca()
{
  attaccato = 1;
  motore1.attach(3);
  motore2.attach(9);
  //motore3.attach(10);
  motore4.attach(11);
}

void AttivaMotori()
{
  int pos;
  // MOTORE 1
  motore1.attach(3);
  for(pos = 0; pos < 60; pos += 1)
  {
    motore1.write(pos);
    delay(15);
  }
  for(pos = 60; pos>=1; pos-=1)
  {
    motore1.write(pos);
    delay(15);
  }
  motore1.detach();
  // MOTORE 2
  motore2.attach(9);
  for(pos = 0; pos < 60; pos += 1)
  {
    motore2.write(pos);
    delay(15);
  }
  for(pos = 60; pos>=1; pos-=1)
  {
    motore2.write(pos);
    delay(15);
  }
  motore2.detach();
  // MOTORE 3
  //motore3.attach(10);
  for(pos = 0; pos < 60; pos += 1)
  {
    //motore3.write(pos);
    delay(15);
  }
  for(pos = 60; pos>=1; pos-=1)
  {
    //motore3.write(pos);
    delay(15);
  }
  //motore3.detach();
  // MOTORE 4
  motore4.attach(11);
  for(pos = 0; pos < 60; pos += 1)
  {
    motore4.write(pos);
    delay(15);
  }
  for(pos = 60; pos>=1; pos-=1)
  {
    motore4.write(pos);
    delay(15);
  }
  motore4.detach();
}

int AutoAtterraggio()
{
  AutoAtterraggioAttivo = 1;
  for (int i = gas; i <= gas; i--)
  {
    
  }
}

int CalcolaPIN4()
{
  if (results_4 < 1500)
  {
    temp1 = temp1 * ((-0.05*results_4-325.9)/(-402));
    temp2 = temp2;
    temp3 = temp3;
    temp4 = temp4 * ((-0.05*results_4-325.9)/(-402));
  } else if (results_4 > 1530)
  {
    temp1 = temp1;
    temp2 = temp2 * ((-0.05*results_4+468.1)/392);
    temp3 = temp3 * ((-0.05*results_4+468.1)/392);
    temp4 = temp4;
  }
}

int CalcolaPIN5()
{
  if (results_5 < 1500)
  {
    temp1 = temp1;
    temp2 = temp2 * ((-0.05*results_5-325.9)/(-402));
    temp3 = temp3;
    temp4 = temp4 * ((-0.05*results_5-325.9)/(-402));
  } else if (results_5 > 1530)
  {
    temp1 = temp1 * ((-0.05*results_5+479.1)/403);
    temp2 = temp2;
    temp3 = temp3 * ((-0.05*results_5+479.1)/403);
    temp4 = temp4;
  }
}

void loop() {
  // CALCOLI PER GIROSCOPIO
  Wire.beginTransmission(MPU);
  Wire.write(0x3B);  // starting with register 0x3B (ACCEL_XOUT_H)
  Wire.endTransmission(false);
  Wire.requestFrom(MPU,14,true);  // request a total of 14 registers
  AcX=Wire.read()<<8|Wire.read();  // 0x3B (ACCEL_XOUT_H) & 0x3C (ACCEL_XOUT_L)     
  AcY=Wire.read()<<8|Wire.read();  // 0x3D (ACCEL_YOUT_H) & 0x3E (ACCEL_YOUT_L)
  AcZ=Wire.read()<<8|Wire.read();  // 0x3F (ACCEL_ZOUT_H) & 0x40 (ACCEL_ZOUT_L)
  Tmp=Wire.read()<<8|Wire.read();  // 0x41 (TEMP_OUT_H) & 0x42 (TEMP_OUT_L)
  GyX=Wire.read()<<8|Wire.read();  // 0x43 (GYRO_XOUT_H) & 0x44 (GYRO_XOUT_L)
  GyY=Wire.read()<<8|Wire.read();  // 0x45 (GYRO_YOUT_H) & 0x46 (GYRO_YOUT_L)
  GyZ=Wire.read()<<8|Wire.read();  // 0x47 (GYRO_ZOUT_H) & 0x48 (GYRO_ZOUT_L)

  // LEGGO DALLA RICEVENTE
  //results_2 = pulseIn(pin2,HIGH,25000);
  results_2 = pulseIn(pin2,HIGH);
  results_4 = pulseIn(pin4,HIGH);
  results_5 = pulseIn(pin5,HIGH);
  results_6 = pulseIn(pin6,HIGH);
  results_7 = pulseIn(modalita,HIGH);
  
  // converto e ottengo il valore del "gas"
  gas = 0;
  gas = map(results_2, 1000, 1900, 0, 1000);

  // DO "GAS" AI MOTORI
  temp1 = gas;
  temp2 = gas;
  temp3 = gas;
  temp4 = gas;
  
  //calcolo valori singoli motori per potermi spostare con l'analogico di destra
  CalcolaPIN4();
  CalcolaPIN5();
  
  //float temp1 = gas * ((-0.05 * results_5 + 481)/405) * ((-0.05*results_4-325.9)/(-402)) ;
  //valore1 = map(temp1, 0, 1000, 50, 100);
  
  // permetto di armare/disarmare
  if (results_6 > 1800) 
  {
    attacca(); // ATTIVO I MOTORI
  } else if (results_6 < 1400)
  {
    stacca(); // DISATTIVO I MOTORI
  }
  
  if (results_7 > 1700) 
  {
    AutoAtterraggio();
  }

  valore1 = map(temp1, 0, 1000, 50, 100);
  valore2 = map(temp2, 0, 1000, 50, 100);
  valore3 = map(temp3, 0, 1000, 50, 100);
  valore4 = map(temp4, 0, 1000, 50, 100);
  // se sono armato aziono i motori
  if (attaccato)
  {
    //motore1.write(valore1);
    //motore2.write(valore2);
    //motore3.write(valore3);
    //motore4.write(valore4);
  }

  
  //Serial.println(valore1);
  //Serial.println(attaccato);
  Serial.println("----");
  //Serial.println(results_2);
  //Serial.println(results_4);
  //Serial.println(results_5);
  //Serial.println(gas, DEC);
  Serial.println((temp1/gas), DEC);
  Serial.println((temp2/gas), DEC);
  Serial.println((temp3/gas), DEC);
  Serial.println((temp4/gas), DEC);
  //Serial.println(valore1, DEC);
  //Serial.println(results_6);
  //Serial.println(results_7);
  delay(1000);
  delay(10);
}


