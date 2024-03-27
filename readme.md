# Lern-Periode 4

Robin Müller

20.2 bis 2.4.2024

## Grob-Planung

1. Wir haben seitdem letzten Mal noch keine neuen Noten zurückerhalten. Meine schlechteste Note war im Modul 162 "Daten analysieren und modellieren". Meine Besten Noten waren im Modul 319 "Applikationen entwerfen und implementieren" und im Modul 419 "Aufträge im im eigenen Berufsumfeld selbstständig durchführen".
  
2. Mein VBV war es bei WinForms-Programmen die Ansichten auf Papier zu skizzieren und neue Ideen, welche mit beim Programmieren kommen notiere und beim nächten Mal bearbeite.
  
  Ich kann den VBV am Besten umsetzen wenn ich ein Projekt mit WinForms mache und eine Text-Datei erstelle und dort meine Ideen notiere.
  
3. Mich würden dictionaries, async/await und LINQ interessieren.
  
4. Ich könnte einen Vokabeltrainer mit dictionaries machen oder ich könnte mit LINQ ein Programm machen, welches Zahlen zwischen 1 und 100 ausgibt die bestimmte Bedingungen erfüllen. Ich möchte unbedingt ReadKey verwenden, damit ich eine Taste drücken kann und dann etwas eingeben kann.
  

## 20.2.2024

✍️ Heute habe ich mir Tutorials angeschaut zu LINQ und dictionaries. Zudem habe ich in Visual Studio verschiedene Befehle ausprobiert. Dabei bin ich so versunken, sodass ich den Vokabeltrainer schon fast fertig programmiert habe. Er funktioniert bisher aber nur mit dem Wort Hund und hat noch keine zufällige Auswahl der Wörter. Die Idee mit LINQ konnte ich auch schon ausprobieren und sie hat mir gefallen. (65 Wörter)

## 27.2.2024

- [x] Ich programmiere einen Array mit den Zahlen 1 bis 100.
- [x] Ich erstelle folgende Abfragen:
  - [x] Grösser als (eingabe)
  - [x] Kleiner als (eingabe)
  - [x] Immer noch über null nachdem (eingabe) abgezogen wurde
  - [x] Immer noch unter hundert nachdem (eingabe) hinzugefügt wurde
  - [x] Alle Negativen Zahlen
  - [x] Alle Positiven Zahlen
- [x] Ich programmiere, dass die Abfragen ausgeführt werden.
- [x] Ich sortiere die Ausgaben von der Abfrage 'kleiner als' von grösster Zahl bis zur kleinster Zahl.

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1   | Code öffnen | -   | Array erscheint | x   |
| 2   | Code öffnen | -   | Abfragen erscheinen | x   |
| 3   | 1. "Was soll geschehen?" 2. "Grösser als welche Zahl?" | 1. g, 2. 99 | 100 | x   |
| 4   | 1. "Was soll geschehen?" 2. "Kleiner als welche Zahl?" | 1. k, 2. 5 | 4, 3, 2, 1 | x   |

✍️ Heute habe ich ein neues Projekt mit dem Namen "Zahlen mit Bedingungen" erstellt. Darin habe ich einen Array erstellt, welcheer sich automatisch mit den Zahlen 1 - 100 füllt, damit ich nicht stur diese Zahlen eingeben muss. Ich habe dabei auch die ersten Fragen für den Benutzer anzeigen lassen und seine Eingaben gespeichert. Danach habe ich die sechs Abfragen erstellt. Im dritten AP wurde das Programm funktionstüchtig, da der Benutzer die Abfrage auswählen konnte und diese ausgeführt wurden. Zu guter Letzt habe ich noch die Zahlen bei der Abfrage 'kleiner als' absteigend sortiert. (93 Wörter)

## 5.3.2024

- [x] Ich erweitere den Zahlenraum auf bis zu -100 und füge die Abfragen Positiv und negativ hinzu.
- [x] Ich schaue folgendes Tutorial zu eigenen Ausnahmen: [C# Tutorial #30 - Exceptionhandling (youtube.com)](https://www.youtube.com/watch?v=7ViaVtMnW7M)
- [x] Ich programmiere in mein "Zahlen mit Bedingungen" ein, dass man keine Buchstaben eingeben kann mithilfe von eigenen Ausnahmebehandlungen.
- [x] Ich schaue folgendes Video zu den Dictionarys: [C# Dictionary kurz und einfach erklärt - C# Tutorial Deutsch (youtube.com)](https://www.outube.com/watch?v=D02oPfxYfDU&list=PLCOblPDf69PcAP_e9SBn2KM5UL1F8atCU&index=1) und ergänze mein Dictionary-Game mit den Wörter vom Französischbuch leçon 1 Atelier A.

✍️ Heute habe ich als erstes mein "Zahlen mit Bedingungen"-Programm um die Zahlen 0 bis -100 erweitert und zwei neue LINQ Abfragen hinzugefügt, um zu schauen, ob ich es noch kann. Danach habe ich mir das Tutorial zu dictionnaries angeschaut. Dann habe ich ein Paar Wörter vom Französischbuch leçon 1 Atelier A in meinen Vokabeltrainer eingefügt. Im Anschluss habe ich mir ein Video zum Thema "Ausnahmebehandlungen" angeschaut und direkt in meinem "Zahlen mit Bedingungen"-Programm hinzugefügt. Da ich am Schluss noch Zeit übrig hatte, habe ich Auftrag 7720 vom Modul 164 bearbeitet. (90 Wörter)

## 12.03.2024

- [x] Ich lese folgenden Artikel zum Thema "LINQ TO SQL": [Learning by Walkthroughs - ADO.NET | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/learning-by-walkthroughs)[Learning by Walkthroughs - ADO.NET | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/learning-by-walkthroughs)
  
- [x] Ich erstelle im MYSQL eine Testdatenbank zum Thema iPhones und befülle diese mit Daten einiger iPhones.
  
- [ ] Ich verbinde die Testdatenbank mit dem C#-Code.
  
- [ ] Ich füge per C#-Code eine iPad-Tabelle und Daten hinzu.
  

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1   | Artikel öffnen | -   | AP2 + AP3 können erfüllt werden | ja  |
| 2   | MYSQL öffnen | SELECT * FROM iPhone WHERE Name = 'iPhone 11' | iPhone 11\\ | 2019-09-10 \\ |
| 3   | VS öffnen | -   | Befehl für das Verbinden ist zu sehen | nein |
| 4   | MYSQL öffnen | SELECT * FROM iPad WHERE Name = 'iPad Air 5th Gen' | iPad Air 5th Gen \\ | 2022-18-03 \\ |

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 5   | VS öffnen | -   | Befehle um Daten der Tabelle hinzuzufügen, zu bearbeiten und zu löschen | nein |

✍️ Heute habe ich als erstes eine Datenbank mit Daten zu verschiedenen iPhone-Modellen erstellt. Danach habe ich in dem oben verlinkten Artikel unter "Getting Started Walkthroughs" Abschnitt:

## 19.03.24

- [x] Ich löse das Problem mit dem DataContext
  
- [ ] Ich lese folgenden Artikel: [Walkthrough: Manipulating Data (C#) - ADO.NET | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/walkthrough-manipulating-data-csharp) und programmiere in C#, dass ein neuer Datensatz hinzugefügt, verändert und gelöscht werden kann.
  
- [ ] Ich bearbeite "Auftrag 2406 - Abfragen mit Cross Join" vom M106
  
- [ ] Ich bearbeite "Auftrag 2407 - Abfragen mit Inner und Outer Join" vom M106
  

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1.1 | DataContext-Problem | -   | Verbindung zwischen Code und Datenbank ist möglich | ja  |
| 2.1 | Programm starten | 1   | In der Datenbank wurde iPhone X hinzugefügt | ja  |
| 2.2 | Programm starten | 2   | In der Datenbank wird iPhone X zu iPhone XR umbenannt | nein |
| 2.3 | Programm starten | 3   | In der Datenbank wird iPhone XR entfernt | nein |
| 3.1 | Auftrag 0706 öffnen | -   | Auftrag erledigt | nein |
| 4.1 | Auftrag 0707 öffnen | -   | Auftrag erledigt | nein |

✍️ Heute habe ich mit Herrn Colic das Problem mit dem DataContext-String gelöst. Ich habe dort einfach den Dateipfad eingefügt, allerdings war ein komplizierterer String mit mehr Informationen nötig. Anschliessend konnte ich nach einigen Versuchen und kleiner Unterstützung von ChatGPT neue Datensätze hinzufügen lassen. Es hat mich richtig glücklich gemacht, das die neuen Datensätze direkt in MySQL übernommen werden. Zum Schluss habe ich versucht, dass man Datensätze verändern kann. Dabei konnte ich den Namen der iPhones nicht verändern lassen, da er der Primärschlüssel ist. (83 Wörter)

## 26.03.2024

- [x] Ich lösche die Tabelle iPhone und erstelle sie erneut allerdings mit einer Zahl als Primärschlüssel.
  
- [x] Ich programmiere, dass Alle Attribute bearbeitet werden können (inkl. Name)
  
- [x] Ich programmiere, dass ein ganzer Datensatz gelöscht werden kann
  
- [x] Ich programmiere, dass der Benutzer alle iPhones ausgeben kann
  

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1   | MySQL startem | SELECT * FROM iPhone WHERE Name = 'iPhone 11' | 1\\ | iPhone 11\\ |
| 2   | VS starten | 2. 2 (Verändern) 4. iPhone 15 6. 1 (Name) 8. iPhone XYZ | 1. Was möchten Sie tun? 3. Welches iPhone möchtest du bearbeiten 5. Was möchten Sie bearbeiten 7. Wie soll das iPhone neu heissen? | ja  |
| 3   | Testfall 2 | 2. 3 (Löschen) 4. iPhone XYZ | 1. Was möchten Sie tun? 3. Welches iPhone möchtest du löschen | ja  |
| 4   | VS starten | 2. 4 (Alles Auswählen) | 1. Was möchten Sie tun? 3. 1\\ | iPhone 11\\ |

✍️ Heute habe ich die Tabelle iPhone gelöscht und erneut, diesmal mit Zahl als Primary Key, erstellt. Danach habe ich mich um die Funktion`Verändern` gekümmert. Nun kann man vorhandene Daten zu den iPhones bearbeiten. Anschlissend habe ich einprogrammiert, dass man vorhandene iPhones aus der Datenbank `löschen` kann. Die letzte Funktion, die ich einprogrammiert habe, ist, dass man alle iPhones in der Datenbank `anzeigen` lassen kann. Da ich gegen Ende noch etwas Zeit übrig hatte, habe ich die Applikation so bearbeitet, dass sie für den Benutzer verständlich und übersichtlich ist. (88 Wörter)

## 02.04.2024

- [ ] Ich erstelle folgende eigenen Ausnahmebehandlungen:
  
  - [x] Wenn eine Zahl verlangt wird kann man keine Buchstaben drücken
    
  - [x] Wenn ein Datum verlangt wird kann man keine Buchstaben eingeben
    
  - [ ] ~~Wenn ein Name verlangt wird kann man nur vorhandene Namen eingeben~~
    
- [x] Ich bearbeite vom Modul 106 Auftrag 2412: TCL Transaktionen
  
- [x] Ich bearbeite vom Modul 106 Auftrag 2413: TCL Transaktionen Begriffe
  

| Testfall-nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1.1.1 | Code starten | 2. B | 1. Was möchten Sie tun 3. Die Eingabe muss eine Zahl zwischen 1 und 5 sein. Probieren Sie es bitte erneut! | ja  |
| 1.1.2 | Code starten | 2. 9 | 1. Was möchten Sie tun -- 3. Die Eingabe muss eine Zahl zwischen 1 und 5 sein. Probieren Sie es bitte erneut! | ja  |
| 1.2 | Ein iPhone verändern lassen | 2. 2 -- 4. 25-25-2038 | 1. Was möchten Sie bearbeiten? -- 3. Welchen Release hat das iPhone nun? -- 5. Dies ist kein akzeptables Datum. Probieren Sie es bitte erneut! | ja  |
| 1.3 | Code starten | 2. 2 -- 4. iPhone ABC | 1. Was möchten Sie tun -- 3. Welches iPhone möchten Sie bearbeiten? -- 5. Dieses iPhone ist nicht vorhanden. Probieren Sie es bitte erneut. | nein |
| 2   | Auftrag öffnen | -   | Auftrag vollständig erledigt | ja  |
| 3.1 | Auftrag öffnen | -   | Auftrag vollständig erledigt | ja  |

✍️ Heute habe ich Ausnahmebehandlungen programmiert. Das Programm stürzt nun nicht mehr ab, wenn eine Zahl verlangt ist man aber einen Buchstaben eingibt. Zudem erkennt das Programm wenn das Datum (z.B. der Release) nicht gültig ist, sodass der Benutzer ein anderes eingeben muss. Da ich mehrere Probleme hatte bei den Ausnahmen (Ich habe ausversehen den Nummernblock deaktiviert, wodurch der Computer andere Zahlen interpretiert hat) und ich noch vorarbeiten musste, habe ich mich dazu entschieden die Letzte Ausnahmebehandlung auszulassen, um an den Aufträgen für Modul 106 zu arbeiten. Ich konnte beide Aufträge zum Thema Transaktionen erledigen.

## Reflexion

##### Zusammenfassung:

Als erstes habe ich in dieser Lernepriode ein kleines Zahlen-Programm erstellt um LINQ zu verstehen. In diesem Programm kann man eine Bedingung auswählen und eine Zahl zwischen -100 und 100 angeben. Danach werden all die Zahlen angezeigt die, die Bedingungen erfüllen.

Ich habe mich mir ein Tutorial zu dictionnaries und Ausnahmebehandlungen angeschaut und mein Vokabeltrainer mit französisch Wörtern befüllt.

Dann habe ich mir mehrere Artikel zum Thema "LINQ TO SQL" durchgelesen und eine Datenbank für iPhones erstellt. Danach hatte ich ein Problem mit dem Verbinden der Datenbank, welches Herr Colic und ich zusammen beheben konnten. Im Anschluss konnte man mit meinem Programm schon neue iPhones hinzufügen. Da ich den Namen zum Primärschlüssel gemacht habe, konnte man ihn nicht verändern lassen. Deshalb musste ich die iPhones Tabelle in der Datenbank neu erstellen, diesmal mit einer Zahl als Primärschlüssel. Nun kann man iPhones verändern, löschen und anzeigen lassen. Abschlissend habe ich mein Programm benutzerfreunlich gemacht. Ich habe alles schön formatiert und einige Ausnahmebehandlungen hinzugefügt, damit das Programm nicht mehr abstürtzt. (168 Wörter)

##### Wie habe ich diese LP gearbeitet? Was war gut, was war schlecht?

Ich bin sehr zufrieden mit meiner Arbeitsweise. Ich war immer konzentriert und habe fast nie Pausen gemacht. Es hat mir auch Spass gemacht sich selber über LINQ To SQL zu informieren. Es gab immer wieder kleine Glücksmomente wenn etwas neues funktioniert hat. Nicht so gut war, dass es während jeder Sitzung immer 2 APs gab, die länger als 45min dauerten und 2 APs, die genau richtig waren.

##### Verbesserungsvorschlag (VBV):

Bei der Planung der APs überlege ich immer wie lange ich für ein AP benötige und rechne 5 bis 10min Problemlösezeit ein.

##### Wie möchte ich meine LP5 von Ihrer Arbeitsweise her gestalten?

Es würde wiedereinmal Spass machen eine Gruppenprojekt zu realisieren. Zudem möchte ich mein neues Wissen über LINQ und Datenbanken einbringen und vertiefen.

##### Was sind geeignete Abschlussprojekte?

Da ich während dem Modul 164 eine Datenbank zu Powerchairhockey gemacht habe würde ich gerne ein Programm schreiben, um mit diesen Daten zu arbeiten und ausgeben zu lassen. Dabei könnte ich mein neues Wissen über LINQ verwenden und gleichzeitig etwas nützliches für mein Hobby programmieren
