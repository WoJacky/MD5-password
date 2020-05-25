# :bulb: My-MD5-PASSWORD by Wojciech Jackowiak aka WoJack 

### Basic topic
#### 1.	Wstęp.
  * Algorytmy najprościej mówiąc jest to ciąg postępowania w celu uzyskania efektu. 
  * Algorytmem może być zwykły przepis na sernik w którym w dokładnych krokach opisany jest sposób działania w celu uzyskania żądanego efektu jakim jest wypiek lub zakalec.
  * Algorytm możemy zastosować w celu optymalizacji pewnych rzeczy. Ja zastosowała algorytm w szczególności algorytm md5 w celu generowania haseł
  
#### 2.	Generatory haseł – bezpieczeństwo
* Generatory haseł, zyskują coraz bardziej swoją popularność, zakładając nowego email, system sam ocenia złożoność naszego hasła i w przypadku gdy hasło ma zbyt niską ocenę(składa się z prostego ciągu znaków typu Student123) po prostu nie przepuszcza.
#### 3.	Sposób działania md5 :warning:

 Wejściem algorytmu jest komunikat M o praktycznie dowolnej długości, a wyjściem 128-bitowy skrót, czyli wyciąg tego komunikatu. Przetwarzanie komunikatu na skrót odbywa się w 4 krokach. Dane w każdym kroku przetwarza się w 512-bitowych blokach, podzielonych na 16 podbloków po 32 bity
       
  * Wiadomość dopełnia się dodatkowymi bitami w taki sposób, by jej długość była o 64 bity krótsza od wielokrotności 512 bitów. Dodatkowe bity dodaje się nawet wówczas, gdy warunek powyższy jest spełniony. W takiej sytuacji dopełnienie ma długość od 1 do 512 bitów. Ustalono, że uzupełniające bity rozpoczyna jedynka, po której następują same zera.
 * Po wykonaniu czynności, podanych w 1. kroku, do uzupełnionego komunikatu dodaje się 64 bity, które reprezentują liczbę K, czyli długość pierwotną komunikatu M. Jeśli początkowa długość komunikatu jest większa od 264, to liczbę, określającą pierwotną długość komunikatu oblicza się modulo 264. W rezultacie tej czynności otrzyma się L 512-bitowych bloków Y0, Y1, , . . . , YL−1, z których każdy można podzielić na 16 podbloków 32-bitowych, ponieważ 512=16 · 32
  * Operacje, realizowane przez algorytm MD5, polegają na modyfikacji wartości czterech zmiennych A, B, C i D, zapamiętanych w 4 rejestrach 32-bitowych. W kroku 3. zmiennym tym nadaje się następujące wartości początkowe, zapisane w kodzie szesnastkowym:
  - A = 01234567,
  -	B = 89abcdef,
  -	C = fedcba98,
  -	D = 76543210.
 
#### 4.	Działanie kodowania
-	Na samym początku przekształcamy tekst wejściowy na tablicy bajtową
- Następnie tworzymy obiekt MD5CryptoServiceProvider
-	Metoda ComputeHash z MD5CryptoServiceProvider zwraca hash w postaci tablicy 16bajtowej
-	Implementacja md5 zwraca 32-znakowy hash w formacie hexadecymalnym.
-	Aby móc uzyskać efekt, należy sformatować zwracaną wartość metody ComputeHash jako wartość hexadecymalną 
-	Stworzenie nowego obiektu TripleDesCryptoServiceProvider w celu wygenerowania klucza oraz wektora inicjalizacji
-	Nastepnie używając interface ICryptoTransform tworzymy Encryptor
-	Używajac metody TransformFinalBlock wrzucamy dane do tablicy bajtowej
-	Ostatnim etapem jest sformatowanie tablicy bytowej i wyświetlenie tego na ekranie

#### 5.	Działanie dekodowania
-	Nie różni się znacząco od metody hashodania
-	Różnicą jest typ ciągu wejściowego.
-	Z interface ICryptoTransform korzystamy z metody CreateDecryptor 
-	Następnie konwertujemy z tablicy byte do string i wrzucamy na ekran

#### 6.	Pomysły na rozwinięcie aplikacji
-	Planuję rozwinąć aplikację, aby użytkownik miał możliwość wprowadzenia własnego ciągu znaków hash
-	Planuję rozwinąć aplikację, aby wygenerowane hasło, wraz z wartością początkowa oraz hashem zapisywane było w folderze użytkownika.
-	Rozszerzenie aplikacji o inne algorytmy np. RSA
-	Przeniesienie aplikacji do web (w trakcie nauki asp.net mvc 5) 
#### 7.	Zdjęcia poglądowe aplikacji :underage:
![Home](https://user-images.githubusercontent.com/43810008/82828803-2b893100-9eb2-11ea-8a15-81661bfea9cc.JPG)
![Algorithm](https://user-images.githubusercontent.com/43810008/82828843-39d74d00-9eb2-11ea-903a-d7329ba1e2c4.JPG)
![About](https://user-images.githubusercontent.com/43810008/82828856-4196f180-9eb2-11ea-9dab-0887d3503281.JPG)

