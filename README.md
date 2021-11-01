## RPG Battle Engine
### Why is this here?
This repository is my portfolio of projects I have made and still have source for, so that I have something to show potential employers. While there a number of C# projects I have worked on, such as [YATCP (Yet Another Twitch Chat Plugin)](https://obsproject.com/forum/resources/yatcp-yet-another-twitch-chat-plugin.37/), they weren't kept for prosperity because I no longer had a need for them and other projects were done better. In YATCP's case, I stopped streaming and thus no longer needed a plugin for streaming. All of the other projects I have uploaded are finished, but do not show my preferred language, so I have decided to include this very early in development project I am working on as a hobby to show my ability with C#.

### Goal of this Project
I have always loved Japanese style Role Playing Games(JRPGs). One of the key features of these games is that the majority of their gameplay takes place in turn based battles. Since High School, programming on my [TI-89 calculator](https://www.ticalc.org/archives/files/fileinfo/196/19617.html), I have toyed with the concept of making such a game myself. This project is a continuation of that and putting to use what I have learned over the years.

 My goal is to make a fully featured turn based battle system in which I can integrate with a full fledged game. To this end, I have realised I do not need graphics to represent the games state to actually develop the game. I am weak at art and art would inevitably hold me back. This project will be built with the frontend being represented by a windows form. Other goals include:
 

 - Must be able to be used either single player or two player multiplayer
 - The two player should be trustless peer-to-peer
 - Should be completely seperate from the Frontend, so that it can be integrated in a more visual medium later.

### Current State
Currently, I have developped the basic game state. The game state is represented by two unique players, each with their own battlefield of upto three combantants each. There is an effect stack, in which effects will be pushed on it by abilities that combantants have. There are active abilities, which are what a player would choose on the combantants turn, and passive abilities that are triggered when an effect is added onto the stack. 

Right now the windows form shows all six combatant spots, their current hp shown next to their max, and their initiative level. The combatant with the lowest current initiative level is the turn player, which is showed by a check box. You may only pass each combatants turn currently, which will increase their current initiative by their base initiative and the form will show the newest turn combatant.

If a combatants hp is 0, an unconscious passive ability will be added to the combatant. The unconscious passive ability automatically passes the turn for the combatant, when they are the lowest in current initiative.

### What I need to work on
I am currently using GUID to add IDs to everything. I need something more custom. IDs need to be generated on the fly and always be the same in the same situation, but unique to it's context. I need this so that the games state will always hash to the same hash, so that two players can compare hashes to make sure they are in sync. Immutability and Functional principles are going to be key to that. 

I also need to figure out how I am going to ID abilities. Some abilities are going to have to be hard coded, such as most Passive Abilities as their triggers will be complex. Most Active abilities will be just a collection of effects and target data on the otherhand. To make them data driven, it will be necessary that they have a connected ID systlem and that generated abilities do not share hard coded abilities IDs.

On the front end, I need to show the inner workings of the stats of each combatant and I need to add the ability to actually choose abilities to be used. Right now its the most functionally basic, but the framework is already there to do it now. I will work on the ID problems first, then onto the front end to make it more game like.
