//Arduino Mega
//La Velocidad se tuvo que partir en dos Bytes porque el puerto serial
//en .NET se enreda por encima del ascii 127

//Sonares en A0 y A1
//Sensor infrarojo rueda delantera: A3


const int RelDer =  2;    
const int MotDer =  3;      
const int RelIzq =  4;      
const int MotIzq =  5;      
const int LED =  13;      
const int Buzzer =  A9;      


//---------------------------------------------Variables------------------------
int Milis;
int Pos;int Pos2;
int Cont=0;
String Comando;
byte Estado[10];
byte VelIzq;byte VelDer;
byte PosServo=100;
int SonarIzq;int SonarDer;int SonarCen;
int SumSonarIzq;int SumSonarDer;int SumSonarCen;
int Tacom; int ContTacom; int TacomAnt;int SumTacom;


//---------------------------------------------SETUP------------------------
void setup() {
  Serial.begin(9600);
  Serial1.begin(9600);
  analogReference(INTERNAL1V1);
  digitalWrite(LED,LOW);
  pinMode(LED,OUTPUT);
  pinMode(RelDer,OUTPUT);
  pinMode(MotDer,OUTPUT);
  pinMode(RelIzq,OUTPUT);
  pinMode(MotIzq,OUTPUT);
  pinMode(Buzzer,OUTPUT);
  Comando="";

  digitalWrite(MotIzq,LOW);
  digitalWrite(Buzzer,LOW);
  TacomAnt=1;
  VelIzq=200;
  VelDer=200;
  analogWrite(MotIzq,VelIzq);
  analogWrite(MotDer,VelDer);

   
}
//---------------------------------------------LOOP------------------------
void loop() {
   //delay(2);
   
   Milis=millis();
   
    Cont++;
    if (Cont %500==0) {
   //     EnviaEstado();
        digitalWrite(LED,!digitalRead(LED));
        }
        //--------------Saca promedio de los sonares y tacometro
    if (Cont %10==0) {
        SonarIzq=SumSonarIzq/10;
        SonarDer=SumSonarDer/10;
        SonarCen=SumSonarCen/10;
        Tacom=SumTacom/10;
        SumSonarIzq=0;
        SumSonarDer=0;
        SumSonarCen=0;
        SumTacom=0;
        if ((Tacom>4) && (TacomAnt==0)){ ContTacom=0;TacomAnt=1;}
        if ((Tacom<5) && (TacomAnt==1)){ ContTacom=0;TacomAnt=0;}
        }
  
       if (Cont==30000){Cont=0;}
  
   
     while (Serial1.available()){        //---------------Lee Serial------------
         char LetraIn = Serial1.read();
         Comando=Comando+LetraIn;
         }
     
       SumSonarIzq+=analogRead(A0);
       SumSonarDer+=analogRead(A4);
       SumSonarCen+=analogRead(A5);
       SumTacom+=analogRead(A2);

      ContTacom++;
       if (ContTacom>2000){
            digitalWrite(RelIzq,HIGH); 
            digitalWrite(RelDer,HIGH); 
            Serial1.println("1a");
            delay(1000);
            Serial1.println("1b");
            ContTacom=0;    }
       else{
            if ((SonarCen<80)&& (SonarIzq<80)&&(SonarDer<80)) {
                digitalWrite(RelIzq,HIGH); 
                digitalWrite(RelDer,HIGH); 
                Serial1.println("2a");
                delay(1000);
                Serial1.println("2b");
                SonarIzq=200;
                SonarCen=200;
                SonarDer=200;}
             else{
                if ((SonarIzq<150)) {
                     digitalWrite(RelDer,HIGH); }
                else{
                    if ((SonarDer<80)) {
                         digitalWrite(RelIzq,HIGH); }
                    else{
                        if ((SonarCen<80)) {
                             digitalWrite(RelDer,HIGH); }
                        else{
                            digitalWrite(RelIzq,LOW); 
                            digitalWrite(RelDer,LOW); 
                            }
                        }
                    }
                }
           }
        
     



  
      if (Tacom>5){    
         digitalWrite(Buzzer,HIGH); }
      else{      
         digitalWrite(Buzzer,LOW);  }



         
      if(Comando.indexOf("ARD")>=0){      //Rel Der
   //      digitalWrite(RelDer,HIGH);
         Estado[2]=1;
         Comando=Comando.substring(3);
         }
 
     } //Fin del Main
  

  
 void EnviaEstado(){     //------------Envia Estado--------------------
   int K;
   Serial1.print("INI;");
//   for (K=1;K<=4;K++){
//     Serial1.print(Estado[K]);
//     Serial1.print(";");
//     }
   Serial1.print(ContTacom);
   Serial1.print(";");
   Serial1.print(TacomAnt);
   Serial1.print(";");
   Serial1.print(SonarDer);
   Serial1.print(";");
   Serial1.print(SonarCen);
   Serial1.print(";");
   Serial1.print(Tacom);
   Serial1.print(";");
   Serial1.println();

 //   Serial.println();

 }
