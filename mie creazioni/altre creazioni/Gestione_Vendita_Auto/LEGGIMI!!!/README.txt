Programma che gestisce (in modo grossolano) 
un concessionario "FIAT".

Il programma, non � a prova di bomba, basta inserire
delle cazzate per far si ch� non funzioni pi�.
Quindi ATTENZIONE quando inserite i dati.

Esso prevede l'inserimento di nuovi tipi di AUTO 
e anche l'acquisto di tipi d'auto gi� presenti 
nella lista, tutto ci� dalla parte del proprietario.

Il Cliente puo' acquistare AUTO (cio� pu� acquistare 
le auto che vende il concessionario), sia nuove
che usate. Il prezzo varia in base all'auto 
acquistata, inoltre � prevista anche la rottamazione.
Se l'auto da rottamare � superiore a 1400 
di cilindrata, si ha sconto � di 3 mila euro, 
altrimenti lo sconto � di 1500 euro.


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
Esso � un campo Flag,
Se il valore � = N , l'auto non � stata ancora
consegnata, mentre se il valore � = S
l'auto � stata consegnata.
Invece se il valore � = X , l'auto � stata disdetta
Quindi � possibile anche disdirre un 'auto che si
voleva acquistare.



Quindi � anche possibile disdirre un auto (il cliente
che intendeva acquistare un auto e non l'ha gi�
ricevuta, quindi � in aspettativa che arrivi, pu�
disdirre l'acquisto).
