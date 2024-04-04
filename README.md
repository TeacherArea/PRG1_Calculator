# En responsiv kalkulator

## Översikt
Välkommen till PRG1_Calculator, en pedagogisk resurs avsedd att stödja lärandet av programmering för studenter som går kurserna Programmering 1 och Programmering 2.

Gränssnittet som används är Windows Forms, och orsaken är att användning av dess TableLayoutPanel och FloatLayoutPanel ger en bra ingång till förståelsen för först HTML/CSS Grid och Flexbox samt senare MAUI:s använding av XAML:s StackLayout, AbsoluteLayout, Grid och FlexLayout. För de elever i Programmering 2 som önskar gå händelserna i förväg kan självklart använda denna kod i MAUI (eller liknande), men dessa tekniker planeras att övergå till i kursen när denna övning är inlämnad. 

Branchen main i repository innehåller en enkel Windows Forms-kalkylatorapp, som utvecklas över flera branches för att demonstrera olika programmeringskoncept och praxis. Från en enklare kalkylator till en objektorienterad som är baserad på arkitekturen MVC (Model View Controller) är steget stort, varvid de brancherna bör ses som självständiga.

## Observera
Ingen lösning i någon av brancherna är avsedda att betraktas som en "Production Build", alltså en slutgiltig versionen redo för användning i en produktionsmiljö. De är fortfarande i utvecklingsfas. Laddas de ner görs detta på eget ansvar och helt på egen risk. Inget ansvar kan avkrävas utvecklaren!

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
