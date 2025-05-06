 IndoorNavAssistantUnity

This project is a Unity-based simulation of an indoor navigation assistant robot that autonomously explores a 3D space while detecting and avoiding obstacles.

 Demo Video

 [Watch on YouTube](https://youtu.be/s4eISNhlycw)  

 Project Overview

This simulation demonstrates:
- Obstacle detection using raycasting
- Autonomous robot movement with smart avoidance logic
- Real-time visual alerts (cube color change)
- Boundary-aware navigation using physics and colliders
- Top-down camera system for monitoring

Developed as part of a 3D Vision & Augmented Reality course project.


 Features

- Unity 3D scene with custom floor, obstacles, and player robot
- `AutoMove.cs` script for movement and directional decisions
- `ObstacleAlert.cs` script for proximity detection and response
- Collision-based wall blocking to confine the robot in a play area

 How to Run

1. Clone the repo or download the source
2. Open it in **Unity 2023.2.20f1** or compatible version
3. Open `Assets/Scenes/SampleScene.unity`
4. Press Play to start the simulation

Folder Structure

Assets/
├── Scenes/
│ └── SampleScene.unity
├── Scripts/
│ ├── AutoMove.cs
│ └── ObstacleAlert.cs
ProjectSettings/
Packages/


 Technologies Used

- Unity Engine
- C#
- Unity Physics
- Raycasting & Transform Manipulation


 Author

VISHNUVARDHAN MUDDA  
GitHub: [Vishnu0813](https://github.com/Vishnu0813)


 AI Usage Statement

> I used ChatGPT as a support tool to help write, troubleshoot, and optimize Unity C# scripts and scene setup. All logic was reviewed, adapted, and tested manually to ensure understanding and learning outcomes were met.





