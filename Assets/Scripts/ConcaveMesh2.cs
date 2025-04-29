using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class TShapeMesh : MonoBehaviour
{
    public Material customMaterial;

    void Start()
    {
        Mesh mesh = new Mesh();
        mesh.name = "T Shape";

        // Vertices
        mesh.vertices = new Vector3[]
        {
            // Bottom vertices (Y = 0)
            new Vector3(0, 0, 2),   // 0 - left bar end
            new Vector3(3, 0, 2),   // 1 - right bar end
            new Vector3(3, 0, 1),   // 2
            new Vector3(2, 0, 1),   // 3
            new Vector3(2, 0, 0),   // 4
            new Vector3(1, 0, 0),   // 5
            new Vector3(1, 0, 1),   // 6
            new Vector3(0, 0, 1),   // 7

            // Top vertices (Y = 1)
            new Vector3(0, 1, 2),   // 8
            new Vector3(3, 1, 2),   // 9
            new Vector3(3, 1, 1),   //10
            new Vector3(2, 1, 1),   //11
            new Vector3(2, 1, 0),   //12
            new Vector3(1, 1, 0),   //13
            new Vector3(1, 1, 1),   //14
            new Vector3(0, 1, 1),   //15
        };

        // Triangles (clockwise winding)
        mesh.triangles = new int[]
        {
            // Bottom face
            0, 2, 1,
            0, 7, 2,
            7, 3, 2,
            7, 6, 3,
            6, 4, 3,
            6, 5, 4,

            // Top face
            8, 9,10,
            8,10,15,
            15,10,11,
            15,11,14,
            14,11,12,
            14,12,13,

            // Front faces
            0, 1, 9,
            0, 9, 8,

            1, 2,10,
            1,10,9,

            2, 3,11,
            2,11,10,

            3, 4,12,
            3,12,11,

            4, 5,13,
            4,13,12,

            5, 6,14,
            5,14,13,

            6, 7,15,
            6,15,14,

            7, 0,8,
            7,8,15,
        };

        // UVs (basic, for texture mapping)
        mesh.uv = new Vector2[mesh.vertices.Length];
        for (int i = 0; i < mesh.vertices.Length; i++)
        {
            mesh.uv[i] = new Vector2(mesh.vertices[i].x / 3f, mesh.vertices[i].z / 2f);
        }

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        mesh.RecalculateTangents();

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = customMaterial != null
            ? customMaterial
            : new Material(Shader.Find("Standard"));

        MeshCollider collider = gameObject.AddComponent<MeshCollider>();
        collider.sharedMesh = mesh;
    }
}