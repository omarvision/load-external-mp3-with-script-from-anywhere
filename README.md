# load-external-mp3-with-script-from-anywhere
Imagine making an audio player in Unity. How do you load a file from anywhere on the harddrive in Unity? I found a way to load a WAV file from anywhere on the HardDrive using WWW, but then I couldn't load an Mp3 file.  I didn't give up I found that I could use NAudio.dll library to convert an MP3 to WAV in memory and then use the WWW to load the MP3 file from an external location in Unity.  Hopefully WWW (which is deprecated) sticks around a while longer... or is replaced with something better.

YouTube:  https://youtu.be/z-VmrNshQv0
