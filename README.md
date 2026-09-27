# MovementLab

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
