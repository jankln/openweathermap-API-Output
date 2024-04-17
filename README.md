# Wetteranzeige mit OpenWeatherMap API

Dies ist ein einfaches Programm, das es ermöglicht, den aktuellen Wetterbericht für eine bestimmte Stadt abzurufen, indem die OpenWeatherMap API verwendet wird.

## Verwendung

1. Gebe die gewünschte Stadt ein, wenn das Programm gestartet wird. Die Temperatur, Wetterbedingungen und weitere Informationen werden dann angezeigt.

2. Das Programm verwendet einen API-Schlüssel von OpenWeatherMap, um auf die Wetterdaten zuzugreifen. Bitte ersetze den Wert der `apiKey`-Variable in der `Main`-Methode des Codes durch deinen eigenen API-Schlüssel, den du von OpenWeatherMap erhalten hast.

## Voraussetzungen

- .NET Core oder .NET Framework muss auf dem System installiert sein, um das Programm auszuführen.
- Ein gültiger API-Schlüssel von OpenWeatherMap ist erforderlich.

## Anmerkungen

- Die Wetterdaten werden in metrischen Einheiten angezeigt (Temperatur in Celsius, Windgeschwindigkeit in m/s usw.), da die API so konfiguriert ist.
- Das Programm verwendet die Newtonsoft.Json-Bibliothek, um die JSON-Antwort von OpenWeatherMap zu analysieren.

## Lizenz

Dieses Projekt ist unter der [MIT Lizenz](https://opensource.org/licenses/MIT) lizenziert.

## Autor

Dieses Programm wurde von Jan Klein erstellt.

