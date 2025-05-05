## About The Project

### Built With
* Unity 2022.3.61f1
* C# for scripting
* Visual Studio Code

## Getting Started 
To get this project up and running on your local machine, follow these steps.

### Prerequisites
* Unity Hub
* Unity 2022.3.61f1 or later
* Git (optional, for cloning)
* Basic knowledge of Unity Editor

### Installation
1. **Option A: Clone the repository**
   ```bash
   git clone https://github.com/frvnzz/Assignment1_CC231014_Franz-Aurel_Huber.git
   ```

2. **Option B: Download directly**
   * Download the ZIP file from [here](https://github.com/frvnzz/Assignment1_CC231014_Franz-Aurel_Huber/archive/refs/heads/main.zip)
   * Extract the ZIP file to your desired location

### Usage
1. **Open the Project**
   * Launch Unity Hub
   * Click "Add" and select the project folder
   * Open the project with Unity 2022.3.61f1

2. **Setup**
   * Open the main scene from `Assets/Scenes/Main.scene`
   * Ensure the SceneManager object has the SceneSetup script attached
   * Verify all prefabs are assigned in the Inspector:
     - Sphere Prefab
     - Cube Prefab
     - Pyramid Prefab
     - Concave1 Prefab
     - Concave2 Prefab

3. **Controls**
   * Press Play to start the scene
   * Objects will automatically rotate around their parent objects
   * The Shooter object:
     - Constantly shows raycasting with reflection
     - Green lines show reflection paths
     - Yellow markers indicate impact points

4. **Custom Changes**
   * Adjust rotation speed in the ObjectRotator component
   * Modify ray colors and duration in the Shooter component
   * Change object materials by:
     1. Creating a material in the Project window
     2. Assigning a texture from `Assets/Materials`
     3. Dragging the material to the Custom Material field

## Roadmap
### Implemented Features
* Procedurally generated 3D objects
  - UV Sphere with texture mapping
  - Cube with proper UV coordinates
  - Pyramid with basic geometry
  - Two concave shapes (L-shape and T-shape)
* Parent-child relationships with automated rotation in `SceneSetup.cs`
* Raycasting with reflections through `Shooter.cs`
* Custom material support for all objects

### Planned Features
* Interactive camera controls
* Better (physics-based, etc.) object interactions

## License 
Distributed under the Unlicense License. See `/Docs/LICENSE` for more information.

## Contact
Franz-Aurel Huber – [cc231014@fhstp.ac.at](mailto:cc231014@fhstp.ac.at)

## Acknowledgments
*Concrete Texture  
`Assets/Materials/concrete368.png`  
Source: [OpenGameArt.org](https://opengameart.org/node/9981), licensed under the [GNU GPL 2.0](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html), [GNU GPL 3.0](https://www.gnu.org/licenses/gpl-3.0.en.html), [GNU LGPL 3.0](https://www.gnu.org/licenses/lgpl-3.0.en.html), and [Creative Commons Attribution 3.0](https://creativecommons.org/licenses/by/3.0/).*

*Dirt Texture  
`Assets/Materials/dirt1.png`  
Source: [OpenGameArt.org](https://opengameart.org/content/dirt-004), licensed under the [Creative Commons Attribution 3.0](https://creativecommons.org/licenses/by/3.0/).*

*Fire Texture  
`Assets/Materials/fire.jpg`  
Source: [OpenGameArt.org](https://opengameart.org/node/7763), licensed under the [CC0 1.0 Universal](https://creativecommons.org/publicdomain/zero/1.0/).*

*Water Texture  
`Assets/Materials/tex_Water.jpg`  
Source: [OpenGameArt.org](https://opengameart.org/node/10510), licensed under the [Creative Commons Attribution 3.0](https://creativecommons.org/licenses/by/3.0/).*

*Earth Texture  
`Assets/Materials/tex.bmp_8.png`  
Source: [OpenGameArt.org](https://opengameart.org/node/12616), licensed under the [Creative Commons Attribution 3.0](https://creativecommons.org/licenses/by/3.0/).*