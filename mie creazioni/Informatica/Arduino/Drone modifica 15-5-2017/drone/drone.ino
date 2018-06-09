#include <SPI.h>
#include <Servo.h> 
#include <Wire.h>

#define MOTORI 1
#define DEBUG 0

#include "costanti.h"
#include "motore.h"
#include "giroscopio.h"

#define DEBUG_DELAY_TIME 500

/********** MODALITA **********
 * numero | valore | descrizione
 *   0       1880~   Auto atterraggio
 *   1       1585~   Motori accesi
 *   2       1090~   Motori spenti
 ********** MODALITA **********/
// LETTURA RICEVENTE
// VEDI  pin2, pin4, pin5, pin6, modalita
unsigned long valorePin2;
unsigned long valorePin4;
unsigned long valorePin5;
unsigned long valorePin6;
unsigned long valorePin7;

// MOTORI
Motore motore1(3);
Motore motore2(9);
Motore motore3(10);
Motore motore4(11);

// GIROSCOPIO
double AcX,AcY,AcZ,Tmp,GyX,GyY,GyZ;

// PIN TELECOMANDO
const int pin2 = 2;     // LEVETTA SX SU/GIU      (GAS)
const int pin4 = 4;     // LEVETTA DX SX/DX
const int pin5 = 5;     // LEVETTA DX SU/GIU
const int pin6 = 6;     // LEVETTA SX SX/DX
const int modalita = 7; // MODALITA (0 / 1 / 2) (PIN)

// VARIABILI UTILI AL VOLO
int firstPitch;        // pitch di terra
int firstRoll;         // roll di terra
int pitchValue;        // valore di pitch
int rollValue;         // valore di rollaggio
int rollTarget;        // roll da raggiungere
int pitchTarget;       // pitch da raggiungere
int motoriAccesi;      // booleano per sapere se i motori sono attivi o meno
int manovraInCorso;    // booleano per sapere se sto facendo una manovra

// DEFINISCO FUNZIONI
int roll(double accX, double accY, double accZ);
int pitch(double accX, double accY, double accZ);
int funzionePitchRoll(double a, double b, double c);
void attivaMotori();
void resetMotori();
void attaccaMotori();
void staccaMotori();
void leggiRicevente();
void calcolaRollPitchTarget();
void calcolaPitchPin5();
void calcolaRollPin4();

// ************************************************************ INIZIO FUNZIONI ***********************************************************

void calcolaPitchPin5() {
  if (valorePin5 < MUOVI_AVANTI_INDIETRO_NORMALE * 0.95 
      || valorePin5 > MUOVI_AVANTI_INDIETRO_NORMALE * 1.05) {
    int deltaPitch = map(valorePin5, MUOVI_INDIETRO_MAX, MUOVI_AVANTI_MAX, 20, -20);
    pitchTarget += deltaPitch;
    manovraInCorso = 1;
  }
}

void calcolaRollPin4() {
  if (valorePin4 < MUOVI_DESTRA_SINISTRA_NORMALE * 0.95 
      || valorePin4 > MUOVI_DESTRA_SINISTRA_NORMALE * 1.05) {
    int deltaRoll = map(valorePin4, MUOVI_SINISTRA_MAX, MUOVI_DESTRA_MAX, 20, -20);
    rollTarget += deltaRoll;
    manovraInCorso = 1;
  }
}

void calcolaRollPitchTarget() {
  calcolaPitchPin5();
  calcolaRollPin4();
}

int funzionePitchRoll(double a, double b, double c) {
  double dato1, dato2, value;
  dato1 = a;
  dato2 = (b*b) + (c*c);
  dato2 = sqrt(dato2);
  value = atan2(dato1, dato2) * 180 / 3.1415;
  return (int)value;
}

int pitch(double accX, double accY, double accZ) {
  int pitch = funzionePitchRoll(AcY, AcX, AcZ);
  return pitch;
}

int roll(double accX, double accY, double accZ) {
  int roll = funzionePitchRoll(AcX, AcY, AcZ);
  return roll;
}

void leggiGiroscopio() {
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
}

void leggiRicevente() {
  valorePin2 = pulseIn(pin2,HIGH);
  valorePin4 = pulseIn(pin4,HIGH);
  valorePin5 = pulseIn(pin5,HIGH);
  valorePin6 = pulseIn(pin6,HIGH);
  valorePin7 = pulseIn(modalita,HIGH);
}

void resetMotori() {
  motore1.reset();
  motore2.reset();
  motore3.reset();
  motore4.reset();
}

void attivaMotori() {
  motore1.attiva();
  motore2.attiva();
  motore3.attiva();
  motore4.attiva();
}

void disattivaMotori() {
  motore1.disattiva();
  motore2.disattiva();
  motore3.disattiva();
  motore4.disattiva();
}

void attaccaMotori() {
  motore1.attacca();
  motore2.attacca();
  motore3.attacca();
  motore4.attacca();
}

void staccaMotori() {
  motore1.stacca();
  motore2.stacca();
  motore3.stacca();
  motore4.stacca();
}

// ************************************************************ SETUP E LOOP ***********************************************************

void setup() {
  pinMode(pin2, INPUT);
  pinMode(pin4, INPUT);
  pinMode(pin5, INPUT);
  pinMode(pin6, INPUT);
  pinMode(modalita, INPUT);
 
  #if DEBUG==1
    Serial.begin(9600);
  #endif;
  
  resetMotori();
  
  #if MOTORI==1
    attivaMotori();
  #endif;
  
  init_MPU();
  
  delay(500);
  
  // leggo dal giroscopio per settare i valori di default (da usare per correggere l'errore di posizionamento del sensore)
  leggiGiroscopio();
  
  firstPitch = pitch(AcX, AcY, AcZ);
  firstRoll = roll(AcX, AcY, AcZ);
  
  #if DEBUG==1
    Serial.print("Pitch iniziale: ");
    Serial.print(firstPitch, DEC);
    Serial.print("     ");
    Serial.print("Roll iniziale: ");
    Serial.println(firstRoll, DEC);
    delay(DEBUG_DELAY_TIME);
  #endif;
  
  motoriAccesi = 0;
  
}

void loop() {
  int gas = 0;
  int gasMotore1 = 0;
  int gasMotore2 = 0;
  int gasMotore3 = 0;
  int gasMotore4 = 0;
  
  manovraInCorso = 0;
  pitchTarget = 0;
  rollTarget = 0;
  
  // LEGGO GIROSCOPIO
  leggiGiroscopio();
  
  pitchValue = pitch(AcX, AcY, AcZ) - firstPitch;
  rollValue = roll(AcX, AcY, AcZ) - firstRoll;
  
  // LEGGO DALLA RICEVENTE
  leggiRicevente();
  
  // converto e ottengo il valore del "gas"
  gas = map(valorePin2, GAS_MIN, GAS_MAX, 0, 1000);
  
  gasMotore1 = gas;
  gasMotore2 = gas;
  gasMotore3 = gas;
  gasMotore4 = gas;
  
  calcolaRollPitchTarget();
  
  if (!manovraInCorso && false) {
    if (pitchValue > 1 || pitchValue < -1) pitchTarget = -1 * pitchValue;
    if (rollValue > 1 || rollValue < -1) rollTarget = -1 * rollValue;
  }
  
  // Aggiusto Pitch
  if (pitchTarget < 0) { // devo andare avanti
    gasMotore1 = gas - map(pitchTarget - pitchValue, -10, 0, 10, 0);
    gasMotore3 = gas - map(pitchTarget - pitchValue, -10, 0, 10, 0);
    if (gasMotore1 > gas) {
      gasMotore2 -= gasMotore1 - gas;
      gasMotore1 = gas;
    }
    if (gasMotore3 > gas) {
      gasMotore4 -= gasMotore3 - gas;
      gasMotore3 = gas;
    }
  } else if (pitchTarget > 0) { // devo andare indietro
    gasMotore2 = gas - map(pitchTarget - pitchValue, 0, 10, 0, 10);
    gasMotore4 = gas - map(pitchTarget - pitchValue, 0, 10, 0, 10);
    if (gasMotore2 > gas) {
      gasMotore1 -= gasMotore2 - gas;
      gasMotore2 = gas;
    }
    if (gasMotore4 > gas) {
      gasMotore3 -= gasMotore4 - gas;
      gasMotore4 = gas;
    }
  }
  
  // Aggiusto roll
  if (rollTarget < 0) { // devo andare a destra
    gasMotore2 = gas - map(rollTarget - rollValue, -10, 0, 10, 0);
    gasMotore3 = gas - map(rollTarget - rollValue, -10, 0, 10, 0);
    if (gasMotore2 > gas) {
      gasMotore1 -= gasMotore2 - gas;
      gasMotore2 = gas;
    }
    if (gasMotore3 > gas) {
      gasMotore4 -= gasMotore3 - gas;
      gasMotore3 = gas;
    }
  } else if (rollTarget > 0) { // devo andare a sinistra
    gasMotore1 = gas - map(rollTarget - rollValue, 0, 10, 0, 10);
    gasMotore4 = gas - map(rollTarget - rollValue, 0, 10, 0, 10);
    if (gasMotore1 > gas) {
      gasMotore2 -= gasMotore1 - gas;
      gasMotore1 = gas;
    }
    if (gasMotore4 > gas) {
      gasMotore3 -= gasMotore4 - gas;
      gasMotore4 = gas;
    }
  }
  
  if ((motoriAccesi) && (valorePin4==0) && (valorePin5==0) && (valorePin6==0) && (valorePin7==0)) {
    //autoAtterraggio();
    staccaMotori();
    motoriAccesi = 0;
    // risetto pitch e roll (sono atterrato quindi li riaggiusto)
    firstPitch = pitch(AcX, AcY, AcZ);
    firstRoll = roll(AcX, AcY, AcZ);
    goto fine;
  }
  
  // CONFIGURAZIONE DELLE MODALITA
  if (MODALITA_AUTOATTERRAGGIO(valorePin7) && (motoriAccesi)) { // AUTOATTERRAGGIO
    //autoAtterraggio();
    #if DEBUG==1
      Serial.println("");
      Serial.println("***** AUTOATTERRAGGIO *****");
      Serial.println("");
    #endif;
    staccaMotori();
    motoriAccesi = 0;
    goto fine;
  } else if (MODALITA_FERMO(valorePin7) && (motoriAccesi)) { // MOTORI SPENTI (DISARMO)
    #if DEBUG==1
      Serial.println("");
      Serial.println("***** FERMO *****");
      Serial.println("");
    #endif;
    staccaMotori();
    motoriAccesi = 0;
  }
  else if (MODALITA_ATTIVO(valorePin7) && (!motoriAccesi)) {     // ACCENDO I MOTORI (ARMO)
    if (!motoriAccesi) {
      #if DEBUG==1
        Serial.println("");
        Serial.println("***** ATTIVO *****");
        Serial.println("");
      #endif;
      attaccaMotori(); // ATTIVO I MOTORI
      motoriAccesi = 1;
    }
  }
  
  #if MOTORI==1
    if (motoriAccesi) {
      motore1.scrivi(map(gasMotore1, 0, 1000, VALORE_MINIMO, VALORE_MASSIMO));
      motore2.scrivi(map(gasMotore2, 0, 1000, VALORE_MINIMO, VALORE_MASSIMO));
      motore3.scrivi(map(gasMotore3, 0, 1000, VALORE_MINIMO, VALORE_MASSIMO));
      motore4.scrivi(map(gasMotore4, 0, 1000, VALORE_MINIMO, VALORE_MASSIMO));
    }
  #endif;
  
fine:
  #if DEBUG==1
  
    Serial.print("Pitch: ");
    Serial.print(pitchValue, DEC);
    Serial.print("\t");
    Serial.print("Roll: ");
    Serial.println(rollValue, DEC);
    
    Serial.print("Pitch target: ");
    Serial.print(pitchTarget, DEC);
    Serial.print("\t");
    Serial.print("Roll target: ");
    Serial.println(rollTarget, DEC);
    /*
    Serial.print("GAS: ");
    Serial.println(gas, DEC);
    */
    Serial.print("Motore1: ");
    Serial.println(map(gasMotore1, 0, 1000, VALORE_MINIMO, VALORE_MASSIMO), DEC);
    Serial.print("Motore2: ");
    Serial.println(map(gasMotore2, 0, 1000, VALORE_MINIMO, VALORE_MASSIMO), DEC);
    Serial.print("Motore3: ");
    Serial.println(map(gasMotore3, 0, 1000, VALORE_MINIMO, VALORE_MASSIMO), DEC);
    Serial.print("Motore4: ");
    Serial.println(map(gasMotore4, 0, 1000, VALORE_MINIMO, VALORE_MASSIMO), DEC);

    Serial.print("Valore PIN (7) modalita': ");
    Serial.println(valorePin7, DEC);
    
    Serial.print("Valore PIN (4) DS/SX: ");
    Serial.println(valorePin4, DEC);
    
    Serial.print("Valore PIN (5) AV/IN: ");
    Serial.println(valorePin5, DEC);
    
    Serial.print("Valore PIN (6) RDX/RSX: ");
    Serial.println(valorePin6, DEC);
    
    Serial.print("Valore PIN (2) GAS': ");
    Serial.println(valorePin2, DEC);
    
    Serial.println("");
    Serial.println("");
    
    delay(DEBUG_DELAY_TIME);
  #endif;
;}





