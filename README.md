## Project : FistJump

![demo](https://media.giphy.com/media/1AhgwLBsHerWck5KYd/giphy.gif)

High-Res Demo : [https://www.youtube.com/watch?v=xBpTh_HoESo&feature=youtu.be](https://www.youtube.com/watch?v=xBpTh_HoESo&feature=youtu.be)

## Overview

FistJump is a simple project that helps demonstrate how data can be passed from an OpenCV Server to a Unity3D app.

The project requires and OpenCV server and a Unity3D instances working simultaneously for it to work

The Python-OpenCV folder contains the code for Hand Detection with OpenCV ([https://github.com/gurraunaqsingh/Python---Introduction-to-using-OpenCV-with-Unity](https://github.com/gurraunaqsingh/Python---Introduction-to-using-OpenCV-with-Unity))

The Unity3D folder contains a Unity3D Project that takes data from a running instance of OpenCV. Everytime the user makes a fist, a 'Jump!' command is sent to the Unity3D Project which makes the ball Jump! ([https://github.com/gurraunaqsingh/Unity3D---Introduction-to-using-OpenCV-with-Unity](https://github.com/gurraunaqsingh/Unity3D---Introduction-to-using-OpenCV-with-Unity))


## Instructions

### Python

The necessary packages needed to run are mentioned in the requirements.txt file. To install - 

```
$ pip install -r requirements.txt
```

The only remaining package that you need to install is OpenCV Python Version 3, which you can install with one of the following links : 

Mac/Linux : [https://www.codingforentrepreneurs.com/blog/install-opencv-3-for-python-on-mac/](https://www.codingforentrepreneurs.com/blog/install-opencv-3-for-python-on-mac/)

Windows : [https://www.codingforentrepreneurs.com/blog/install-opencv-3-for-python-on-windows/](https://www.codingforentrepreneurs.com/blog/install-opencv-3-for-python-on-windows/)

After installation, run the OpenCV-Server.py file using 

``` 
$ python OpenCV-Server.py
```

### Unity3D

Open the Scene "Main" from Assets -> RW -> Scenes -> Main and Click Play.