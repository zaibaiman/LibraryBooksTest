Android-CleanArchitecture Build Status
This is a sample app that is part of a blog post I have written about how to architect android application using the Uncle Bob's clean architecture approach.

Architecting Android…The clean way?

Architecting Android…The evolution

Tasting Dagger 2 on Android

Demo video of this sample

Clean architecture

http://fernandocejas.com/2015/07/18/architecting-android-the-evolution/

Architectural approach

http://fernandocejas.com/2015/07/18/architecting-android-the-evolution/

Architectural reactive approach

http://fernandocejas.com/2015/07/18/architecting-android-the-evolution/

Local Development

Here are some useful Gradle/adb commands for executing this example:

./gradlew clean build - Build the entire example and execute unit and integration tests plus lint check.
./gradlew installDebug - Install the debug apk on the current connected device.
./gradlew runUnitTests - Execute domain and data layer tests (both unit and integration).
./gradlew runAcceptanceTests - Execute espresso and instrumentation acceptance tests.
Code style

Here you can download and install the java codestyle. https://github.com/android10/java-code-styles

License

Copyright 2014 Fernando Cejas

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
