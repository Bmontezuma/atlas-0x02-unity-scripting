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

2. Camera ready
mandatory
Move the Main Camera to position (22, 26, 7). Create a new C# script in the Scripts directory called CameraController.cs.

The script should have a public GameObject player variable that can be edited from the Inspector window.
The camera should follow the Player as it moves. In other words, when the player moves, the camera’s Transform position should also change relative to the Player.
The camera’s position should remain at a constant offset from the Player‘s position.
The camera does not need to rotate.
![image](https://github.com/Bmontezuma/atlas-0x02-unity-scripting/assets/143756794/2ef6d4f1-e2dc-4fbc-b081-35ebef43b5be)
# ***Repo***:

GitHub repository: atlas-0x02-unity-scripting\
File: Assets/maze.unity, Assets/Scripts/CameraController.cs

3. Insert coin
Create a new Cylinder GameObject named Coin.

Position: (27, 1.7, 24)
Rotation: (0, 0, 90)
Scale: (1, .05, .8)
Material Name: coin
Material Color: #FFFF00FF
Tag: Pickup
The Coin‘s Collider component should have Is Trigger checked (Why?)
Turn Coin into a prefab inside a directory called Prefabs
![png](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/421/unity-scripting_3.png)
# ***Repo***:

GitHub repository: atlas-0x02-unity-scripting\
File: Assets/maze.unity, Assets/Prefabs/Coin.prefab, Assets/Materials/coin.mat
