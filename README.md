# TowerDefenseTemplate

# DreamChase
In mijn game "DreamChase" moet je de enemy "Bat" verslaan om te kunnen winnen, je doet dit doormiddel van het schieten van arrows.Je schiet vanuit een kasteel arrows op de bat, hierdoor gaat de enemy dood en je kan de tower "kasteel" ook verplaatsen. 
De enemy kan winnen als het de rode orb op pakt.



![Game](file:///C:/MA/Leerjaar2/M1/Game1.png)

![MainMenu](file:///C:/MA/Leerjaar2/M1/Game2.PNG)


## Product 1: "DRY SRP Scripts op GitHub"

# DRY
Hier heb ik niet mee gewerkt omdat ik er niet aan toe kwam om mijn ideeën optijd toe tevoegen aan mijn game.

Maar als ik een wave system had toegevoegd aan mijn game zou ik een array gebruiken omdat ik mezelf dan niet hoef te herhalen en dan met 1 code alle enemies kan laten spawnen.

# SRP
In mijn script "Enemy" staat er dat als de health onder 100 is dat de enemy dood gaat en het wordt dan destroyed.

[Enemy Script](https://github.com/elizanx/Tower-Defense/blob/main/Dreamchase/Assets/Scripts/Enemy/Enemy.cs)
 
## Product 2: "Projectmappen op GitHub"
Dit is de [ROOT](https://github.com/elizanx/Tower-Defense/tree/main/Dreamchase/) folder van mijn unity project.



## Product 3: Build op Github
[Build in release](https://github.com/elizanx/Tower-Defense/releases/tag/FinalVersion)

## Product 4: Game met Sprites(animations) en Textures 

![Textures Sprites](file:///C:/MA/Leerjaar2/M1/Gameplay.gif)

## Product 5: Issues met debug screenshots op GitHub 
Ik heb 3 issues, ik kreeg er eentje een dag van te voren na het builden.
Ik kon één debuggen (arrows doen damage als het de vleermuis raakt) want ik had hetzelfde probleem een dag van te voren maar en ik had het gefixt binnen 10 minuten, helaas ging hij weer kapot tijdens het builden. Dus met andere woorden ik heb het niet helemaal kunnen debuggen.

[Link naar mijn issues](https://github.com/elizanx/Tower-Defense/issues/)

## Product 6: Game design met onderbouwing 

Omschrijf per mechanic welke game design keuzes je hebt gemaakt en waarom je dit hebt gedaan.

*  **Je game bevat torens die kunnen mikken en schieten op een bewegend doel.** 
Ik heb een toren het is een kasteel en je kan de heletijd schieten. Er zijn unlimited arrows waarmee je kan schieten waardoor de enemy sneller dood kan gaan. Ook kan je 360 graden ronddraaien met je muis en kan je nog steeds schieten. Je gebruikt de linker muisknop voor dat.

*  **Je game bevat vernietigbare vijanden die 1 of meerderen paden kunnen volgen.**  
De enemy volgt een pad die is gemaakt door middel van waypoints en het moet de orb kunnen oppakken om te winnen dus het volgt de hele map rond.
Als je de enemy hebt gedood dan heb jij gewonnen maar als de enemy de orb heeft opgepakt voordat jij het hebt neergeschoten dan heeft de enemy gewonnen.

*  **Een “health” systeem waarmee je levens kunt verliezen als vijanden hun doel bereiken en zodoende het spel kunt verliezen.** 

*Rechts boven zie je een healthbar als de enemy dood is gaat de healthbar naar beneden en ga je naar een "Win" scene*


## Product 7 & 8 hebben we geen les over gehad 

Dit heb ik niet gemaakt.

## Product 9: SCRUM planning inschatting 
[Link naar de openbare trello](https://trello.com/b/v92Lbu4Y/dreamchase)


