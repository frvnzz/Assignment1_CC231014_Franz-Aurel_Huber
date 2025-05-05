# Assignment1 Report

Course: C# Development SS2025 (4 ECTS, 3 SWS)

Student ID: cc231014

BCC Group: A

Name: Franz-Aurel Huber

## Methodology
1. **Procedural Mesh Generation**
   - Created basic geometric shapes using vertex and triangle arrays
   - Implemented UV mapping for proper texture support

2. **Scene Organization**
   - Parent-child relationships using Unity's transform hierarchy

3. **Raycasting**
   - Reflection calculations using Vector3.Reflect
   - Added visual feedback for ray impacts and reflections

## Additional Features
Beyond the basic requirements, the project includes:

1. **Material System**
   - Custom material support for all procedural meshes
   - Default material fallback

## Discussion/Conclusion

1. **UV Mapping Complexities**
   - Challenge: Initial texture distortion on spherical surfaces
   - Solution: Implemented proper spherical UV projection using trigonometric calculations
   - Result: Achieved smoother texture mapping on curved surfaces

2. **Parent-Child Rotation**
   - Challenge: Objects rotating incorrectly around world origin
   - Solution: Used RotateAround with parent position as pivot
   - Result: Smooth orbital rotation around parent objects

3. **Mesh Generation**
   - Challenge: Vertex order causing incorrect face orientation
   - Solution: Using the right triangle winding order (clockwise)
   - Result: Proper face visibility direction

## Work with: 
/

## References: 
### Websites:  
[Unity Documentation – Physics.Raycast](https://docs.unity3d.com/6000.1/Documentation/ScriptReference/Physics.Raycast.html)  

### Videos:  
[Unity How To C# - Raycast ( EP: 11 )](https://www.youtube.com/watch?v=nrlRLkLBrok)  
[Where Do UV Coordinates Come From](https://www.youtube.com/watch?v=Gv3ps7Wq4YE)  
[Unity Shader Graph Basics (Part 2 - Textures and UVs)](https://www.youtube.com/watch?v=jVNC0Z2p9qw)
[Rotate Object with C# Script in Unity](https://www.youtube.com/watch?v=q19yNW5jot4)