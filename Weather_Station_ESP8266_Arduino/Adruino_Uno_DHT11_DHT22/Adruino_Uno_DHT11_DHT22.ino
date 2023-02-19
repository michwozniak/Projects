#include <DHT.h>
#include <Wire.h>
#include <Adafruit_BMP280.h>
#include <SoftwareSerial.h>
#include <ArduinoJson.h>

#define DHT11_UP_PIN 4
#define DHT11_DOWN_PIN 7
#define DHT22_OUTSIDE_PIN 2

#define DHT11_UP DHT11 
#define DHT11_DOWN DHT11 
#define DHT22_OUTSIDE DHT22

SoftwareSerial nodemcu(5, 6);
DHT dht_up(DHT11_UP_PIN, DHT11_UP);
DHT dht_down(DHT11_DOWN_PIN, DHT11_DOWN);
DHT dht_outside(DHT22_OUTSIDE_PIN, DHT22_OUTSIDE);


float temp;
float hum;
float up_temperature;
float up_humidity;
float down_temperature;
float down_humidity;
float outside_temperature;
float outside_humidity;
float moisture;

void setup() {
  Serial.begin(9600);
  dht_up.begin();
  dht_down.begin();
  dht_outside.begin();
  nodemcu.begin(115200);
  delay(1000);
  while (!Serial) continue;
}

void loop() {

  StaticJsonBuffer<1000> jsonBuffer;
  JsonObject& data = jsonBuffer.createObject();

  mesurements();
  print_mesurements();

  data["downt"] = down_temperature;
  data["upt"] = up_temperature;
  data["outt"] = outside_temperature; 
  data["mois"] = moisture; 
  
  data.printTo(nodemcu);
  jsonBuffer.clear();

  delay(10000);
}

void mesurements() {
  up_temperature       = dht_up.readTemperature();
  up_humidity          = dht_up.readHumidity();
  down_temperature       = dht_down.readTemperature();
  down_humidity          = dht_down.readHumidity();
  outside_temperature       = dht_outside.readTemperature();
  outside_humidity          = dht_outside.readHumidity();
  outside_temperature       = dht_outside.readTemperature();
  outside_humidity          = dht_outside.readHumidity();
  moisture             = analogRead(A0);
}

void print_mesurements() {
  //Serial.print("Humidity UP: ");
  Serial.println(up_humidity);
  //Serial.print("Temperature UP: ");
  Serial.println(up_temperature);

  //Serial.print("Humidity DOWN: ");
  Serial.println(down_humidity);
  //Serial.print("Temperature DOWN: ");
  Serial.println(down_temperature);

  //Serial.print("Humidity OUTSIDE: ");
  Serial.println(outside_humidity);
  //Serial.print("Temperature OUTSIDE: ");
  Serial.println(outside_temperature);

  //Serial.print("Moisture Flower: ");
  Serial.println(moisture);
}