# IE lives on in Windows 11! Oorah!

## Introduction
Are you still using Internet Explorer? Have legacy software you can't or won't port? Do you need to work with ancient government systems? Look no further.

You can use this in the exact same way you would the normal Internet Explorer executable. It takes advantage of the fact that Microsoft left behind most of IE and just doesn't let you run the usual way.

## Installation
No need. This should run on any system with .net 6. The releases tab includes a binary with the full runtime in a single ```exe``` file.

## Compilation
Tools needed
* ```visual studio```
* ```.NET 6 sdk```
* reference to ```Microsoft Internet Tools``` from the ```COM``` references menu 

Publish > choose if you want to include a runtime or not

## Closing notes
I tested  this on Windows 11 22H2 Build 22621.521

This would probebly work on older ```.NET``` platforms but I didn't test it

