# Formational-Movement
# Unity Two-Level Finger-Four Formation

## Overview

This Unity repository showcases the implementation of a two-level finger-four formation with four characters. The program introduces three additional characters to complete the formation. The characters dynamically respond to user input, maintaining their formation while navigating around obstacles.

## Features

- **Formation Movement:** Characters use a modified kinematic arrive method to move in a two-level finger-four formation.

- **User Interaction:**
  - **Right-Click:** Creates a player-sized obstacle on the plane, blocking characters' paths.
  - **Left-Click:** Triggers the formation to move to the clicked spot using the modified kinematic arrive method.

- **Obstacle Avoidance:** Characters intelligently avoid obstacles without relying on pathfinding, ensuring smooth navigation while preserving their formation.

- **Orientation Tracking:** Each character's orientation is visually represented, providing a clear indication of their facing direction.

## Usage

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/unity-finger-four-formation.git
   ```

2. **Open in Unity:**
   - Open the Unity software.
   - Load the project.

3. **Run the Scene:**
   - Execute the scene.
   - Interact with the plane using right-clicks to create obstacles and left-clicks to move the formation.
