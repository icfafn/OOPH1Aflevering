internal class MotorKøretøj
{ 
    public int HesteKræfter { get; set; } 
}


internal class Bil : MotorKøretøj
{ 
    public string Mærke { get; set; } 
}


internal class Audi : Bil
{ 
    public string Model { get; set; } 
}

//Udefra klasserne til venstre, og med det arve hierarki som klasserne implementer,
//hvilket af følgende 6 istantieringforneden vil IKKE vise fejl når implementeres?

MotorKøretøj motorKøretøj = new MotorKøretøj();
//Denne vil fungere.

MotorKøretøj motorKøretøj = new Bil();

MotorKøretøj motorKøretøj = new Audi();

Audi audi = new Audi();
//Denne vil fungere.
Audi audi = new Bil();

Audi audi = new MotorKøretøj();

//2.Hvis man istantiere Audi klassen.
//Kan man igennem audi klassens instans se Mærke og HesteKræfterproperty’erne?



//3.Hvis man istantiere MotorKøretøj klassen.
//Kan man igennem motorkøretøj instans se Mærke og Model property’erne?
