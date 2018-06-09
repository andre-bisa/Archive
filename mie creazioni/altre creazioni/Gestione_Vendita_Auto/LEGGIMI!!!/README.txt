Programma che gestisce (in modo grossolano) 
un concessionario "FIAT".

Il programma, non è a prova di bomba, basta inserire
delle cazzate per far si chè non funzioni più.
Quindi ATTENZIONE quando inserite i dati.

Esso prevede l'inserimento di nuovi tipi di AUTO 
e anche l'acquisto di tipi d'auto già presenti 
nella lista, tutto ciò dalla parte del proprietario.

Il Cliente puo' acquistare AUTO (cioè può acquistare 
le auto che vende il concessionario), sia nuove
che usate. Il prezzo varia in base all'auto 
acquistata, inoltre è prevista anche la rottamazione.
Se l'auto da rottamare è superiore a 1400 
di cilindrata, si ha sconto è di 3 mila euro, 
altrimenti lo sconto è di 1500 euro.


Inoltre la procedura, prevede anche l'acquisto di AUTO
usate (Il concessionario acquista auto usate da terze
persone) di qualsiasi marca, che hanno 
un'immatricolazione superiore all'anno 2000.
Una volta acquistate queste auto, esse vengono
inserite nella lista delle auto usate da vendere.

Una volta acquistata un auto (cioe il cliente acquista
un auto dal concessionario) viene creata la Fattura,
inoltre viene creato il file consegne.txt,
che contiene informazioni riguardanti la persona
che ha acquistato l'auto (nome e cognome), la data
dell'acquisto dell'auto (generata in automatico), 
la data stimata di consegna dell'auto (inserita dal
proprietario del concessionario) e il prezzo.

Da notare nel file consegne.txt l'ultimo campo.
Esso è un campo Flag,
Se il valore è = N , l'auto non è stata ancora
consegnata, mentre se il valore è = S
l'auto è stata consegnata.
Invece se il valore è = X , l'auto è stata disdetta
Quindi è possibile anche disdirre un 'auto che si
voleva acquistare.



Quindi è anche possibile disdirre un auto (il cliente
che intendeva acquistare un auto e non l'ha già
ricevuta, quindi è in aspettativa che arrivi, può
disdirre l'acquisto).
