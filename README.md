# MVC-Word Counter

#### This is for code Project#2 for C Sharp Course

#### By **Alan Falcon**

## Description

This website is our second project for C# course. This site allows for the user to enter a word and a string of words whereby the site reports back how many times the word appears in the string of words.

## Setup/Installation Requirements

* You may view this project at: https://falconswoosh.github.io/Wk2-C--IP-WordCounter
Wk2-C--IP-WordCounter
* This project may be cloned from:  https://github.com/falconswoosh/Wk2-C--IP-WordCounter.git
* Install .NET SDK, .NET Runtime, and Mono (refer to links in 'Technologies Used' section below).
* Clone to your local system
* Open the project folder "Wk2-C--IP-WordCounter"
* Depending if you are on Windows or MAC, go to your CMD, Command line interface, Terminal, PowerShell, or Bash. Enter the following to both setup this project with the additional necessary packages, configuration needed, and run a virtual server on your local system:
  * dotnet restore
  * dotnet build
  * dotnet run
* Open a browser and navigate to http://localhost:5000 to interact with this project as a user.
* If you choose, you may use your editor-of-choice to edit and modify this project.
    * For example, if your editor is [Atom](https://flight-manual.atom.io/getting-started/sections/installing-atom/), issue the following in your bash:
    $ Atom index.html

## Specifications    
| Behavior | Input | Output |
|---|---|---|
| Be able to input a word and receive back confirmation how many times the word appears in what was inputted |  car<br />cart | car occurs 1 time<br />cart occurs 1 time |
| Additionally, be able to input a string of words to also receive back confirmation of how many times the word to be searched appears in the search string. ONLY full word matches are counted. |WORD: car<br />STRING: As a caring responsible person, I maintain my car. At parking lots, I ensure when I open my car door, I do not hit the other car with my car door. | car occurs 4 times|


## Known Bugs

* None identified yet.
* If running in Windows 10 and within Git Bash, the "dotnet build" and "dotnet run" commands may sometimes fail indicating certain files are already running or unable to bind...
* Solution is to run CMD as admin and do a netstat -ano | findstr 5000 and to taskkill the PID associated with port 5000. You need to reissue the netstat command until port 5000 no longer displays in the results prior to reissuing dotnet commands in Bash.

## Support and contact details

Alan Falcon email: [falconswoosh@gmail.com](falconswoosh@gmail.com)

## Technologies Used


* [.NET Core 1.1 SDK (Software Development Kit)](https://download.microsoft.com/download/F/4/F/F4FCB6EC-5F05-4DF8-822C-FF013DF1B17F/dotnet-dev-win-x64.1.1.4.exe)
  * [For MAC users](https://download.microsoft.com/download/F/4/F/F4FCB6EC-5F05-4DF8-822C-FF013DF1B17F/dotnet-dev-osx-x64.1.1.4.pkg)
* [.NET Runtime](https://download.microsoft.com/download/6/F/B/6FB4F9D2-699B-4A40-A674-B7FF41E0E4D2/dotnet-win-x64.1.1.4.exe)
  * [For MAC users](https://download.microsoft.com/download/6/F/B/6FB4F9D2-699B-4A40-A674-B7FF41E0E4D2/dotnet-osx-x64.1.1.4.pkg)
* [Atom](http://flight-manual.atom.io/getting-started/sections/why-atom/)
* [CSS: Bootstrap](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwjswubPlLnWAhVGVRQKHaRLBkgQFggmMAA&url=https%3A%2F%2Fgetbootstrap.com%2Fcss%2F&usg=AFQjCNFpcAPIPLCu0F7w2NDTOafHdV8Pkw)
* [CSS: Materialize](http://materializecss.com/forms.html)
* [Git](https://git-for-windows.github.io/)
  * [For MAC users](https://git-for-windows.github.io/)
* [GitHub](https://github.com/),
* [HTML](http://htmlreference.io/)
* [Javascript](https://github.com/falconswoosh/intrWk2-tracksuggester)
* [Javascript Jquery](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwiBj_WJlbnWAhWBLhQKHfHUAQEQFggmMAA&url=https%3A%2F%2Fjquery.com%2F&usg=AFQjCNFnz7C6MAXGLm7pVcOD_LrOjJUUiA)
* [Markdown](https://en.wikipedia.org/wiki/Markdown)
* [Mono for Windows](http://www.mono-project.com/download/#download-win)
  *  [For MAC users]:
    *  [Paste the following into Bash]:
        *  $ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"
        *  $ echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile
        *  $ brew install git              

### License
* All rights reserved for technologies utilized.

Copyright (c) 2016 **_{MIT}_**