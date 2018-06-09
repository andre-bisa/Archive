class Motore {
  public:
    int PIN;
    int max_valore;
    int valore;
};


// Creo variabili
Motore motore1; // 9
Motore motore2; // 10
Motore motore3; // 11
Motore motore4; // 3

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
  PotenziaTutti(100);
  Refresh();
}

void PotenziaTutti(int valore) // <--------- 0 - 1000
{
  PotenziaSingolo(&motore1, valore);
  PotenziaSingolo(&motore2, valore);
  PotenziaSingolo(&motore3, valore);
  PotenziaSingolo(&motore4, valore);
}

void PotenziaSingolo(Motore *motore, int valore) // <--------- 0 - 1000
{
  valore = map(valore, 0, 1000, 0, 255);
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
  motore1.max_valore = 1000;
  motore2.max_valore = 1000;
  motore3.max_valore = 1000;
  motore4.max_valore = 1000;
  delay(3500);
  digitalWrite(LED, HIGH);
  arm();
  digitalWrite(LED, LOW);
} 

void loop() 
{ 
  delay(5000);
  LeggiTutto();
  //PotenziaSingolo(&motore1, 40);
  PotenziaTutti(200);
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
