# Clean Face Shields
No more blurriness, smudginess, or distortion when looking through a face shield.

## **Overview**
Removes the blurriness, smudginess, and distortion effects when looking through a face shield.  It's so clean that you can't even tell when it's flipped down! (look at your inventory to check)

## **Background**
I like face shields - how they look on my character, how they make me feel all warm and protected, how scavs hate it when they cannot head-eyes me anymore with buckshot - but I hate the visual smudginess and blurriness when actually equipping them.  I saw that there were several outdated mods to fix this so I decided to make my own for 3.9.

## **Install**
Extract directly into the SPT folder. The plugin can be located in BepInEx/plugins/.

## **Specifics**
This mod patches a prefix to the method2() function in VisorEffect.cs, which sets the material textures for the VisorEffect's Mask, BlurMask, and DistortMask when flipping down a visor. It simply removes those function calls.  I tested with thermal and night vision to ensure that only face shields are affected by this patch. 

## **Other Mods**
I recommend using [Quieter Faceshield Breathing](https://hub.sp-tarkov.com/files/file/1937-quieter-faceshield-breathing/) to pair nicely with this mod.  My other mod, [Full Helmet Coverage](https://hub.sp-tarkov.com/files/file/2418-full-helmet-coverage/), is compatible as well if you want to buff all helmets and face shields in general.
