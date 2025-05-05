using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class PyramidMesh : MonoBehaviour
{
    public Material customMaterial;

    void Start()
    {
        Mesh mesh = new Mesh();

        mesh.vertices = new Vector3[]
        {
            // Base
            new Vector3(-1, 0, -1),
            new Vector3(1, 0, -1),
            new Vector3(1, 0, 1),
            new Vector3(-1, 0, 1),
            // Top
            new Vector3(0, 2, 0)
        };

        mesh.triangles = new int[]
        {
            // Base
            0, 1, 2,
            0, 2, 3,
            // Sides
            0, 4, 1,
            1, 4, 2,
            2, 4, 3,
            3, 4, 0
        };

        mesh.uv = new Vector2[]
        {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(1, 1),
            new Vector2(0, 1),
            new Vector2(0.5f, 0.5f)
        };

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = customMaterial != null ?
            customMaterial :
            new Material(Shader.Find("Standard"));

        gameObject.AddComponent<MeshCollider>();
    }
}