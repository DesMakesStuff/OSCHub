# OSCHub

OSCHub is an application that takes OSC messages from VRChat and forwards them to multiple applications. This resolves the issue of being unable to run multiple OSC applications due to port restrictions. OSCHub will relay any message it receives to all configured applications, and will save a list of those applications for ease of use on next runtime.


![image](https://user-images.githubusercontent.com/102766533/204103930-a435e66a-f82e-4549-8cd0-87232f19bf5b.png)



# OSC Debug Feature

OSCHub also includes an OSC debug feature for avatar parameters. Simply start the server and navigate to the Paramater Debug tab. There, all detected parameters will populate into a list which will display live values when selected.

![image](https://user-images.githubusercontent.com/102766533/204103942-375bc9b3-d09d-4de9-9b6b-6e8eb6671a13.png)





# Installation

Simply find the releases tab on the right side of the repository, navigate to the page and download the latest version .zip file. Once downloaded, extract the file into a folder of your choosing and run the application.


# Setting up your applications

Simply start the program and find the "New OSC App" Panel in the top right.

1. Enter the custom friendly name of the application, it can be anything you would like.
2. Enter a new IP address if the application resides on another device on your network, or leave default if it runs from the same computer you are playing VRChat on.
3. Enter a port number for the application. Typically ports will be anything from 9002 onwards.
4. Press the add button and see that the app now populates in the connected apps list. This list will save even if you close the application.
5. You can now start the server and OSCHub will forward messages to the newly configured application.

# Example configuration for Facetracking + additional apps

1. Create a shortcut for VRCFacetracking, select properties and add the following to the end of target "--osc=9000:127.0.0.1:9002" This will run VRCFT on port 9002

![image](https://user-images.githubusercontent.com/102766533/204104356-d62c9e52-6d7a-493f-bd8d-28e73b95a5cf.png)

2. Open OSCHub and follow the App adding instructions as seen in the previous section. Fill in name, IP, and the port 9002, press add

![image](https://user-images.githubusercontent.com/102766533/204104446-527e6796-d8fa-4149-98d2-0922c7aa23c8.png)

3. Continue to add any additional apps as necessary

![image](https://user-images.githubusercontent.com/102766533/204104492-e8e8b0ef-aded-415c-8273-4c38a55c8c40.png)











