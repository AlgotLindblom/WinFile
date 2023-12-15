# Simpel konsolapp för att interagera med windows filsystem byggd i C#.

## Utveckling
Första steget är att bygga upp grundstenarna för programmet. Dessa består av funktioner för filmanipulering som att kopiera filer, stoppa in värden i filer och liknande. I detta steg väntar jag mig inga större svårigheter då det rör sig om relativt simpla funktioner med tydliga syften och C\# System.IO biblioteket har gott stöd för allt som programmet skall uträtta.

Andra steget handlar om att bygga upp en användbar miljö som kan tillåta användaren att uträtta något med programmet. Optimalt ska programmet antingen kunna simulera att flytta current working directory eller köras som en .exe från PATH. Detta väntar jag mig skall vara den mest utmanande delen av projektet. Om detta inte fungerar kommer användaren behöva lämna miljön, byta directory och köra programmet igen, viljket försämrar användarvänligheten.

För att uppnå detta behöver projektet använda **C\# Environment** metoden. **ENvironment** inehåller metoder för att navigera filsystemet och komma åt systemets miljövariabler. Funktionaliteten i metoden är mestadels begränsad till windows platformen. [Exempel](https://gist.github.com/AlgotLindblom/2f9f8980aec95d3ba5eecc3ff923391f)

## Kännda fel
