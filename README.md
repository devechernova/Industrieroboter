# Industrieroboter

## Projektbeschreibung

Dieses Projekt wurde im Rahmen der Unterrichtsaufgabe zum Thema objektorientierte Programmierung in C# entwickelt.

Ziel der Anwendung ist die Verwaltung eines Industrieroboters mit einem Werkzeugkasten. Der Roboter kann verschiedene Werkzeuge aufnehmen, entfernen, benutzen, warten und statistisch auswerten.

Die Anwendung wurde als Konsolenanwendung umgesetzt und basiert auf einem Domänenmodell mit mehreren Klassen.

---

## Projektarchitektur

Das Projekt ist in zwei Bereiche aufgeteilt:

```text
Industrieroboter
│
├── Program.cs
│
└── Models
    ├── Werkzeug.cs
    ├── Bohrer.cs
    ├── Greifer.cs
    ├── Schweisser.cs
    └── Industrieroboter.cs
```

### Program.cs

Enthält die Konsolenanwendung mit Menüführung.

**Aufgaben:**

- Anzeige des Hauptmenüs
- Verarbeitung der Benutzereingaben
- Aufruf der Methoden des Industrieroboters
- Eingabevalidierung mittels `int.TryParse()`

### Models

Der Ordner enthält das Domänenmodell der Anwendung.

---

## Klassenbeschreibung

### Werkzeug

Basisklasse für alle Werkzeuge.

#### Attribute

```csharp
private string art;
protected int verschleiss;
```

#### Aufgaben

- Speichert die Werkzeugart
- Speichert den aktuellen Verschleiß
- Stellt gemeinsame Funktionen für alle Werkzeugarten bereit

#### Methoden

##### `Ausgeben()`

Gibt Informationen über das Werkzeug zurück.

##### `Benutzen(int wert)`

Erhöht den Verschleiß um den übergebenen Wert.

Der maximale Verschleiß ist auf **100 %** begrenzt.

##### `Warten()`

Setzt den Verschleiß auf **0 %** zurück.

##### `GetVerschleiss()`

Liefert den aktuellen Verschleißwert.

---

### Bohrer

Erbt von der Klasse `Werkzeug`.

#### Zusätzliches Attribut

```csharp
private int groesse;
```

#### Aufgabe

Repräsentiert einen Bohrer mit einer bestimmten Größe.

#### Überschriebene Methode

##### `Ausgeben()`

Beispiel:

```text
Bohrer mit Groesse 10 (Verschleiss 20 %).
```

---

### Greifer

Erbt von der Klasse `Werkzeug`.

#### Aufgabe

Repräsentiert einen Greifer.

#### Überschriebene Methode

##### `Ausgeben()`

Beispiel:

```text
Greifer (Verschleiss 15 %).
```

---

### Schweisser

Erbt von der Klasse `Werkzeug`.

#### Aufgabe

Repräsentiert einen Schweißwerkzeug.

#### Überschriebene Methode

##### `Ausgeben()`

Beispiel:

```text
Schweisser (Verschleiss 50 %).
```

---

### Industrieroboter

Verwaltet den Werkzeugkasten des Roboters.

#### Attribute

```csharp
private const int maxAnzWerkzeuge = 10;
private Werkzeug[] werkzeugkasten;
```

Der Werkzeugkasten besitzt **10 Plätze (0 bis 9)**.

---

## Methoden des Industrieroboters

### `WerkzeugHinzufuegen()`

Fügt ein Werkzeug an einem bestimmten Platz hinzu.

Prüft:

- ob der Platz existiert
- ob der Platz bereits belegt ist

---

### `WerkzeugEntfernen()`

Entfernt ein Werkzeug von einem bestimmten Platz.

Prüft:

- ob der Platz existiert
- ob ein Werkzeug vorhanden ist

---

### `WerkzeugkastenAnzeigen()`

Zeigt alle Plätze des Werkzeugkastens an.

Beispiel:

```text
Platz 0: leer
Platz 1: Bohrer mit Groesse 10 (Verschleiss 40 %).
```

---

### `WerkzeugBenutzen()`

Erhöht den Verschleiß eines Werkzeugs.

Der maximale Verschleiß beträgt **100 %**.

---

### `WerkzeugWarten()`

Setzt den Verschleiß eines Werkzeugs auf **0 %** zurück.

---

### `StatistikAnzeigen()`

Zeigt statistische Informationen über den Werkzeugkasten an.

Ausgegeben werden:

- Anzahl freier Plätze
- Anzahl belegter Plätze
- Gesamtverschleiß
- Durchschnittlicher Verschleiß
- Am stärksten verschlissenes Werkzeug

Beispiel:

```text
Freie Plaetze: 7
Belegte Plaetze: 3
Gesamtverschleiss: 162
Durchschnittlicher Verschleiss: 54
Staerkst verschlissenes Werkzeug:
Schweisser (Verschleiss 88 %).
```

---

## Menüfunktionen

```text
=== Werkzeugkasten-Verwaltung ===

1. Werkzeug hinzufügen
2. Werkzeug entfernen
3. Werkzeugkasten anzeigen
4. Werkzeug benutzen
5. Werkzeug warten
6. Beenden
7. Statistik
```

---

## Fehlerbehandlung

Zur Vermeidung von Programmabstürzen wird die Benutzereingabe mit

```csharp
int.TryParse()
```

validiert.

Ungültige Eingaben werden abgefangen und führen zur erneuten Anzeige des Menüs.

Beispiel:

```text
Bitte eine Zahl eingeben.
```

---

## Verwendete OOP-Konzepte

Das Projekt verwendet folgende Konzepte der objektorientierten Programmierung:

- Klassen
- Objekte
- Vererbung
- Polymorphismus
- Kapselung
- Konstruktoren
- Arrays
- Methodenüberschreibung (`override`)
- Zugriffsmodifizierer (`private`, `protected`, `public`)

---

## Zusatzfunktionen

Zusätzlich zu den Pflichtaufgaben wurden folgende Erweiterungen umgesetzt:

- Statistikfunktion
- Berechnung des durchschnittlichen Verschleißes
- Ermittlung des am stärksten verschlissenen Werkzeugs
- Eingabevalidierung mit `TryParse()`
- Begrenzung des Verschleißes auf maximal 100 %

---

## Fazit

Mit diesem Projekt wurde eine Konsolenanwendung zur Verwaltung eines Industrieroboters entwickelt. Dabei wurden die Grundlagen der objektorientierten Programmierung in C# angewendet, darunter Klassen, Vererbung, Methodenüberschreibung und Kapselung.

Zusätzlich wurden Funktionen wie Statistik und Eingabevalidierung implementiert, um die Anwendung robuster und benutzerfreundlicher zu gestalten.