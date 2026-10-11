# Skrējiens pēc Iphone 18

## 2. uzdevums
- "_Process(double delta)" izpildās katrā renderēšanas kadrā. Izpildes biežums ir atkarīgs no datora veiktspējas un monitora atjaunošanās frekvences. "delta" vērtība šeit var mainīties.
- "_PhysicsProcess(double delta)" izpildās ar fiksētu laika intervālu, ko iestata projekta uzstādījumos.


## 3. uzdevums

| Atsvaidzes biežums (Hz) | Vai izmanto delta? | Cik pikseļus pakustās 1 solī? | Ātrums sekundē (px/s) |
| :--- | :---: | :---: | :---: |
| 60 Hz | Jā | ~3,33 px | 200 px/s |
| 30 Hz | Jā | ~6,67 px | 200 px/s |
| 60 Hz | Nē | 200 px | 12 000 px/s |
| 30 Hz | Nē | 200 px | 6 000 px/s |

### Novērojumi 
1. Ar DELTA: Mainot kadru biežumu no 60 Hz uz 30 Hz, objekta kustība kļuva nedaudz raustīga, bet laiks, kurā tas šķērso ekrānu, palika vienāds.
2. Bez DELTA: Objekts sāka pārvietoties ātri, jo katrā solī pozīcija tika palielināta par 200 pikseļiem, nevis par daļu no sekundes.


### 2.2 stunda 3.4 uzdevums
Velocity netiek reizināts ar delta, jo automātiski tiek reizināts ar ātrumu.

###2.3 stunda 1.3 uzdevums
Mainot "health" vērtību uz "0"- spēle ir beigusies ; "zem 30 "- uzmanību ; "virs 30" -viss kārtībā.

###2.6 stunda
Spēles apraksts: Spēles varonim ir sienāzis, darbība notiek dabiskā pļavā.  Viņš vēlas izmēģināt jaunākās Iphone 18 telefona funkcijas, tādēļ viņam ir jāsavāc visi punkti, lai varētu piekļūt jaunajam telefonam. Galvenais mērķis ir nokļūt līdz zilajām durvīm pēc iespējas ātrāk un nepieskaroties sarkanajam kvadrātam.
Izskata izmaiņas : fona attēla pienienošana, lai tas atbilstu norises vietai ; "Atslēgas elementa" jeb telefona bildes pievienošana, lai tas atbilstu spēles stāstam ; Punktu atrašanās vietas nomaiņa, lai tos būtu sarežģītāk sasniegt.

Attēls "pļava.jpg" - Licence nav norādīta, Autors: Ilze Zālīte, Avots:https://www.lsm.lv/raksts/dzive--stils/darzs-un-majas/ka-pasam-ievakt-plavas-augu-seklas.a468986/
Attēls "telefons.png" - Licence nav norādīta, avots: https://www.threads.com/@techhc_10/post/DZufFWgj7ES/the-i-phone-iphone-pro-and-i-phone-pro-max/
Attēls "Sienazis.png" - Licence nav norādīta, avots: https://okeanija.fandom.com/lv/wiki/Sien%C4%81zis
	
## Pārbaudes
| Pārbaude | Sagaidāmais rezultāts | Faktiskais rezultāts |
|---|---|---|
| Savākt punktus | Punktu skaits palielinās | Nospiežot F5 taustiņu nekas nenotiek | Sākumā ir jāuzpiež F8 taustiņš un tad F5.
| Kustība un lēciens | Bultiņas pa labi un kreisi, burti A/D virza varoni; tas pārvietojas laukumā un neiet cauri šķēršļiem | Atbilstošs sagaidāmajam rezultātam.|
| Savākšana  | Punktu skaits palielinās, dzeltenie punkti pazū no ekrāna. | Atbilstošs sagaidāmajam rezultātam. |
| Finišs bez atslēgas | Uzvara nav, parādās norāde | Atbilstošs sagaidāmajam rezultātam.|
| Finišs ar atslēgu | Parādās uzvaras teksts | Atbilstošs sagaidāmajam rezultātam.|
| Hazard objekts un laukuma robežas | Parādās zaudējuma teksts | Atbilstošs sagaidāmajam rezultātam. |
| Nospiežot R taustiņu | Līmenis(spēle) sākas no jauna | Atbilstošs sagaidāmajam rezultātam.|

## Klasesbiedra atsauksme un uzlabojums
- Klasesbiedrs pamanīja: neērtu novietojumu laukumā papildus platformai (Platform4), na iespējams to lietderīgi izmantot vai palēkties uz tās.
- Pēc pārbaudes uzlaboju: platformas4 pozīciju pārvietoju pa kreisi.
