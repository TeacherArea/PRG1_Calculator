# En responsiv kalkulator

## Översikt
Välkommen till PRG1_Calculator, en pedagogisk resurs färmst avsedd att stödja lärandet av programmering för studenter som går kurserna Programmering 1 och Programmering 2. Men dessa kan med fördel även användas för studenter i grundläggande programmering för högre studier.

En pedagogisk orsak bakom användning av Windows Forms är dess verktyg TableLayoutPanel och FloatLayoutPanel, vilka ger en bra ingång till förståelsen för först HTML/CSS Grid och Flexbox samt senare MAUI:s använding av XAML:s StackLayout, AbsoluteLayout, Grid och FlexLayout.
För de elever i Programmering 2 som så önskar och har nödvändiga kunskaper (!), kan kod och arktiektur relativt enkelt översättas till MAUI (eller liknande), men dessa tekniker planeras att läras ut först senare i kursen (när denna övning är inlämnad). 

Branchen main i repository innehåller en enkel Windows Forms-kalkylatorapp, som utvecklas över flera branches för att demonstrera olika programmeringskoncept och praxis. Från en enklare kalkylator till en objektorienterad som är baserad på arkitekturen MVC (Model View Controller) är steget stort, varvid de brancherna bör ses som självständiga.

## En möjlig grundläggande layout
![alt text](/img/calc.jpg)


## Tekniska specifikationer
- Programmeringsspråk: C#
- Gränssnitt: Windows Forms
- Permanent datalagring: json
- Arkitektur: från enkel till MVC


## Branch-struktur
- `main` (Programmering 1): Innehåller en grundläggande kalkylator med intentionella brister för elever att identifiera och förbättra.
- `step1/basicCalculator` (Programmering 1): Ett exempel på en grundläggande kalkylator för Programmering 1 elever att referera till om de kör fast.
- `step2/objectoriented` (Programmering 2): En förlängning av `step1/basicCalculator` som introducerar dels objektorienterade principer och dels tekniker för permanent datalagring (json).
- `step2/objectoriented` (Programmering 2): En förlängning av `step1/basicCalculator` som introducerar MVC och än djupare objektorienterade principer.

## Användning
Varje branch är självständig och innehåller en version av kalkylatorappen som är relevant för dess utbildningssyfte. Eleverna uppmuntras att klona det aktuella repositoryt, checka ut den relevanta branchen och följa gemensamma obligatoriska genomgångar och medföljande instruktioner. Samtliga delar av övningarna är examinerande för sina respektive kurser.

## Instruktioner
### Klona Repository
För att klona repositoryt, öppna terminalen och kör följande kommando:
```bash
git clone https://github.com/TeacherArea/PRG_WinForms_Calculator.git

## Observera
Ingen lösning i någon av brancherna är avsedda att betraktas som en "Production Build", alltså som en slutgiltig versionen redo för användning i en produktionsmiljö. De är fortfarande i utvecklingsfas.

En orsak till att dela kod så här är ju att stimulera elever/studenter att själva göra en än bättre lösning! Laddas de ner görs detta på eget ansvar och helt på egen risk. Inget ansvar kan avkrävas utvecklaren!
