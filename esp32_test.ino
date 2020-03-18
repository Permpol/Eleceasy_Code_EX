#include <Wire.h>
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x3F, 16, 2);

#define BLYNK_PRINT Serial
#include <WiFi.h>
#include <WiFiClient.h>
#include <BlynkSimpleEsp32.h>

int RelayLight=12;
int RelayValue=13;
int sensorLight=2;
int sensorValue=4;

int sensorValue1 = 0;        // ตัวแปรค่า Analog
int outputValue1 = 0;        // ตัวแปรสำหรับ Map เพื่อคิด %
int sensorValue2 = 0;        // ตัวแปรค่า Analog
int outputValue2 = 0;        // ตัวแปรสำหรับ Map เพื่อคิด %

char auth[] = "L5xSTLXHIkZDiG_bWK8JqeWinn_G76xG";
char ssid[] = "CHALOR@1B";
char pass[] = "0862136574";
char server[] = "oasiskit.com";
int port = 8080;

BlynkTimer timer;
BLYNK_CONNECTED(){
  Blynk.syncAll();
}

void sensor(){
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
  outputValue2 =map(sensorValue2,0,4095,0,100);
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

void setup() {
  Serial.begin(115200);
  pinMode(RelayLight,OUTPUT);
  pinMode(RelayValue,OUTPUT);
  Blynk.begin(auth, ssid, pass, server, port);
  timer.setInterval(500,sensor);
}

void loop() {
 Blynk.run();
 timer.run();
}
