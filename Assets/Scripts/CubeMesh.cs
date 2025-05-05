using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class CubeMesh : MonoBehaviour
{
    public Material customMaterial;

    void Start()
    {
        Mesh mesh = new Mesh();
        mesh.vertices = new Vector3[]
        {
        new Vector3(-1, -1, -1), // 0
        new Vector3(1, -1, -1),  // 1
        new Vector3(1, 1, -1),   // 2
        new Vector3(-1, 1, -1),  // 3
        new Vector3(-1, -1, 1),  // 4
        new Vector3(1, -1, 1),   // 5
        new Vector3(1, 1, 1),    // 6
        new Vector3(-1, 1, 1)    // 7
        };

        mesh.triangles = new int[]
        {
        // Front face (z = -1)
        0, 2, 1,
        0, 3, 2,
        // Back face (z = 1)
        5, 6, 4,
        4, 6, 7,
        // Bottom face (y = -1)
        0, 1, 5,
        0, 5, 4,
        // Top face (y = 1)
        3, 7, 6,
        3, 6, 2,
        // Left face (x = -1)
        0, 4, 7,
        0, 7, 3,
        // Right face (x = 1)
        1, 2, 6,
        1, 6, 5
        };

        // uv coords
        mesh.uv = new Vector2[]
        {
        // Font face
        new Vector2(0, 0),
        new Vector2(1, 0),
        new Vector2(1, 1),
        new Vector2(0, 1),
        // Back face
        new Vector2(0, 0),
        new Vector2(1, 0),
        new Vector2(1, 1),
        new Vector2(0, 1)
        };

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        mesh.RecalculateTangents();

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = customMaterial != null
            ? customMaterial
            : new Material(Shader.Find("Standard"));

        transform.position = new Vector3(0, 0, -5);
    }
}