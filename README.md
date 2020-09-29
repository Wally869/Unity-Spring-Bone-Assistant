# Unity-Spring-Bone-Assistant
Helper Script to mark bones as spring bones for hair and clothes physics, using spring bones script from the Unity-chan Toon Shader repository.

Tested on Unity 2019.4.7f


## Overview
The Unity-chan Toon Shader repository [includes scripts for "Spring Bones"](https://github.com/unity3d-jp/UnityChanToonShaderVer2_Project/tree/release/legacy/2.0/Assets/UnityChan/Scripts), aka bones that will be affected by the movement of the main mesh, but will go back to their default position over time. 

This is really useful for hair and clothes physics (see this article for details: https://www.noveltech.dev/unity-implement-hair-clothes-physics/ or this video: https://www.youtube.com/watch?v=ABLFXcSHodE)

The main problems with the spring bones provided:
- The spring bone script must be set to every hair bone. If your hair is very detailed, that means you need to set it at every level of the bone hierarchy.
- These bones must then be recorded in the spring bone manager (SpringManager.cs)

This repository therefore contains utilities to make this process less bothersome.


## How to Use
- For every strand of hair, put a SpringBoneMarker at the top most level.
- Add a SpringBoneAssistant somewhere in the hierarchy and add a reference to a SpringManager Component previously added.
- Click the "Mark Children" button

What happens here:  
1- The SpringBoneAssistant will get all objects which have a SpringBoneMarker component  
2- It will check if it has children. If it does, it will get the children and add a SpringBoneMarker component to them too  
3- Once all possible objects have been marked, it will once again get all objects with a SpringBoneMarker component  
4- All these objects will have a SpringBone component added to them, and the SpringBoneMarker will be deleted  
5- All SpringBones will be registered in the SpringManager  


## To Note  
This code works in the global scale, so if you want to set the spring bones to your character using this code, make sure you are doing it in a scene that does not contain another object with spring bones. 


