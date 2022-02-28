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

MotorKøretøj motorKøretøj = new MotorKøretøj();

MotorKøretøj motorKøretøj = new Bil();

MotorKøretøj motorKøretøj = new Audi();

Audi audi = new Audi();
// Dette er ikke en fejl... (Kommenter hvorfor!!!)
Audi audi = new Bil();

Audi audi = new MotorKøretøj();

//2.Hvis man istantiere Audi klassen.
//Kan man igennem audi klassens instans se Mærke og HesteKræfterproperty’erne?

//3.Hvis man istantiere MotorKøretøj klassen.
//Kan man igennem motorkøretøj instans se Mærke og Model property’erne?
