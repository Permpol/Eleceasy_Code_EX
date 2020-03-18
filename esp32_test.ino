#include <Wire.h>
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x3F, 16, 2);

int sensorLight=2;
int sensorValue=4;

int sensorValue1 = 0;        // ตัวแปรค่า Analog
int outputValue1 = 0;        // ตัวแปรสำหรับ Map เพื่อคิด %
int sensorValue2 = 0;        // ตัวแปรค่า Analog
int outputValue2 = 0;        // ตัวแปรสำหรับ Map เพื่อคิด %
โค๊ดโปรแกรมแบบไม่เชื่อมต่อ Blynk

void setup() {
  Serial.begin(115200); // set up serial port for 9600 baud (speed)
  delay(500); // wait for display to boot up
  lcd.begin();
  lcd.backlight();

}

void loop() {
 sensorValue1 = analogRead(sensorLight);
  outputValue1 = map(sensorValue1,0,4095,100,0);
  Serial.print("Light: ");
  Serial.print(outputValue1);
  Serial.println(" %");
  lcd.setCursor(0,0);
  lcd.print("Light: ");
  lcd.setCursor(7,0);
  lcd.print(outputValue1);
  lcd.setCursor(11,0);
  lcd.print(" %");
  
  sensorValue2=analogRead(sensorValue);
  outputValue2 =map(sensorValue2,0,4095,100,0);
  Serial.print("Value: ");
  Serial.print(outputValue2);
  Serial.println(" %");
  lcd.setCursor(0,1);
  lcd.print("Value: ");
  lcd.setCursor(7,1);
  lcd.print(outputValue2 );
  lcd.setCursor(11,1);
  lcd.print(" %");
  delay(1000);

}
