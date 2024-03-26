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

✍️ Heute habe ich mir Tutorials angeschaut zu LINQ und dictionaries. Zudem habe ich in Visual Studio verschiedene Befehle ausprobiert. Dabei bin ich so versunken, sodass ich den Vokabeltrainer schon fast fertig programmiert habe. Er funktioniert bisher aber nur mit dem Wort Hund und hat noch keine zufällige Auswahl der Wörter. Die Idee mit LINQ konnte ich auch schon ausprobieren und sie hat mir gefallen.

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
| 2   | MYSQL öffnen | SELECT * FROM iPhone WHERE Name = 'iPhone 11' | iPhone 11\\| 2019-09-10 \\| A13 Bionic | ja  |
| 3   | VS öffnen | -   | Befehl für das Verbinden ist zu sehen | nein |
| 4   | MYSQL öffnen | SELECT * FROM iPad WHERE Name = 'iPad Air 5th Gen' | iPad Air 5th Gen \\| 2022-18-03 \\| M1 | nein |

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 5   | VS öffnen | -   | Befehle um Daten der Tabelle hinzuzufügen, zu bearbeiten und zu löschen | nein |

✍️ Heute habe ich als erstes eine Datenbank mit Daten zu verschiedenen iPhone-Modellen erstellt. Danach habe ich in dem oben verlinkten Artikel unter "Getting Started Walkthroughs" Abschnitt:

- [Walkthrough: Simple Object Model and Query (C#) - ADO.NET | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/walkthrough-simple-object-model-and-query-csharp)
  
- [Walkthrough: Querying Across Relationships (C#) - ADO.NET | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/walkthrough-querying-across-relationships-csharp)
  

gelesen. Anschliessend habe ich die Verbindung zwischen Datenbank und C#-Code einprogrammiert (zu diesem Zeitpunkt noch nicht getestet). Als ich den Artikel gelesen habe, habe ich bemerkt, dass dort nichts zum Thema Tabellen via LINQ erstellen steht, weshalb ich ein fünftes Arbeitspaket geschrieben habe, welches im Artikel behandelt wird. Dann habe ich das Programm gestarten und dann ist ein Fehler aufgetreten, welchen ich nach einiger Zeit an Recherche nicht lösen konnte.

## 19.03.24

- [x] Ich löse das Problem mit dem DataContext
  
- [ ] Ich lese folgenden Artikel: [Walkthrough: Manipulating Data (C#) - ADO.NET | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/walkthrough-manipulating-data-csharp) und programmiere in C#, dass ein neuer Datensatz hinzugefügt, verändert und gelöscht werden kann.
  
- [ ] Ich bearbeite "Auftrag 0706 - Abfragen mit Cross Join" vom M106
  
- [ ] Ich bearbeite "Auftrag 0707 - Abfragen mit Inner und Outer Join" vom M106
  

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

- [ ] Ich lösche die Tabelle iPhone und erstelle sie erneut allerdings mit einer Zahl als Primärschlüssel.
  
- [ ] Ich programmiere, dass Alle Attribute bearbeitet werden können (inkl. Name)
  
- [ ] Ich programmiere, dass ein ganzer Datensatz gelöscht werden kann
  
- [ ] Ich formatiere die Ausgaben und lasse das Programm benutzerfreunlich aussehen
  

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1   | MySQL startem | SELECT * FROM iPhone WHERE Name = 'iPhone 11' | 1\\|iPhone 11\\| 2019-09-10 \\| A13 Bionic |     |
| 2   | VS starten | 2. 2 (Verändern) 4. iPhone 15 6. 1 (Name) 8. iPhone XYZ | 1. Was möchten Sie tun? 3. Welches iPhone möchtest du bearbeiten 5. Was möchten Sie bearbeiten 7. Wie soll das iPhone neu heissen? |     |
| 3   | VS starten | 2. 3 (Löschen) 4. iPhone XYZ | 1. Was möchten Sie tun? 3. Welches iPhone möchtest du löschen |     |
| 4   | VS starten | -   | Schnelle und einfache Oberfläche für den Benutzer ersichtlich |     |

✍️ Heute habe...

## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).
