# ***Unity - Scripting***
## **8Resources***
Read or watch:

[Unity Manual: Scripting Overview](https://docs.unity3d.com/Manual/ScriptingConcepts.html) (Read sections from “Creating and Using Scripts” to “Understanding Automatic Memory Management”)\
[Scripts as Behavior Components](https://learn.unity.com/tutorial/scripts-as-behaviour-components)\
[How to make a Video Game in Unity - Programming](https://www.youtube.com/watch?v=9ZEu_I-ido4&feature=youtu.be)\
[How to make a Video Game in Unity - Movement](https://www.youtube.com/watch?v=Au8oX5pu5u4)\
[How to make a Video Game in Unity - Camera Follow](https://www.youtube.com/watch?v=HVB6UVcb3f8)\
[Vector Maths](https://learn.unity.com/tutorial/vector-maths)\
[What Makes Great Games Great?](https://www.youtube.com/watch?v=aC3c_pcWwIQ)\
[Unity Manual](https://docs.unity3d.com/Manual/index.html)\
[Unity Tutorials: Scripting](https://learn.unity.com/course/beginner-scripting)\
[Unity Manual: Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html)

## ***Learning Objectives***
### ***General***
- What are ***scripts*** in ***Unity*** and how are they created and used
- How to control ***GameObjects*** with ***scripts***
- What is an event function and how are the most common ones used
- How to create and destroy ***GameObjects*** within scripts
- How to use ***namespaces*** to organize classes
- What are ***attributes*** and how to use them
- How to use ***Debug.Log()***
- What is a ***vector***

## ***Requirements***
### ***General***
- A ***README.md*** file, at the root of the folder of the project
- Use Unity’s default .gitignore in your project folder
- Push the entire repo unity-scripting, including .meta files
- Scenes and project assets such as Materials must be named and organized as described in the tasks
- For this project’s manual review, the reviewer will clone your repo and open your project in Unity

# ***Tasks***
# ***0. Ready player one***

Clone this repository containing a maze Unity project. You will build on this project by adding new GameObjects and scripts to create a playable game. This project should be pushed to its own repo called unity-scripting, not within a subdirectory.

Inside the maze scene, create a ***Sphere*** GameObject named ***Player*** with a ***Rigidbody*** component.

Position: (23, 1.2, 16)\
Scale: (2, 2, 2)\
Material Name: player\
Material Color: #0000FFFF
![png](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/421/unity-scripting_0.png)
## ***Repo***:

GitHub repository: atlas-0x02-unity-scripting\
File: Assets/maze.unity, Assets/Materials/player.mat

# ***1. Bust a move***

Create a directory Scripts. In this directory, create a new C# script called PlayerController.cs. Attach this script to the Player object. Within this script, update the Start() and FixedUpdate() functions to allow the Player to move when either the WASD or arrow keys are pressed

Movement should only be on the X and Z axes – the Player should not be able to jump.
There are many ways to create player movement depending on the way you want your player to behave. The way you implement player movement is up to you, as long as it is possible for Player to move through the maze.
Create a public float speed variable that can be edited in the Inspector to easily modify the Player‘s speed. The value of the Player’s speed is entirely up to you and how you implement player movement.
![gif](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/421/unity-scripting_1.gif)
# ***Repo***:

GitHub repository: atlas-0x02-unity-scripting\
File: Assets/maze.unity, Assets/Scripts/PlayerController.cs

