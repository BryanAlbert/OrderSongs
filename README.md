OrderSongs
==========

One can export PowerPoint slides as `jpg` files for use with a projector. Since the projector will display  the jpg files in "ASCII order," (the first slide is the first file name alphabetically, etc.) their names must be in (basically) alphabetical order. PowerPoint gives them names like `Slide00.jpg`, `Slide01.jpg`, etc. which works fine if there is only one song, but... If one wants to gather slides exported from multimple PowerPoint files, their names will collide, so one must rename the slides manually to preserve the desired order, an arduous task. This console application helps relieve that pain. 

## Usage
From the applications Usage text:
```
Usage: Copy this program to the empty export folder and launch it
from there, then copy the first song's files, hit a key, and repeat.

Alternatively, in PowerShell or Command Prompt, cd to the export
folder, run this program from an absolute path (or relative path),
copy the first song's files, hit a key, and repeat. Program's path:
C:\Users\bryan\Documents\Church\Songs\Export\OrderSongs.exe
```

For example, in File Explorer, create a new folder to hold the slides, such as 2021-04-18. Drag and drop OrderSongs.exe to the folder (hold down the Ctrl key while dropping to copy the file instead of moving it). Lauch the program by double clicking on it. Copy the first song's jpg files to the folder. Return to the OrderSongs.exe window and hit a key, it will rename the new files with the prefix 100. Copy the next song's jpg files to the folder, hit a key in the CopySongs.exe window, the new files will be renamed with the prefix 110, and so on. Since all files with the prefix 100 sort before all the slides with the 110 prefix, order is preserved. 

Alternatively, using PowerShell, in the directory containing CopySongs.exe, create the new folder, cd to that folder, and run ..\CreateSongs.exe. Copy the first songs' jpg files to the folder and hit a key to rename them and repeat. 
