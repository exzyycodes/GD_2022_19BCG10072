# GD_2022_19BCG10072
GameDEV test for HITWICKET recruitments
## INSTRUCTIONS
The Game scripts with proper comments and explanations are uploaded for users to view.
To play the game kindly follow these steps-
1. Download DoofusRuns.rar
2. Unzip the file and extract to a folder.
3. Check and run DoofusGame.exe file to enjoy the game.
#### DEVELOPMENT SUMMARY
As per the guidlines provided by hitwicket to complete this project, i started working on it on 10/9/2022 at 17:00 hours. The project is developed on 3D (URP) template of unity. the main game scene contains of two basic game objects Pulpits(plane) and Doofus(player). The Pulpit object has spawner,timer(withdestroyer), swapper etc scripts tagged which provides  the basic timer, random spawn and didappear after a time span functionalities to it.
The Doofus has a ground check functionality script added which check if the rigidbody is interacting with the mesh collider of the pulpit or not. If not, it means Doofus is not on pulpit and thus game ends.
A score script is added which increased the score, whenever a pulpit gets destroyed before gameover is triggered.
The spawn timer, movement speed. Destroyer delay is take from the jSON file provided by HITWICKET which was defined in the required c# file to extract the data.
Whenever a game over is triggered the game over scene is played which has options to play again or go back to main menu.
The main menu scene has options to play game ,quit , or to read instructions on how to play.
Basic audio files has been added from used asstes bundle to add effects on events.
###### CREDITS
This game project has been developed as a submission to the hitwicket assesment for game developer by Nitin Kumar Singh, 19BCG10072.
