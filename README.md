### CLASSES D'EQUIVALÈNCIA:

#### ClassifyAge

- Edats no vàlides negatives: (-∞, 0)
- Edats vàlides [0, 120]
- Edats no vàlides positives: (120, +∞)

#### IsEven

- Números parells: -2, 0, 2, 4, 6...
- Números senars: -1, 1, 3, 5, 7...

#### NameAnalyser

- Noms curts i palíndroms: "ojo", "aja"...
- Noms curts no palíndroms: "rata", "dit"...
- Noms no curts i palíndroms: "arrarra", "oaaao"...
- Noms no curts i no palíndroms: "patata", "spine"...
- Noms amb altres caràcters: "D04d@"...

#### VerifyColour

- Invàlid: "patata", "@", "tomàquet"...
- Calmant: "verd", "blau"
- Exclusiu: qualsevol altre color

#### PersonalityTest

- Determinat: "matí" i "nit"
- Indeterminat: qualsevol altra cosa

### CASOS LÍMIT:

(Només als mètodes que prenen com a argument números)

#### ClassifyAge: 0, 1, 119, 120, -∞, +∞.
#### IsEven: 0, -∞, +∞.

### CASOS DE PROVA:

Es poden observar al projecte creat. Cal dir que he près com a referència el codi de la llibreria, no només les indicacions de l'exercici perquè, si no hagués sigut així, molts caasos haguessin fallat (exemples: el negatiu a ClassifyAge s'interpreta com un infant, VerifyColour té com a colors exclusius qualsevol string que no sigui verd ni
blau ---> no cal que siguin un color, VerifyColour només interpreta com a invàlid una string buida...).
