# Forrest 64 PC

The Nintendo Switch port of Firewatch has an exclusive easter egg, a mini-game called [Forrest 64](https://youtu.be/broQpHnh4_E?t=465). I noticed that the vesrion of the PC version has some leftover files from that minigame, including a test scene with the required objects and scripts to enable the Forrest 64 mode. So I made this mod to toggle Forrest 64 mode during the normal game.

## Some notes

- This can cause your Firewatch saves to become corrupted. If you care bout that, make a backup.
- While this is fun, it's not the intended way of playing Forrest 64, and it's very unstable. You can very easily jump outside the map and just fall into the void. If that happens, you can just toggle Forrest 64 mode off and on again, to go back to Henry's position.

## How to install

- [Download the latest release zip](https://github.com/Raicuparta/forrest-64/releases/latest);
- Extract the zip to your Firewatch folder (the one that has `Firewatch.exe` in it);

## How to use

First, you need to load into the test scene to get the Forrest 64 objects:
- Start the game as usual;
- Wait for the main menu to load;
- Press the **Alpha 4** key on your keyboard (number row, not numpad);
- This will load a test scene included in the game.

Now that you're in the test scene, you can:

- Walk around as Henry and explore if you wish.
- Press **Alpha 5** to toggle between Henry mode and Forrest 64 mode.
- Load a normal save to go into the main game (you need to be in Henry mode to be able to load).

Once you're in the main game, you can press **Alpha 5** at any time to toggle between modes.

## How to uninstall

Rename or delete `winhttp.dll` in the game folder. You can also delete all the other files you copied from the zip of course, but that one is enough to disable the mod.
