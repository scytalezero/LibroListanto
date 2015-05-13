# LibroListanto
This utility creates word lists for Esperanto reading study. It combines a list of Esperanto words you already know with a text you want to read and produces a list of the roots that you need to learn. That list can then be used to create a Memrise course so that you can learn the new words in advance of trying to read each chapter. For me this produced a better experience than trying to combine reading and learning vocabulary at the same time.

# Pre-requisites
You will need the following things to use LibroListanto:
- Microsoft .NET framework 4.5 (you may already have this)
- A UTF-8 text file containing the words you already know. Each word should be on its own line. It's okay if there are additional fields for the word if they are separated by tabs and the word is the first one. This is the default [Learning With Texts](http://www.lwtfi3m.co/lwt/) (LWT) export format.
- A UTF-8 text file of the text for which you want to create a learning list.

# Memrise Helper
If you don't already have your list of words in a file or in LWT, I also wrote a script that will help you export them from Memrise courses you have completed. 

1. You will first need to install the requisite user script addon for your browser: Greasemonkey for Firefox, or TamperMonkey for Chrome. 
1. Install the user script [from here](https://github.com/scytalezero/MemriseUtilities).
1. Follow the directions on the MemriseUtilities page to export your completed Memrise courses into LWT.

# Using LibroListanto


# Limitations
Here are some limitations of the utility that I am aware of and may or may not fix at some point:
- Only UTF-8 sources files with accented letters are supported (ĉ, not cx or ch).
- The utility is currently targeted at an English speaking audience.
- The output is targetted at Memrise but should work with Anki as well.

# Acknowledgements
Thanks to Wilfred Hughes and his [ReVo-utilities project](https://github.com/Wilfred/ReVo-utilities) from which comes the dictionary used by this utility.
