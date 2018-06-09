class Motore {
  public:
    int PIN;
    int max_valore;
    int valore;
};


// Creo variabili
Motore motore1;
Motore motore2;
Motore motore3;
Motore motore4;

// LED
const int LED = 13;

// Dichiaro funzioni
void PotenziaSingolo(Motore *motore, int valore);
void arm();
void PotenziaTutti(int valore);
void Refresh();
void Leggi(Motore *motore, int mot);
void LeggiTutto();


void arm()
{
  PotenziaSingolo(&motore1, 0);
  PotenziaSingolo(&motore2, 0);
  PotenziaSingolo(&motore3, 0);
  PotenziaSingolo(&motore4, 0);
 for(int val = 0; val <= 50; val += 5)
 {
//   analogWrite(motore1, val);
//   analogWrite(motore2, val);
//   analogWrite(motore3, val);
//   analogWrite(motore4, val);
   delay(100);
 }
}

void PotenziaTutti(int valore) // <--------- 0 - 1000
{
  //valore = map(valore, 0, 1000, 0, 255);
  PotenziaSingolo(&motore1, valore);
  PotenziaSingolo(&motore2, valore);
  PotenziaSingolo(&motore3, valore);
  PotenziaSingolo(&motore4, valore);
}

void PotenziaSingolo(Motore *motore, int valore)
{
  valore = map(valore, 0, 1000, 0, 255);
  //int massimo = motore->max_valore;
  if (valore <= motore->max_valore)
  {
    motore->valore = valore;
  } else {
    motore->valore = motore->max_valore;
  }
}

void Refresh()
{
  analogWrite(motore1.PIN, motore1.valore);
  analogWrite(motore2.PIN, motore2.valore);
  analogWrite(motore3.PIN, motore3.valore);
  analogWrite(motore4.PIN, motore4.valore);
}

void setup() 
{
  pinMode(LED, OUTPUT);
  Serial.begin(9600);
  // Assegno il PIN
  motore1.PIN = 9;
  motore2.PIN = 10;
  motore3.PIN = 11;
  motore4.PIN = 3;
  // Assegno valore massimo
  motore1.max_valore = 50;
  motore2.max_valore = 250;
  motore3.max_valore = 150;
  motore4.max_valore = 5;
  delay(3500);
  digitalWrite(LED, HIGH);
  arm();
  digitalWrite(LED, LOW);
} 

void loop() 
{ 
  delay(5000);
  LeggiTutto();
  PotenziaSingolo(&motore1, 40);
  PotenziaTutti(500);
}

void LeggiTutto()
{
  Leggi(&motore1, 1);
  Leggi(&motore2, 2);
  Leggi(&motore3, 3);
  Leggi(&motore4, 4);
}

void Leggi(Motore *motore, int mot)
{
  Serial.print("motore ");
  Serial.print(mot);
  Serial.println(": ");
  Serial.print("Valore: ");
  Serial.println(motore->valore);
  Serial.print("PIN: ");
  Serial.println(motore->PIN);
  Serial.print("Valore Max: ");
  Serial.println(motore->max_valore);
  Serial.println("----------------------");
}
