
# Twitch Plays Pokemon Bot
[![Build status](https://ci.appveyor.com/api/projects/status/ba8atmu3gna4ndb0?svg=true)](https://ci.appveyor.com/project/CharizardFire58/cpplayspokemon) ![Chari es negro](https://img.shields.io/badge/chari-es%20negro-informational.svg) ![CPPP Version](https://img.shields.io/badge/CPPP-1.0.1-red.svg)

This bot was made for use on a community event called **CPPlaysPokemon** (cancelled). This work is a modification of [thewax/twitchplays](https://github.com/thewax/twitchplays) bot to simplify its use.

Only support [VisualBoyAdvanvce Emulator](https://www.pokeyplay.com/descargar_archivo.php?archivo=emuladores_gba/VisualBoyAdvance1.7.2.zip) and GB/GBC/GBA Games at this time.

## Features
- Ini config file for easy setup.
- No need to compile it to use it. See [releases.](https://github.com/ChariArch/TwitchPlaysPokemon)

## Configuration
Before you start, you need .NET Framework 4.0 or higher for everything to work correctly.

We open the **settings.ini** file and should see something like this:

    [Twitch]
    Username=your twitch username in lowercase
    Oauth=insert oauth token here
  
  Now you must get your OAuth token from https://twitchapps.com/tmi/ and put it in the settings.ini file

You should see something like that:

    [Twitch]
    Username=elvergal4rga
    Oauth=oauth:afaj32h4tasdjasdasge5e23
    
### Emulator Config
In your VisualBoyAdvance, set the controls to the following:

    Start: 1
    Select: 2
    Up: 3
    Down: 4
    Left: 5
    Right: 6
    Button A: 7
    Button B: 8
    
