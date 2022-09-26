#include <Servo.h>

Servo servo;

bool isRotating = false;
float steeringAngle = 0;
int angle = 0;

int servoPin = 9;

int prevTime = 0;

//
int pos = 0;
float value = 0;
//

void setup() {

Serial.begin(9600);

//servo.attach(servoPin);

}

void loop() {
  if(Serial.available() || value == 10)
  {
    String data = Serial.readString();
    value= data.toFloat();
    if( value == 10 )
    {
      servo.attach(servoPin);
        for (pos = 31; pos <= 149; pos += 1) { 
        servo.write(pos);              
        delay(15);                      
          }
         for (pos = 149; pos >= 31; pos -= 1) { 
          servo.write(pos);           
           delay(15);                       
           }
    }

    if ( value == 20)
    {
      servo.detach();
    }
  }}
/*
  if(Serial.available())
  {
    String data = Serial.readString();
    float value= data.toFloat();
    for ( angle=0; angle < value*10; angle++){
      servo.write(angle);
    }
    delay(15);
    
  }
  */
 
