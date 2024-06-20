### DuckGame - implementera Designmönster
#### Väldigt enkelt "spel" , liknar sänka skepp men valde att göra det lite roligare, så spelarna som skapas skjuter ankor på ett spelbräde.

###### // Factory Method används för att skapa olika typer av ankor. Detta möjliggör att nya typer av ankor kan läggas till utan att ändra den kod som använder dessa fabriker.
###### // Adapter används för att anpassa Duck-objekt till IDuck-gränssnittet. Detta möjliggör att olika typer av ankor kan hanteras enhetligt.
###### // Observer används för att notifiera spelare om förändringar i spelet, såsom när en anka elimineras.
