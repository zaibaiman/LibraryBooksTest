LibraryBooksTest-CleanArchitecture
=========================

This is a sample app that is part of a test about how to architect asp mvc application using the [Uncle Bob's clean architecture approach](https://blog.8thlight.com/uncle-bob/2012/08/13/the-clean-architecture.html). 

Clean architecture
-----------------
![http://fernandocejas.com/2015/07/18/architecting-android-the-evolution/](http://fernandocejas.com/wp-content/uploads/2014/09/clean_architecture1.png)

Architectural approach
-----------------
![http://fernandocejas.com/2015/07/18/architecting-android-the-evolution/](http://fernandocejas.com/wp-content/uploads/2014/09/clean_architecture_android.png)

Architectural reactive approach
-----------------
![http://fernandocejas.com/2015/07/18/architecting-android-the-evolution/](http://fernandocejas.com/wp-content/uploads/2015/07/clean_architecture_evolution.png)

Folder Structure
-----------------
 * `build` Usually contains just a build script or two, but can sometimes include supporting files (e.g., PowerShell scripts, EXEs, and the parameters file).
 * `doc` Contains documents related to the code base; this might include developer documents, installation guides, tips, requirements, images, and wireframes.
 * `lib` Contains all third-party libraries and packages used by the application(s) in this source tree; as stated previously, you will configure NuGet to place downloaded packages in this folder.
 * `setup` Contains the code or scripts used to deploy the application. This might be just a PowerShell, MSBuild, or NAnt script; or, it might be WiX source code or something similar.
 * `src` Your source code! All of the code you write for the application goes here. This folder usually contains your Visual Studio solution file(s), with all project folders being contained here.

Application Structure
-----------------

 * `LibraryBooks.Domain` - Holds the domain entities and logic.
 * `LibraryBooks.Data` - Set up for persistence via a repository created with the Entity Framework.
 * `LibraryBooks.WebUI` - Holds the controllers and views; acting as the UI for the SportsStore application.


License
--------

    Copyright 2015 Frank Mendoza

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.

