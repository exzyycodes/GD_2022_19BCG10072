# GD_2022_19BCG10072
GameDEV test for HITWICKET recruitments
## INSTRUCTIONS
1. Download DoofusGamr.rar from PlayableDoofusRuns folder and extract the downloaded files.
2. Run DoofusRuns.exe file to play the game.
3. 3. The raw files for asstes, packages, user setting etc can be found in the same branch.
#### IDEA BEHIND THE GAME
The basic idea behind the game was to create a simple level based game where the player has to move to and stay on the planes that appear in the game.
The game character is called Doofus and the plane(objects) are knows as pulpit. The pulpits are spawned and destroyed in fixed intervals and the player has to keep moving doofus using "wasd" keys to make sure it stays on a pulpit at any given time to continue the game.
As soon as doofus is not on any pulpit, the game gets over. Each pulpit that doofus survives through adds to the score.
The task is to get as high as 50 pulpits for Doofus.
******************************************************
The approach was to create a basic and simple 3d implementation for the same game concept using built-in assets. I have used basic textured plane as pulpits and a square object as doofus.
The next thing was to derive the data for object functionalities from the Json file. It was my first time using json on unity, so i used some online resources to learn implementation and help from peers to understand.
The data derived was used in spawning, destroy and movement scripts to instatntiate spawn timer, spawn delay, destroytimer as well as movement speed. Rest of the basic functionaities were set using the inspector tool and audio assets were imported from the Unity store.
The main scene was hence created and then the main menu, instructions and game over scene was made. and Onclick events with buttons were used to traverse through the scenes.
Thus building all the scenes together processed the final DoofusRuns Game as an exe.file.
###### CREDITS
This game dev task was completed in response to the Game Developer Assignment for Game Dev recruit 2022 by HITWICKET.

