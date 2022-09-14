#include <Servo.h>

Servo servo;

bool isRotating = false;
float steeringAngle = 0;
int angle = 0;

int servoPin = 9;

int prevTime = 0;

void setup() {

Serial.begin(9600);

servo.attach(servoPin);

}

void loop() {

  if(Serial.available())
  {
    String data = Serial.readString();
    float value= data.toFloat();
    for ( angle=0; angle < value*10; angle++){
      servo.write(angle);
    }
    delay(15);
    
  }
  
 }
