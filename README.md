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

# Installation
Just extract the files from a release into a folder somewhere on your drive. That's it!

# Using LibroListanto
Once you run LibroListanto.exe, it will take a few moments to read the Esperanto roots file. Once the UI displays, you can hover over controls with your mouse to see tips on what they do. Briefly, the process works like this:

1. Click the first yellow box and choose your list of known roots (mentioned in Pre-requisites). After a file has been successfully read, it will be remembered for the next run.
2. Click the second yellow box and choose the book you want to read (also mentioned in Pre-requisites). The book will be parsed and you will see stats and the list of words that will be written.
3. Click the "Create List" button and your study list will be written to the same folder as your book.
4. Optionally click "Write Book Breaks" if you used a percentage split. This will create a new copy of your book with the addition of created chapters at each percentage break point to aid in synchronizing your reading and study.

# Limitations
Here are some limitations of the utility that I am aware of and may or may not fix at some point:
- Only UTF-8 sources files with accented letters are supported (ĉ, not cx or ch).
- The utility is currently targeted at an English speaking audience.
- The output is targetted at Memrise but should work with Anki as well.

# Acknowledgements
Thanks to Wilfred Hughes and his [ReVo-utilities project](https://github.com/Wilfred/ReVo-utilities) from which comes the dictionary used by this utility.
