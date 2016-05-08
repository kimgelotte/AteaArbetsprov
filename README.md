# AteaArbetsprov
Detta är ett arbetsprov för Atea.

Syftet med arbetsprovet är att uppvisa mina kunskaper inom C# och Asp.net.
Målet med uppgiften är att visa hur jag tar mig an en programmeringsuppgift.

Uppgiften:
Utveckla en websida som kan ta emot meddelanden som skickas ifrån en windows konsollapplikation (console application). 
Meddelandet som tas emot ska vara tidsstämplat och websidan ska kunna visa upp en lista på alla mottagna meddelanden och
sortera dom efter datum/tid.
Alla meddelanden ska sparas i en databas så att man kan komma tillbaka till websidan och se alla historiska meddelanden.

Krav:
1 visual studio-solution.
Visual studio-solution ska vara kopplad mot github repository.
Koden ska vara skriven i C#.

Hur jag löste uppgiften:
Jag började med att skapa en enkel konsollapplikation där jag kan mata in meddelanden. Jag vill att applikationen ska skriva 
ut att vi kan mata in ett meddelande. Sedan vill jag också att vi får en liten bekräftelse när vi har matat in ett meddelande
och det har sparats i databasen. Jag skapade 2 metoder för detta. En metod som tar emot meddelanden och sätter en tidsstämpel, 
och en metod som sparar meddelandet tillsammans med en tidsstämpel.

Sedan skapade jag en databas genom entity framework (code first). 
Tabellen är väldigt simpel. Det enda vi behöver är ett ID, meddelandetext och en tidsstämpel.

Jag skapade några enkla unit-tests för att kontrollera mina inmatningar i konsollapplikationen. Detta för ev test.

För websidan valde jag att köra med MVC (model, view, controller).
Jag skapar en Ado.net model ifrån databasen vi konstruerade tidigare. 
Jag skapar en controller som hämtar den informationen vi behöver ifrån databasen (meddelandet med tidsstämpel).
Ett av kraven i uppgiften var att meddelanden skulle sorteras efter datum/tid, så jag valde att sortera detta när jag hämtar 
meddelanden med ett enkelt lambda-uttryck.
Efter att vi har vår controller så skapar vi en view där vi presenterar våra meddelanden.

