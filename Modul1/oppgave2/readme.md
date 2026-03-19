Et program som returnerer en tilpasset melding (hilsen) tilbake til brukeren, basert på tidspunkter.
# Assignment 2: Customisert God Morgen program

## 1. Planning (Pseudocode)
1. Start programmet og rens skjermen (Clear).

Spør brukeren: "Hva heter du?" og lagre svaret i en variabel name.

Hent nåværende time fra DateTime.Now.Hour.

Definer en "Lookup Table" (Dictionary) for tidsintervaller:

05-09: "God morgen"

10-17: "God dag"

18-22: "God kveld"

23-04: "God natt"

Finn riktig hilsen basert på timen.

Skriv ut en formatert melding med farger: [Navn], [Hilsen]! Velkommen til systemet.

## 2. Notice
1. using Spectre.Console;
do not forget to run `dotnet add package Spectre.Console`
2. using System.Collections.Generic;
because I use Dictionary.

## 3. How to Run (Local)
Since I am working in a restricted IT environment, I use the following commands:
1. `dotnet build`
2. `dotnet exec bin/Debug/net10.0/oppgave1.dll`