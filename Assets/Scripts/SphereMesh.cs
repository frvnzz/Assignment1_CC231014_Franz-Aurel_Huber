using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SphereMesh : MonoBehaviour
{
    public Material customMaterial;

    void Start()
    {
        Mesh mesh = new Mesh();

        // vertices for uv sphere
        int latitudeSegments = 12;
        int longitudeSegments = 24;
        float radius = 1f;

        List<Vector3> vertices = new List<Vector3>();
        List<int> triangles = new List<int>();

        for (int lat = 0; lat <= latitudeSegments; lat++)
        {
            float theta = Mathf.PI * lat / latitudeSegments;
            float sinTheta = Mathf.Sin(theta);
            float cosTheta = Mathf.Cos(theta);

            for (int lon = 0; lon <= longitudeSegments; lon++)
            {
                float phi = 2 * Mathf.PI * lon / longitudeSegments;
                float sinPhi = Mathf.Sin(phi);
                float cosPhi = Mathf.Cos(phi);

                float x = radius * sinTheta * cosPhi;
                float y = radius * cosTheta;
                float z = radius * sinTheta * sinPhi;

                vertices.Add(new Vector3(x, y, z));
            }
        }

        for (int lat = 0; lat < latitudeSegments; lat++)
        {
            for (int lon = 0; lon < longitudeSegments; lon++)
            {
                int current = lat * (longitudeSegments + 1) + lon;
                int next = current + longitudeSegments + 1;

                triangles.Add(current);
                triangles.Add(next);
                triangles.Add(current + 1);

                triangles.Add(current + 1);
                triangles.Add(next);
                triangles.Add(next + 1);
            }
        }

        mesh.vertices = vertices.ToArray();
        mesh.triangles = triangles.ToArray();

        // uv coordinates
        Vector2[] uvs = new Vector2[vertices.Count];
        for (int i = 0; i < vertices.Count; i++)
        {
            Vector3 vertex = vertices[i];
            float u = 0.5f + Mathf.Atan2(vertex.z, vertex.x) / (2f * Mathf.PI);
            float v = 0.5f - Mathf.Asin(vertex.y) / Mathf.PI;
            uvs[i] = new Vector2(u, v);
        }
        mesh.uv = uvs;

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        mesh.RecalculateTangents();

        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = customMaterial != null
            ? customMaterial
            : new Material(Shader.Find("Standard"));

        transform.position = new Vector3(0, 2, 5);
    }
}