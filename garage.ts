class Fahrzeug implements IVerkaufsartikel {
    private fahrzeugtyp: string;
    private name: string;
    verkaufsNamen: string;
    preis: number;

    get Fahrzeugtyp(): string {
        return this.fahrzeugtyp;
    }

    get Name(): string {
        return this.name;
    }

    constructor(fahrzeugtyp: string, name: string) {
        this.fahrzeugtyp = fahrzeugtyp;
        this.name = name;
        this.verkaufsNamen = name;
        this.preis = 0;
    }
}

class Fahrrad extends Fahrzeug {
    private anzahlGaenge: number;

    get AnzahlGaenge(): number {
        return this.anzahlGaenge;
    }

    constructor(fahrzeugtyp: string, name: string, anzahlGaenge: number) {
        super(fahrzeugtyp, name);
        this.anzahlGaenge = anzahlGaenge;
        this.verkaufsNamen = name;
        this.preis = 500;
    }
}

class Auto extends Fahrzeug {
    private anzahlTueren: number;

    get AnzahlTueren(): number {
        return this.anzahlTueren;
    }

    constructor(fahrzeugtyp: string, name: string, anzahlTueren: number) {
        super(fahrzeugtyp, name);
        this.anzahlTueren = anzahlTueren;
        this.verkaufsNamen = name;
        this.preis = 20000;
    }
}

class PKW extends Auto {
    private motorTyp: string;
    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("PKW", name, anzahlTueren);
        this.motorTyp = motorTyp;
    }
}

class LKW extends Auto {
    private motorTyp: string;

    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("LKW", name, anzahlTueren);
        this.motorTyp = motorTyp;
    }
}

interface IVerkaufsartikel {
    verkaufsNamen: string;
    preis: number;
}

class Reifen implements IVerkaufsartikel {
    verkaufsNamen: string;
    preis: number;
    marke: string;
    groesse: number;
    typ: string;
    constructor(marke: string, groesse: number, typ: string) {
        this.marke = marke;
        this.groesse = groesse;
        this.typ = typ;
        this.verkaufsNamen = marke;
        this.preis = 100;
    }
}

class Garage {
    public addFahrzeug(fahrzeug: IVerkaufsartikel): void {
        this.verkaufbareDinge.push(fahrzeug);
    }
    public verkaufbareDinge: IVerkaufsartikel[] = [];

    public getFahrzeuge(): Fahrzeug[] {
        return this.verkaufbareDinge.filter(item => item instanceof Fahrzeug) as Fahrzeug[];
    }

    public addReifen(reifen: Reifen): void {
        this.verkaufbareDinge.push(reifen);
    }

    public getReifen(): Reifen[] {
        return this.verkaufbareDinge.filter(item => item instanceof Reifen) as Reifen[];
    }

    get anzahlFahrzeuge(): number {
        return this.verkaufbareDinge.filter(item => item instanceof Fahrzeug).length;
    }

    get anzahlAutos(): number {
        let anzahlAutos: number = 0;
        for (const fahrzeug of this.verkaufbareDinge) {
            if (fahrzeug instanceof Auto) {
                anzahlAutos++;
            }
        }
        return anzahlAutos;
    }
}

var myBWMWith4Doors = new PKW("BMW", 4, "Benzin");
console.log(myBWMWith4Doors.Fahrzeugtyp);
console.log(myBWMWith4Doors.AnzahlTueren);
var myBWMWith2Doors = new PKW("BMW", 2, "Benzin");
console.log(myBWMWith2Doors.Fahrzeugtyp);
console.log(myBWMWith2Doors.AnzahlTueren);
var myMANWith2Doors = new LKW("MAN", 2, "Diesel");
console.log(myMANWith2Doors.Fahrzeugtyp);
console.log(myMANWith2Doors.AnzahlTueren);

var myFahrrad = new Fahrrad("Fahrrad", "Mountainbike", 21);
console.log(myFahrrad.Fahrzeugtyp);
console.log(myFahrrad.AnzahlGaenge);

var myGarage = new Garage();
myGarage.addFahrzeug(myBWMWith4Doors);
myGarage.addFahrzeug(myBWMWith2Doors);
myGarage.addFahrzeug(myMANWith2Doors);
myGarage.addFahrzeug(myFahrrad);
console.log(`Anzahl Fahrzeuge in der Garage: ${myGarage.anzahlFahrzeuge} davon Autos: ${myGarage.anzahlAutos}`);

myGarage.addReifen(new Reifen("Michelin", 16, "Sommerreifen"));
myGarage.addReifen(new Reifen("Continental", 17, "Winterreifen"));

console.log(`Verkaufbare Dinge in der Garage: ${myGarage.verkaufbareDinge.length}`);
