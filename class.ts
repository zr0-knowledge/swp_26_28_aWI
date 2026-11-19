abstract class Animal {
    private _name: string;
    private _colour: string;
    private _birthDate: Date;

    constructor(name: string, colour: string, birthDate: Date) {
        if (birthDate > new Date()) {
            throw new Error("Geburtsdatum liegt in der Zukunft");
        }
        this._name = name;
        this._colour = colour;
        this._birthDate = birthDate;
    }

    public get Name(): string {
        let myLocalVar = "myLocalVar";
        return this._name;
    }

    public get Colour() { return this._colour; }
    public set Colour(value: string) { this._colour = value; }
    public get BirthDate() { return this._birthDate; }

    public getAge(): number {
        const today = new Date();
        let age = today.getFullYear() - this._birthDate.getFullYear();
        const hadBirthdayThisYear =
            today.getMonth() > this._birthDate.getMonth() ||
            (today.getMonth() === this._birthDate.getMonth() && today.getDate() >= this._birthDate.getDate());
        if (!hadBirthdayThisYear) {
            age--;
        }
        return age;
    }

    public makeSound() { console.log("Animal sound"); }
}

class Cow extends Animal {
    public makeSound() { console.log("Muuuuh"); }
}

class Cat extends Animal {
    public makeSound() { console.log("Miau"); }
}

let myKuh = new Cow("Kuh1", "Weiß", new Date(2020, 4, 15));
let myKuh1 = new Cow("Kuh2", "schwarz", new Date("2021-01-01"));
let myKuh2 = myKuh;
let myCat = new Cat("Katze1", "grau", new Date(2023, 11, 1));

myKuh.makeSound();
myCat.makeSound();

console.log(myKuh.Name + " ist " + myKuh.getAge() + " Jahre alt");
console.log(myCat.Name + " ist " + myCat.getAge() + " Jahre alt");
console.log(myKuh.Name + " wurde am " + myKuh.BirthDate.toLocaleDateString("de-DE") + " geboren");

console.log(myKuh2 == myKuh);
console.log(myKuh.Name);
myKuh.Colour = "braun";
console.log(myKuh2.Colour);

try {
    new Cat("Katze2", "grau", new Date(2099, 0, 1));
} catch (e) {
    console.log("Fehler: " + (e as Error).message);
}
