#include <Adafruit_BMP280.h>
#include <SoftwareSerial.h>
#include <ArduinoJson.h>
#include <ESP8266WiFi.h>
#include <Wire.h>
#include "ThingSpeak.h"

SoftwareSerial nodemcu(D6, D5);
Adafruit_BMP280 bmp280;

WiFiClient  client;

//const char* ssid = "Orange_Swiatlowod_XYZ_EXT";
const char* ssid = "stacja_1";
const char* password = "XYZ";
unsigned long myChannelNumber = 2035996;
const char * myWriteAPIKey = "Y0DECMEUCM3JKQCH";
unsigned long lastTime = 0;
unsigned long timerDelay = 20000;

float down_temperature;
float up_temperature;
float outside_temperature;
float moisture;
float pressure_temperature;
float pressure;


void setup() {
  Serial.begin(9600);
  nodemcu.begin(115200);
  bmp280.begin(0x76);
  WiFi.mode(WIFI_STA);
  ThingSpeak.begin(client);
  //  if (!bmp280.begin(0x76))
  //{  
  //  Serial.println("PRESSURE ERROR!");
  //  while (1);
  //}
  while (!Serial) continue;
  delay(5000);
}


void loop() {
  receiving_data();
  printing_data();
  delay(5000); 
  
  if ((millis() - lastTime) > timerDelay) {

    if(WiFi.status() != WL_CONNECTED){
      Serial.print("Attempting to connect");
      while(WiFi.status() != WL_CONNECTED){
        WiFi.begin(ssid, password); 
        Serial.print("\nWait");
        delay(5000);     
      } 
      Serial.println("\nConnected.");
    }

    ThingSpeak.setField(1, up_temperature);
    ThingSpeak.setField(2, down_temperature);
    ThingSpeak.setField(7, outside_temperature);
    ThingSpeak.setField(4, pressure_temperature);
    ThingSpeak.setField(5, moisture);
    ThingSpeak.setField(6, pressure);
    ThingSpeak.writeFields(myChannelNumber, myWriteAPIKey);

    lastTime = millis();
  }
  
}


void receiving_data() {
  StaticJsonBuffer<1000> jsonBuffer;
  JsonObject& data = jsonBuffer.parseObject(nodemcu);

  if (data == JsonObject::invalid()) {
    jsonBuffer.clear();
    return;
  }

  down_temperature     = data["downt"];
  up_temperature       = data["upt"];
  outside_temperature  = data["outt"];
  moisture             = data["mois"];
  pressure_temperature = bmp280.readTemperature();
  pressure             = bmp280.readPressure()/100;  
}


void printing_data() {
  Serial.println("JSON Object Recieved");
  Serial.print("Recieved Temperature Down:  ");
  Serial.print(down_temperature);
  Serial.println(" C");
  Serial.print("Recieved Temperature Up:    ");
  Serial.print(up_temperature);
  Serial.println(" C");
  Serial.print("Recieved Temperature Outside:  ");
  Serial.print(outside_temperature);
  Serial.println(" C");
  Serial.print("Recieved Temperature PC:       ");  
  Serial.print(pressure_temperature);
  Serial.println(" C");
  Serial.print("Recieved Pressure:  ");  
  Serial.print(pressure);
  Serial.println(" hPa");
  Serial.print("Recieved Moisture:  ");  
  Serial.print(moisture);
  Serial.println(" %");
  Serial.println("-----------------------------------------");
}