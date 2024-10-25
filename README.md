# TowerDefenseTemplate
Er is een enemy "Vleermuis" die je moet vernietigen voordat het de rode orb oppakt, je kan dat doen met de grote kasteel in het midden die arrows schiet en je kan de tower verplaatsen.

![not really my game](https://cdn.akamai.steamstatic.com/steam/apps/246420/ss_aaaf33cdb9106bd0801a36049516d95c6f2352b0.600x338.jpg?t=1686321490)

![also not](https://cdn.akamai.steamstatic.com/steam/apps/960090/ss_900d7c00d45ff2a258d4c8d59ee47f7f04854c37.600x338.jpg?t=1686097340)


## Product 1: "DRY SRP Scripts op GitHub"

# DRY
Hier heb ik niet mee gewerkt omdat ik er niet aan toe kwam om mijn ideeën optijd toe tevoegen aan mijn game.

Maar als ik een wave system had toegevoegd aan mijn game zou ik een array gebruiken omdat ik mezelf dan niet hoef te herhalen en dan met 1 code alle enemies kan laten spawnen.

# SRP
In mijn script "Enemy" staat er dat als de health onder 100 is dat de enemy dood gaat en het wordt dan destroyed.

[TowerDefense](/https://github.com/elizanx/Tower-Defense/blob/main/Dreamchase/Assets/Scripts/Enemy/Enemy.cs)"*
 
## Product 2: "Projectmappen op GitHub"
Dit is de [ROOT](/https://github.com/elizanx/Tower-Defense/tree/main/Dreamchase/) folder van mijn unity project.

Zorg dat deze verwijst naar je Develop branch.

## Product 3: Build op Github

Je maakt in Unity een stabiele “build” van je game waarbij bugs en logs eerst zijn verwijderd. Deze buildfiles upload je in je repository onder releases.  Bij eventuele afwijkingen moeten deze worden gedocumenteerd in de release. (Bijv controller nodig of spelen via netwerk etc..) 

[Release Voorbeeld](https://github.com/erwinhenraat/TowerDefenseTemplate/releases)

## Product 4: Game met Sprites(animations) en Textures 

De build van je game bevat textures, sprites en sprite animations(bijv particles) die op de juiste manier zijn gebruikt en zorgen voor een goede afwerking van je game.  

Plaats in je readme een animated gif van je gameplay (+- 10 sec.) waarin de implementatie van je textures en sprites goed te zien is.

![Textures Sprites](readmeVisuals/texturesSprites.gif)

## Product 5: Issues met debug screenshots op GitHub 
Ik heb 3 issues, ik kreeg er eentje een dag van te voren na het builden.
Ik kon één debuggen (arrows doen damage als het de vleermuis raakt) want ik had hetzelfde probleem een dag van te voren maar en ik had het gefixt binnen 10 minuten, helaas ging hij weer kapot tijdens het builden. Dus met andere woorden ik heb het niet helemaal kunnen debuggen.

[Link naar mijn issues](https://github.com/elizanx/Tower-Defense/issues/)

## Product 6: Game design met onderbouwing 

Je gebruikt een game design tool om je game design vast te leggen en te communiceren. Daarnaast onderbouw je de design keuzes ten aanzien van “playability” en “replayability” voor je game schriftelijk. 

Voorbeeld van een one page design:
![](https://external-preview.redd.it/48mnMpA0TbiihGo4HsJiWrJhK72xeTRwV2o70_AKilw.jpg?auto=webp&s=3a1ae18f0e4fba7a465643987cbe9cf409466e53)

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

## Product 10: Gitflow conventions

Je hebt voor je eigen project in je readme gitflow conventies opgesteld en je hier ook aantoonbaar aan gehouden. 

De gitflow conventions gaan uit van een extra branch Develop naast de "Master"/"Main". Op de main worden alleen stabiele releases gezet.

Verder worden features op een daarvoor bedoelde feature banch ontwikkeld. Ook kun je gebruik maken van een hotfix brancg vanaf develop.

Leg hier uit welke branches jij gaat gebruiken en wat voor namen je hier aan gaat meegeven. Hoe vaak ga je comitten en wat voor commit messages wil je geven?

Meer info over het gebruiken van gitflow [hier](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)

