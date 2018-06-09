#include <Wire.h>

const int MPU=0x68;                    // I2C address of the MPU-6050

void leggiGiroscopio();
void init_MPU();


void init_MPU(){
  Wire.begin();
  Wire.beginTransmission(MPU);
  Wire.write(0x6B);  // PWR_MGMT_1 register
  Wire.write(0);     // set to zero (wakes up the MPU-6050)
  Wire.endTransmission(true);
}
