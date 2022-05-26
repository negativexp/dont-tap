# DONT TAP!
A clicking game where you try to get the most points by clicking on randomly selected squares.
This game is still W.I.P and currently only working gamemode is endurance.
# Data
Everything is saved in folder where the game is located using json and can be easily modifed.
## Settings
Main settings are located under the name `settings.json`.
There are 3 main settings...
1. Board size
   - To set board size you type in a number like 4 and 4x4 board will appear. Board size cannot be less than 2 and will be converted to deafult settings (4).
2. Box size
   - Box size is measured in pixles and cannot be less than 1 and yet again will be converted to deafult settings (165).
3. Spacing
   - Spacing is space between boxes and is measured in pixles. Spacing cannot be less than 0 and will be converted to deafult settings (1).
### Endurance settings
there is just one thing and thats `Amount of clicks`.
### Frenzy settings
there is just one thing and thats `Time`.
## Scores
Scores located under the name `scores.json`.
# Gamemodes
## Endurance
In endurance you try to play as long as possible and gameover is declared when the time runs out or you miss. The 10 seconds time adds up if you click 30, 40, 50 or your custom amount of clicks.
## Frenzy
Here you try to play as fast as possible until you miss or time runs up. You can choose your own time.
## Pattern
This one is boring, you just clear patterns.
# Notes
Yes, I know there are bunch of `endurence` things insted of Endurance and no, I'm not renaming it all. Too lazy.
