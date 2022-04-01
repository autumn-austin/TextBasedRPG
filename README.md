PRE-REQUISITES FOR DEMO:

Download the following to your PC:
[Visual Studio](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false)
and
[.NET Version 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

Hello and welcome!

This is a demo for a text based adventure game, created by myself. In this demo you will find your character, who is assigned a name at the beginning of the game (you may use your own, or you may choose to create a new character altogether!), exploring a new place that they can't recall how they got there. You will encounter battle sequences in which you will have a variety of options to choose from, NPC encounters in which you may gather story information from, and your own apartment in which you may save your player stats to!

To operate this game demo, you need to acquire the game code from GitHub (what you are on currently), by downloading the file paths, and saving them into a folder that is easily accessible to you. Open the RPGAdventure folder and double click on the RPGAdventure.sln file to open the solution file. From here, you may choose to navigate around the code, or press F5 (run) to start the program and play the demo.

You will be prompted with a menu screen, in which you may load player stat files if they exist, or choose to start a new game with the basic player stats every player will be given in the beginning. 

Once you either load or start new, you will be prompted to input the player name. Once the player name is input, you will begin the adventure!

To navigate the story, you may press ENTER to run through dialogue. 

To navigate enemy encounters, you will press the first letter of the attributed action. (A for "ATTACK", D for "DEFEND", F for "FLEE", etc.)

To navigate the town, and your apartment, you will also press the first letter of the attributed action (or place)

-H for "HOME"
-T for "TOWN HALL"
-F for "FOREST"
-E for "EXIT"
-S for "SHOP"

(Please note, this is a demo and not all attributes in the town square have written functionality, currently the shop and home are the only resting places you may go, the town hall will soon have a community board for quests, currently the forest is a randomized enemy encounter ONLY, you may fight till the death!)

You may also choose to exit the game to the main menu from your home, in which you will return to the main menu. From the main menu, you may exit the program entirely. 

Thanks for checking out my small demo, and happy coding!

(The three met requirements met for the Code Louisville course:
- Master loop implemented where user can return to main menu screen and choose to exit the program.
- Class inheritence where the enemies have all enherited properties from the Enemy class, as well as the setting classes inheriting properties from the Place class.
- And finally, serializing player stats to an xml file, and deserializing that xml file to a variable.)
