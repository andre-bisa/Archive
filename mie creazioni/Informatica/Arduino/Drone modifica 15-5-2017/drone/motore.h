//#include <Servo.h>

class Motore
{
  public:
    Motore(int pin);
    void init();
    void attiva();
    void disattiva();
    void scrivi();
    void scrivi (int valore);
    void stacca();
    void attacca();
    void setValore(int valore);
    int getValore();
    int isAttivo();
    void reset();
    
  private:
    int _pin;
    Servo _servo;
    int _valore;
    int _attivo;
    int _vecchioValore;
};

Motore::Motore(int pin)
{
  _pin = pin;
  _attivo = 0;
}

void Motore::scrivi() {
  #if MOTORI==1
    if (_attivo)
      _servo.write(_valore);
   #endif
}

void Motore::scrivi(int valore) {
  if (valore != _vecchioValore) {
    setValore(valore);
    scrivi();
    _vecchioValore = valore;
  }
}

void Motore::stacca() {
  scrivi(0);
  _servo.detach();
}

void Motore::init() {
  if (isAttivo()) 
    _servo.attach(_pin);
}

void Motore::reset() {
  attiva();
  attacca();
  scrivi(0);
  stacca();
  disattiva();
}

void Motore::attacca() {
  init();
}

void Motore::setValore(int valore) {
  _valore = valore;
}

int Motore::getValore() {
  return _valore;
}

int Motore::isAttivo() {
  return _attivo;
}

void Motore::attiva() {
  _attivo = 1;
}

void Motore::disattiva() {
  _attivo = 0;
}

