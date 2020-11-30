using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProvaVerifica1
{
    class Program
    {
        public struct Canzone
        {
            public string codice;
            public string autore;
            public string titolo;
            public string nome;
            public int tempo;
            public string genere;
            public decimal prezzo;
        }

        static void Main(string[] args)
        {           
            //Varaibili
            Canzone[] eleCanzoni = new Canzone[100];            //Contiene tutte le canzoni
            int numC = 0;        //numero di canzoni
            ConsoleKeyInfo scelta = default;
            string[] eleGeneri = new string[30];           //Contiene i generi
            int numG = 0;          //numero di generi         
            bool preinserito = false;

            do
            {
                int x = 0;
                Console.Clear();


                //menù
                Console.WriteLine("Benvenuto nell'elenco canzoni di Angioletti");
                Console.WriteLine("".PadRight(30, '_'));
                Console.WriteLine("[0] Preinserimento dati");
                Console.WriteLine("[1] Nuova canzone");
                Console.WriteLine("[2] Elenca canzoni per codice");
                Console.WriteLine("[3] Modifica una canzone");
                Console.WriteLine("[4] Cancella una traccia");
                Console.WriteLine("[5] Cancella una categoria");
                Console.WriteLine("[6] Calcola la media di prezzo di un genere");
                Console.WriteLine("[7] Prodotto più costoso");
                Console.WriteLine("[8] Prodotto meno costoso");
                Console.WriteLine("[9] Prodotto meno costoso di un genere");
                Console.WriteLine("[a] Cerca una canzone");
                Console.WriteLine("[b] Elenca canzoni dalla più costosa");
                Console.WriteLine("[c] Elimina le canzoni di durata inferiore a quella scelta\n");
                Console.WriteLine("[U] Esci");

                if (numC == 0)
                    Console.WriteLine("Ricorda che non hai ancora inserito nessuna canzone");

                scelta = Console.ReadKey(true);

                Console.Clear();
                switch (scelta.KeyChar.ToString())
                {
                    case "0":           //Preinserimento dati
                        {
                                if(preinserito)
                                {
                                Console.WriteLine("Hai già inserito questi prodotti");
                                }
                                if(!preinserito)
                                {
                                eleCanzoni[numC].codice = "tr01";
                                eleCanzoni[numC].autore = "Slait";
                                eleCanzoni[numC].titolo = "Altalene";
                                eleCanzoni[numC].nome = "Altalene.mp3";
                                eleCanzoni[numC].tempo = 156;
                                eleCanzoni[numC].genere = "Trap";
                                if (numG != 0)          //se non sono i primi prodotti inseriti
                                {
                                    int a = 0;
                                    bool found = false;
                                    while (a < numG || found)    
                                    {
                                        if (eleCanzoni[numC].genere == eleGeneri[a])
                                        {
                                            found = true;
                                        }

                                        a += 1;
                                    }
                                    if (!found)
                                    {
                                        eleGeneri[numG] = eleCanzoni[numC].genere;
                                        numG = numG + 1;
                                    }
                                }
                                else
                                {
                                    eleGeneri[numG] = eleCanzoni[numC].genere;
                                    numG = numG + 1;
                                }
                                    eleCanzoni[numC].prezzo = 800;
                                numC = numC + 1;

                                eleCanzoni[numC].codice = "tr02";
                                eleCanzoni[numC].autore = "Ernia";
                                eleCanzoni[numC].titolo = "Superclassico";
                                eleCanzoni[numC].nome = "Super.mp3";
                                eleCanzoni[numC].tempo = 204;
                                eleCanzoni[numC].genere = "Pop";
                                if (numG != 1)          //Serve questo ciclo se si sono già inserite altre canzoni
                                {
                                    int a = 0;
                                    bool found = false;
                                    while (a < numG || found)         // Mantieni un elenco di generi
                                    {
                                        if (eleCanzoni[numC].genere == eleGeneri[a])
                                        {
                                            found = true;
                                        }

                                        a += 1;
                                    }
                                    if (!found)
                                    {
                                        eleGeneri[numG] = eleCanzoni[numC].genere;
                                        numG = numG + 1;
                                    }
                                }
                                else
                                {
                                    eleGeneri[numG] = eleCanzoni[numC].genere;
                                    numG = numG + 1;
                                }
                                eleCanzoni[numC].prezzo = 650;
                                numC = numC + 1;

                                eleCanzoni[numC].codice = "tr03";
                                eleCanzoni[numC].autore = "Slait";
                                eleCanzoni[numC].titolo = "X1 Mex";
                                eleCanzoni[numC].nome = "X1 Mex.mp3";
                                eleCanzoni[numC].tempo = 136;
                                eleCanzoni[numC].genere = "Trap";
                                eleCanzoni[numC].prezzo = 700;
                                numC = numC + 1;

                                eleCanzoni[numC].codice = "tr04";
                                eleCanzoni[numC].autore = "Dj Ponte";
                                eleCanzoni[numC].titolo = "Blue";
                                eleCanzoni[numC].nome = "Blue.mp3";
                                eleCanzoni[numC].tempo = 240;
                                eleCanzoni[numC].genere = "Disco";
                                if (numG != 2)
                                {
                                    int a = 0;
                                    bool found = false;
                                    while (a < numG || found)         // Mantieni un elenco di generi
                                    {
                                        if (eleCanzoni[numC].genere == eleGeneri[a])
                                        {
                                            found = true;
                                        }

                                        a += 1;
                                    }
                                    if (!found)
                                    {
                                        eleGeneri[numG] = eleCanzoni[numC].genere;
                                        numG = numG + 1;
                                    }
                                }
                                else
                                {
                                    eleGeneri[numG] = eleCanzoni[numC].genere;
                                    numG = numG + 1;
                                }
                                eleCanzoni[numC].prezzo = 600;
                                numC = numC + 1;

                                eleCanzoni[numC].codice = "tr05";
                                eleCanzoni[numC].autore = "Martin Garrix";
                                eleCanzoni[numC].titolo = "Animals";
                                eleCanzoni[numC].nome = "Animals.mp3";
                                eleCanzoni[numC].tempo = 162;
                                eleCanzoni[numC].genere = "Pop";
                                eleCanzoni[numC].prezzo = 900;
                                numC = numC + 1;

                                eleCanzoni[numC].codice = "tr06";
                                eleCanzoni[numC].autore = "Il pagante";
                                eleCanzoni[numC].titolo = "Settimana bianca";
                                eleCanzoni[numC].nome = "Settimana.mp3";
                                eleCanzoni[numC].tempo = 195;
                                eleCanzoni[numC].genere = "Disco";
                                eleCanzoni[numC].prezzo = 800;
                                numC = numC + 1;

                                eleCanzoni[numC].codice = "tr07";
                                eleCanzoni[numC].autore = "Linking Park";
                                eleCanzoni[numC].titolo = "Good Goodbye";
                                eleCanzoni[numC].nome = "Goodbye.mp3";
                                eleCanzoni[numC].tempo = 240;
                                eleCanzoni[numC].genere = "Pop";
                                eleCanzoni[numC].prezzo = 700;
                                numC = numC + 1;

                                preinserito = true;

                                Console.WriteLine("Prodotti inseriti correttamente");
                                }
                                
                            scelta = default;

                            break;
                        }
                    
                    
                    case "1":           //aggingi nuove canzoni
                        {
                            bool ripeti = true;

                            while (ripeti)
                            {
                                if (numC >= 100)         //Controlla che ci siano spazi disponibili
                                {
                                    Console.WriteLine("Hai inserito toprri prodotti");
                                    break;
                                }


                                //Contatori
                                x = 0;

                                bool cerca = true;          //Continua solo con codici validi
                                Canzone nuova = default;

                                Console.Write("Inserisci il codice della traccia:  ");
                                nuova.codice = Console.ReadLine();            //Inserisci il codice


                                if (String.IsNullOrWhiteSpace(nuova.codice) == true)          //Controlla che il codice non sia vuoto
                                {
                                    Console.WriteLine("Devi inserire il codice");
                                    cerca = false;
                                }


                                while (x < numC)         // Controlla che il codice non sia già stato usato  
                                {

                                    if (eleCanzoni[x].codice == nuova.codice)
                                    {
                                        Console.WriteLine($"Hai già usato questo codice per la canzone {eleCanzoni[x].titolo}");
                                        cerca = false;
                                    }

                                    x = x + 1;
                                }


                                if (cerca)          //Se il codice non è mai stato usato inserisce il resto, sennò ricomincia
                                {
                                    Console.Write("Inserisci il nome dell'autore:  ");
                                    nuova.autore = Console.ReadLine();

                                    Console.Write("Inserisci il titolo della canzone: ");
                                    nuova.titolo = Console.ReadLine();

                                    Console.Write("Inserisci il nome della traccia:  ");
                                    nuova.nome = Console.ReadLine() + ".mp3";

                                    Console.Write("Inserisci la durata della traccia:  ");
                                    if (!int.TryParse(Console.ReadLine(), out int durata))
                                    {
                                        Console.WriteLine("Errore, non hai inserito un prezzo numerico");
                                        break;
                                    }
                                    if (durata < 5 || durata >300)
                                    {
                                        Console.WriteLine("La canzone deve durare fra 5 e 300 secondi");
                                        break;
                                    }

                                    nuova.tempo = durata;
                                    Console.Write("Inserisci il genere della canzone:  ");
                                    nuova.genere = Console.ReadLine();

                                    int a = 0;
                                    bool found = false;
                                    while (a < numG || found)         // Mantieni un elenco di generi
                                    {
                                        if (nuova.genere == eleGeneri[a])
                                        {
                                            found = true;
                                        }

                                        a += 1;
                                    }
                                    if (!found)
                                    {
                                        eleGeneri[numG] = nuova.genere;
                                        numG = numG + 1;
                                    }

                                    Console.Write("Inserisci il prezzo dei diritti:  ");            //Finisce di inserire i dati
                                    if (!decimal.TryParse(Console.ReadLine(), out decimal prezzo))
                                    {
                                        Console.WriteLine("Errore, non hai inserito un prezzo numerico");
                                        break;
                                    }
                                    if (prezzo < 100 || prezzo>1000)
                                    {
                                        Console.WriteLine("Il prezzo deve essere compreso tra 100 e 1000 euro");
                                        break;
                                    }

                                    nuova.prezzo = prezzo;

                                    nuova = eleCanzoni[numC];
                                    numC = numC + 1;
                                }

                                Console.WriteLine("Premi un tasto per continuare, 0 per tornare al menù");
                                scelta = Console.ReadKey(true);
                                if (scelta.KeyChar.ToString() == "0")
                                    ripeti = false;
                            }

                            break;
                        }


                    case "2":           //Eleneco
                        {
                            if(numC==0)
                            {
                                Console.WriteLine("Devi prima inserire dei prodotti");
                                break;
                            }
                            
                            x = 0;
                            Console.WriteLine("Elenco delle canzoni:\n");

                            int b = 0;
                            Canzone tmp = default;
                            x = 0;
                            while (x < (numC - 1))
                            {
                                b = x + 1;
                                while (b < numC)
                                {
                                    if (String.Compare(eleCanzoni[x].codice, eleCanzoni[b].codice) > 0)
                                    {
                                        tmp = eleCanzoni[x];
                                        eleCanzoni[x] = eleCanzoni[b];
                                        eleCanzoni[b] = tmp;
                                    }

                                    b = b + 1;
                                }
                                x = x + 1;
                            }

                            x = 0;
                            while (x < numC)
                            {

                                if (eleCanzoni[x].codice != default(string))            //Evita che vengano scritte canzoni eliminate, se no vengono scritte
                                {
                                    Console.WriteLine("".PadRight(20, '_'));

                                    Console.WriteLine(eleCanzoni[x].codice);
                                    Console.WriteLine($"\nAutore: {eleCanzoni[x].autore}");
                                    Console.WriteLine($"Titolo: {eleCanzoni[x].titolo}");
                                    Console.WriteLine($"Nome traccia: {eleCanzoni[x].nome}");
                                    Console.WriteLine($"Durata traccia: {eleCanzoni[x].tempo}");
                                    Console.WriteLine($"Genere canzone: {eleCanzoni[x].genere}");
                                    Console.WriteLine($"Prezzo diritti: {eleCanzoni[x].prezzo}");
                                }

                                x = x + 1;
                            }

                            break;
                        }


                    case "3":           //Modifica
                        {
                            if (numC == 0)
                            {
                                Console.WriteLine("Devi prima inserire dei prodotti");
                                break;
                            }

                            x = 0;
                            string cerca = default(string);
                            Console.Write("Inserisci il codice di una canzone:  ");
                            cerca = Console.ReadLine();

                            while (x < numC)
                            {
                                Console.Clear();

                                if (string.Compare(cerca, eleCanzoni[x].codice) == 0)          //Se trova un prodotto. (cerca == eleCanzoni[x].codice)
                                {
                                    do
                                    {
                                        Console.Clear();
                                        
                                        int k = 0;
                                        Console.WriteLine(eleCanzoni[x].nome);
                                        Console.WriteLine("[1] Modifica il codice");
                                        Console.WriteLine("[2] Cambia autore");
                                        Console.WriteLine("[3] Modifica il titolo");
                                        Console.WriteLine("[4] Modifica il nome della traccia");
                                        Console.WriteLine("[5] Cambia la durata");
                                        Console.WriteLine("[6] Cambia il genere");
                                        Console.WriteLine("[7] Modifica il prezzo\n");
                                        Console.WriteLine("[0] Torna al menù");

                                        scelta = Console.ReadKey(true);

                                        switch (scelta.KeyChar.ToString())
                                        {
                                            case "1":           //Cambia il titolo
                                                {
                                                    Console.Write($"Inserisci il nuovo codice, prima era {eleCanzoni[x].codice}:  ");
                                                    string nuovoCodice = Console.ReadLine();
                                                    if (String.IsNullOrWhiteSpace(nuovoCodice) == true)          //Controlla che il codice non sia vuoto
                                                    {
                                                        Console.WriteLine("Devi inserire il codice");
                                                        break;
                                                    }

                                                    bool found = false;
                                                    while (k < numC)         // Controlla che il codice non sia già stato usato  
                                                    {

                                                        if (nuovoCodice == eleCanzoni[k].codice)
                                                        {
                                                            Console.WriteLine($"Hai già usato questo codice per la canzone {eleCanzoni[k].titolo}");
                                                            found = true;
                                                            break;
                                                        }

                                                        k = k + 1;
                                                    }
                                                    if (!found)
                                                    {
                                                        eleCanzoni[x].codice = nuovoCodice;
                                                        Console.Write("Traccia modificata correttamente!");
                                                    }

                                                        break;
                                                }

                                            case "2":           //Cambia l'autore
                                                {
                                                    Console.Write($"Inserisci il nome dell'autore, prima era {eleCanzoni[x].autore}:  ");
                                                    eleCanzoni[x].autore = Console.ReadLine();
                                                    Console.Write("Traccia modificata correttamente!");
                                                    break;
                                                }

                                            case "3":           //Cambia il titolo della canzone
                                                {
                                                    Console.Write($"Inserisci il titolo della canzone, prima era {eleCanzoni[x].titolo}:  ");
                                                    eleCanzoni[x].titolo = Console.ReadLine();
                                                    Console.Write("Traccia modificata correttamente!");
                                                    break;
                                                }

                                            case "4":           //Cambia il nome della traccia
                                                {
                                                    Console.Write($"Inserisci il nome della traccia, prima era {eleCanzoni[x].nome}:  ");
                                                    eleCanzoni[x].nome = Console.ReadLine() + ".mp3";
                                                    Console.Write("Traccia modificata correttamente!");
                                                    break;
                                                }

                                            case "5":           //Cambia la durata della canzone
                                                {
                                                    Console.Write($"Inserisci la durata della traccia, prima era {eleCanzoni[x].tempo}:  ");
                                                    if (!int.TryParse(Console.ReadLine(), out int durata))          //Constrolla se sia un intero
                                                    {
                                                        Console.WriteLine("Errore, non hai inserito un prezzo numerico");
                                                        break;
                                                    }
                                                    if (durata <= 5 || durata > 300)            //Controlla che tempo sia positivo
                                                    {
                                                        Console.WriteLine("La canzone deve durare tra 5 e 300 secondi");
                                                        break;
                                                    }
                                                    eleCanzoni[numC].tempo = durata;
                                                    Console.Write("Traccia modificata correttamente!");
                                                    break;
                                                }

                                            case "6":           //Cambia il genere
                                                {
                                                    int a = 0;
                                                    bool found = false;

                                                    Console.Write($"Inserisci il genere della canzone, prima era {eleCanzoni[x].genere}:  ");
                                                    eleCanzoni[numC].genere = Console.ReadLine();

                                                    while (a < numG)         // Mantieni un eleCanzoni di generi
                                                    {
                                                        if (eleCanzoni[numC].genere == eleGeneri[a])
                                                        {
                                                            found = true;
                                                        }

                                                        a += 1;
                                                    }
                                                    if (!found)
                                                    {
                                                        eleGeneri[numG] = eleCanzoni[numC].genere;
                                                        numG = numG + 1;
                                                    }
                                                    Console.Write("Traccia modificata correttamente!");
                                                    break;
                                                }

                                            case "7":           //Cambia il prezzo dei diritti
                                                {
                                                    Console.Write($"Inserisci il prezzo dei diritti, prima era {eleCanzoni[x].prezzo}:  ");
                                                    if (!decimal.TryParse(Console.ReadLine(), out decimal prezzo))          //Controlla che il prezzo inserito sia un decimal
                                                    {
                                                        Console.WriteLine("Errore, non hai inserito un prezzo numerico");
                                                        break;
                                                    }
                                                    if (prezzo < 100 || prezzo > 1000)            //Controlla che il prezzo non sia negativo
                                                    {
                                                        Console.WriteLine("Il prezzo deve essere compreso tra 100 e 1000 euro");
                                                        break;
                                                    }
                                                    eleCanzoni[numC].prezzo = prezzo;
                                                    Console.Write("Traccia modificata correttamente!");
                                                    break;
                                                }

                                            case "0":
                                                { break; }

                                            default:            //Default
                                                {
                                                    Console.WriteLine("Comando errato");

                                                    break;
                                                }

                                        }

                                        if (scelta.KeyChar.ToString() != "0")
                                        {
                                            Console.WriteLine("Premi un tasto per continuare");
                                            Console.ReadKey(true);
                                        }

                                    } while (scelta.KeyChar.ToString() != "0");

                                    break;
                                }

                                else
                                    Console.WriteLine("Nessuna traccia trovata");

                                x = x + 1;
                            }

                            break;
                        }


                    case "4":           //Elimina
                        {
                            if (numC == 0)
                            {
                                Console.WriteLine("Devi prima inserire dei prodotti");
                                break;
                            }

                            string cerca = default(string);

                            Console.Write("Inserisci il codice di una canzone:  ");
                            cerca = Console.ReadLine();

                            while (x < numC)         //Se lo trova esce per un break (riga 443)
                            {
                                Console.Clear();

                                if (cerca == eleCanzoni[x].codice)          //Quando trova la sovrascrive con quella in ultima posizione
                                {
                                    eleCanzoni[x] = eleCanzoni[numC - 1];

                                    Console.Write("Traccia eliminata correttamente!");
                                    numC = numC - 1;

                                    break;
                                }

                                else            //Se non lo trova lo scrive, poi lo cancella in riga 434
                                    Console.WriteLine($"Traccia {cerca} non trovata");

                                x = x + 1;
                            }

                            break;
                        }


                    case "5":           //Cancella una categoria
                        {
                            if (numC == 0)
                            {
                                Console.WriteLine("Devi prima inserire dei prodotti");
                                break;
                            }

                            //Contatori
                            x = 0;
                            int c = 0;
                            int nc = 0;

                            string categoria = default(String);

                            Console.WriteLine("Scegli un genere tra:");
                            while (c < numG)           //Elenca tutte le categorie
                            {
                                Console.WriteLine(eleGeneri[c]);

                                c += 1;
                            }

                            categoria = Console.ReadLine();     //Scegli una categoria
                            Console.Clear();

                            while (x < numC)
                            {
                                if (string.Compare(eleCanzoni[x].genere, categoria) == 0)          //eleCanzoni[x].genere == categoria
                                {
                                    eleCanzoni[x] = eleCanzoni[numC - 1];
                                    numC = numC - 1;
                                    nc += 1;
                                }
                                else
                                    x = x + 1;
                            }

                            if (nc == 0)         //Controlla che la categoria esista
                                Console.WriteLine("La categoria selezionata non esiste!");

                            if (nc > 0)
                            {
                                Console.WriteLine($"{nc} prodotti eliminati correttamente");

                                x = 0;
                                while (x < numG)
                                {
                                    if (eleGeneri[x] == categoria)
                                    {
                                        eleGeneri[x] = eleGeneri[numG - 1];
                                        numG = numG - 1;
                                        break;
                                    }
                                    x += 1;
                                }
                            }

                            break;
                        }


                    case "6":           //Media
                        {
                            if (numC == 0)
                            {
                                Console.WriteLine("Devi prima inserire dei prodotti");
                                break;
                            }

                            //Contatori
                            int c = 0;
                            int n = 0;

                            string categoria = default(String);
                            decimal somma = default(decimal);           //Accumulatore
                            decimal media = default(decimal);

                            Console.WriteLine("Scegli una categoria tra:");
                            while (c < numG)           //Elenca tutte le categorie
                            {
                                Console.WriteLine(eleGeneri[c]);

                                c += 1;
                            }

                            categoria = Console.ReadLine();     //Scegli una categoria
                            Console.Clear();

                            while (x < numC)
                            {
                                if (string.Compare(eleCanzoni[x].genere, categoria) == 0)          //eleCanzoni[x].genere == categoria
                                {
                                    somma = somma + eleCanzoni[x].prezzo;
                                    n = n + 1;
                                }

                                x = x + 1;
                            }

                            if (n == 0)         //Controlla che la categoria esista
                                Console.WriteLine("La categoria selezionata non esiste!");

                            else        //Media
                            {
                                media = somma / n;
                                Console.WriteLine($"La media delle canzoni {categoria} è {media}");
                            }

                            break;
                        }


                    case "7":           //Prezzo più alto
                        {
                            if (numC == 0)
                            {
                                Console.WriteLine("Devi prima inserire dei prodotti");
                                break;
                            }

                            decimal pre = default;          //Contiene il prezzo più alto al momento
                            int b = 0;

                            while (x < numC)
                            {
                                if (pre < eleCanzoni[x].prezzo)         //Controlla se il prezzo è minore lo aggiorna
                                {
                                    pre = eleCanzoni[x].prezzo;
                                    b = x;          //numero del prodotto con prezzo maggiore
                                }

                                x = x + 1;
                            }

                            Console.WriteLine($"La canzone con il prezzo più alto è {eleCanzoni[b].nome} che costa {pre}");

                            break;
                        }


                    case "8":           //Prezzo più basso
                        {
                            if (numC == 0)
                            {
                                Console.WriteLine("Devi prima inserire dei prodotti");
                                break;
                            }

                            decimal pre = eleCanzoni[x].prezzo;
                            int b = 0;

                            while (x < numC)
                            {
                                if (pre > eleCanzoni[x].prezzo)         //Controlla se il prezzo è minore lo aggiorna
                                {
                                    pre = eleCanzoni[x].prezzo;
                                    b = x;          //numero del prodotto con prezzo minore
                                }

                                x = x + 1;
                            }

                            Console.WriteLine($"La canzone con il prezzo più basso è {eleCanzoni[b].nome} che costa {pre}");

                            break;
                        }


                    case "9":           //Prezzo più basso di una categoria
                        {
                            if (numC == 0)
                            {
                                Console.WriteLine("Devi prima inserire dei prodotti");
                                break;
                            }

                            int b = 0;
                            int c = 0;
                            bool primo = true;          //Vero: il primo prodotto non è stato trovato
                            decimal pre = default;
                            string categoria = default;

                            Console.WriteLine("Scegli un genere tra:");
                            while (c < numG)           //Elenca tutte le categorie
                            {
                                Console.WriteLine(eleGeneri[c]);

                                c += 1;
                            }

                            categoria = Console.ReadLine();     //Scegli una categoria
                            Console.Clear();

                            while (x < numC)
                            {
                                if (categoria == eleCanzoni[x].genere)         //Controlla se il prezzo è minore lo aggiorna
                                {
                                    if (primo)
                                    {
                                        pre = eleCanzoni[x].prezzo;
                                        primo = false;
                                        b = x;
                                    }

                                    if (pre > eleCanzoni[x].prezzo)
                                    {
                                        pre = eleCanzoni[x].prezzo;
                                        b = x;          //numero del prodotto con prezzo minore
                                    }
                                }

                                x = x + 1;
                            }

                            if (primo)
                            {
                                Console.WriteLine("Nessun prodotto trovato");
                            }

                            else
                                Console.WriteLine($"La canzone con il prezzo più basso della categoria {categoria} è {eleCanzoni[b].nome} che costa {pre}");

                            break;
                        }


                    case "a":           //Cerca un prodotto
                        {
                            if (numC == 0)
                            {
                                Console.WriteLine("Devi prima inserire dei prodotti");
                                break;
                            }

                            string cerca = default;

                            Console.Write("Inserisci il nome o il codice della canzone:  ");
                            cerca = Console.ReadLine();
                            int b = 0;

                            Console.Write("\nCodice traccia\tNome traccia\tTitolo canzone\tNome autore\tPrezzo diritti\tDurata canzone\n");

                            while (x < numC)
                            {
                                if (eleCanzoni[x].nome.Contains(cerca) || eleCanzoni[x].titolo.Contains(cerca) || cerca == eleCanzoni[x].codice)
                                {
                                    Console.Write($"{eleCanzoni[x].codice}\t");
                                    Console.Write($"{eleCanzoni[x].nome}\t");
                                    Console.Write($"{eleCanzoni[x].titolo}\t");
                                    Console.Write($"{eleCanzoni[x].autore}\t");
                                    Console.Write($"{eleCanzoni[x].prezzo}\t");
                                    Console.Write($"{eleCanzoni[x].tempo}\n");
                                    b = b + 1;
                                }
                                x += 1;
                            }

                            Console.WriteLine($"\n\n{b} Canzoni trovate\n\n");


                            break;
                        }


                    case "b":           //Eleneco
                        {
                            if (numC == 0)
                            {
                                Console.WriteLine("Devi prima inserire dei prodotti");
                                break;
                            }

                            x = 0;
                            Console.WriteLine("Elenco delle canzoni:\n");

                            int b = 0;
                            Canzone tmp = default;
                            x = 0;
                            while (x < (numC - 1))
                            {
                                b = x + 1;
                                while (b < numC)
                                {
                                    if (eleCanzoni[x].prezzo < eleCanzoni[b].prezzo)
                                    {
                                        tmp = eleCanzoni[x];
                                        eleCanzoni[x] = eleCanzoni[b];
                                        eleCanzoni[b] = tmp;
                                    }

                                    b = b + 1;
                                }
                                x = x + 1;
                            }


                            x = 0;
                            while (x < numC)
                            {

                                if (eleCanzoni[x].codice != default(string))            //Evita che vengano scritte canzoni eliminate, se no vengono scritte
                                {
                                    Console.WriteLine("".PadRight(20, '_'));

                                    Console.WriteLine(eleCanzoni[x].codice);
                                    Console.WriteLine($"\nAutore: {eleCanzoni[x].autore}");
                                    Console.WriteLine($"Titolo: {eleCanzoni[x].titolo}");
                                    Console.WriteLine($"Nome traccia: {eleCanzoni[x].nome}");
                                    Console.WriteLine($"Durata traccia: {eleCanzoni[x].tempo}");
                                    Console.WriteLine($"Genere canzone: {eleCanzoni[x].genere}");
                                    Console.WriteLine($"Prezzo diritti: {eleCanzoni[x].prezzo}");
                                }

                                x = x + 1;
                            }

                            break;
                        }


                    case "c":           //Cancella una categoria
                        {
                            if (numC == 0)
                            {
                                Console.WriteLine("Devi prima inserire dei prodotti");
                                break;
                            }

                            //Contatori
                            x = 0;
                            int nc = 0;

                            Console.WriteLine("Inserisci la durata minima delle canzoni da tanere");
                            if (!int.TryParse(Console.ReadLine(), out int durata))
                            {
                                Console.WriteLine("Errore, non hai inserito un prezzo numerico");
                                break;
                            }

                            while (x < numC)
                            {
                                if (eleCanzoni[x].tempo < durata)
                                {
                                    eleCanzoni[x] = eleCanzoni[numC - 1];
                                    numC = numC - 1;
                                    nc += 1;
                                }
                                else
                                    x = x + 1;
                            }

                            if (nc == 0)
                                Console.WriteLine("La categoria selezionata non esiste!");

                            if (nc > 0)
                            {
                                Console.WriteLine($"{nc} prodotti eliminati correttamente");
                            }

                            break;
                        }



                    case "u":
                        {
                            break;
                        }


                    default:
                        {
                            Console.WriteLine("Comando errato");

                            break;
                        }

                }

                if (scelta.KeyChar.ToString() != "0" && scelta.KeyChar.ToString() != "u")
                {
                    Console.WriteLine("Premi un tasto per continuare");
                    Console.ReadKey(true);
                }           //Premi un tasto per continuare

            } while (scelta.KeyChar.ToString() != "u");
        }
    }
}
