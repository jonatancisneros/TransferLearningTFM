# Enabling Hard of hearing people to use smart home devices 
## Master's in Data Science thesis  

## Contents
[What is the Hard-of-hearing smart home assistant?](#what-is-this-project-about?) <br>
[Why is it relevant?](#why-is-it-relevant?) <br>
[How do I install the project?](#how-do-i-install-the-project) <br>
[How do I use the application?](#how-do-i-use-the-application) <br>
[How does it work?](#how-does-it-work?) <br>
[Data](#data) <br>
[Project structure](#project-structure) <br>
[Model breakdown](#model-breakdown) <br>
[Performance](#performance) <br>
[Limitations](#limitations)
 


##What is this project about?
The Hard-of-hearing assistant is an application that capable of recognizing simple 
[sign language](https://www.handspeak.com/word/search/index.php?id=1487) commands so it can translate them into voice assistant instructions and also present other useful information on the screen like the weather and time.

This ad-on can run in any device with a camera and a screen and the examples shown are integrating two of the most important smart home devices, [Alexa](https://developer.amazon.com/en-US/alexa) and [Google Home](https://store.google.com/product/google_home) .

This project was born from my interest in making AI projects for good by always being inclusive. 

I also realized a use case where people that don't want to share their conversations can also benefit from this tool as their voice wouldn't be recorded considering that this tool can run completly offline.
 
##Technologies used.

1. Azure blob Storage
I have used blob storage to upload all the images used for the several runs.

2. MVC Web APIs
I have used WEB APIs to store and retrieve the images. 

3. Tensorflow.js
For implementing two models, the one from mobilenet and also KNN.


## Why is it relevant?

Many of the smart home devices that are now being sold only work with [Google Home and Alexa](https://www.digitaltrends.com/home/best-google-home-compatible-devices). This is clearly leaving many people out of the possibility of using these excelent devices, for example, the elderly, kids with autism as well as other people with hard of hearing problems.

It becomes relevant for everyone else as it enables people not wanting to speak out loud the same commands all the time to use their devices in a different way.

Another benefit of this tool could be the possibility of making Sign language more universal, at least for some important keywords.


##How do I install the project?

The project consists of two parts, the first one is a labeling tool that I built for the whole purpose of collecting and labeling the signs that I wanted to use for this project.

This labeling tool is already deployed to [azure](http://tfmkschool.azurewebsites.net).

The second part of the project is the recognition module which is the one that infers images from your web cam and it is also deployed into azure [here] (https://tfmkschool.azurewebsites.net/recognition).

If you whish to run the project in development mode I suggest you download Visual studio Community edition and run the solution file which is a .NET project.

This .NET project has a reference to the tensor flow library for Javascript.


## How do I use the application?
The following [video](https://www.youtube.com/watch?v=sKn2nvj3qBE&feature=youtu.be) shows the live application and sample commands. 


## How does it work?

The project uses [transfer learning](https://en.wikipedia.org/wiki/Transfer_learning), a technique that leverages the knowledge acquired from an existing model and then uses this knoledge for a didderent purpose.  

![Sample image](https://tfmkschool.blob.core.windows.net/tfm/3_1637137022949233882_3f90f26a-a103-4a2d-acbd-b4afe48bd898.png)


 
## Data
The data has been collected using the labelling tool. Each session has been tested with about a thousand images. Results vary depending on the number of samples uploaded per each class.

## Project structure
The project was built in .NET MVC and has two modules:

 - **Labelling module**: 
 
 - **Data**: Data is stored in azure blob storage. The blob storage is public and can be accessed through this API call:
 
 - **Recognition module**: 
 
 The recognition module is using Text to speach so it can talk to the smart home devices. The following library was used for this purpose.
 
 https://code.responsivevoice.org
 
 
## Model breakdown




### Mobile net

### KNN
## Performance

## Limitations

I realized that the recorded images used for KNN have to be limited in order for the model to work properly in a browser.

