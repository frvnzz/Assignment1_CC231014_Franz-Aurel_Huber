using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class ConcaveMesh1 : MonoBehaviour
{
    public Material customMaterial;

    void Start()
    {
        Mesh mesh = new Mesh();

        mesh.vertices = new Vector3[]
        {
            // Bottom face
            new Vector3(0, 0, 0),     // 0
            new Vector3(2, 0, 0),     // 1
            new Vector3(2, 0, 1),     // 2
            new Vector3(1, 0, 1),     // 3
            new Vector3(1, 0, 2),     // 4
            new Vector3(0, 0, 2),     // 5
            
            // Top face
            new Vector3(0, 1, 0),     // 6
            new Vector3(2, 1, 0),     // 7
            new Vector3(2, 1, 1),     // 8
            new Vector3(1, 1, 1),     // 9
            new Vector3(1, 1, 2),     // 10
            new Vector3(0, 1, 2),     // 11
        };

        mesh.triangles = new int[]
        {
            // Bottom face
            0, 1, 2,
            0, 2, 3,
            0, 3, 4,
            0, 4, 5,
            
            // Top face
            6, 8, 7,
            6, 9, 8,
            6, 10, 9,
            6, 11, 10,
            
            // Outer walls
            // Front wall
            0, 7, 1,
            0, 6, 7,
            
            // Right front wall
            1, 8, 2,
            1, 7, 8,
            
            // Right inner wall
            2, 9, 3,
            2, 8, 9,
            
            // Back inner wall
            3, 10, 4,
            3, 9, 10,
            
            // Back wall
            4, 11, 5,
            4, 10, 11,
            
            // Left wall
            5, 6, 0,
            5, 11, 6,
            
            // Inner corner walls
            3, 10, 9,
            3, 4, 10,
        };

        mesh.uv = new Vector2[]
        {
            // bottom face uv coords
            new Vector2(0, 0),     // 0
            new Vector2(1, 0),     // 1
            new Vector2(1, 0.5f),  // 2
            new Vector2(0.5f, 0.5f), // 3
            new Vector2(0.5f, 1),  // 4
            new Vector2(0, 1),     // 5
            
            // top face uv coords
            new Vector2(0, 0),     // 6
            new Vector2(1, 0),     // 7
            new Vector2(1, 0.5f),  // 8
            new Vector2(0.5f, 0.5f), // 9
            new Vector2(0.5f, 1),  // 10
            new Vector2(0, 1),     // 11
        };

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        mesh.RecalculateTangents();

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = customMaterial != null ?
            customMaterial :
            new Material(Shader.Find("Standard"));

        MeshCollider meshCollider = gameObject.AddComponent<MeshCollider>();
        meshCollider.sharedMesh = mesh;
    }
}