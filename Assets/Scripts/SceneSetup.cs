using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    public GameObject spherePrefab;
    public GameObject cubePrefab;
    public GameObject pyramidPrefab;
    public GameObject concave1Prefab;
    public GameObject concave2Prefab;

    void Start()
    {
        // Parent objects
        GameObject parent1 = new GameObject("Parent1");
        GameObject parent2 = new GameObject("Parent2");

        // Position parents
        parent1.transform.position = new Vector3(-5, 0, 0);
        parent2.transform.position = new Vector3(5, 0, 0);

        // Create and setup children
        GameObject sphere = Instantiate(spherePrefab, parent1.transform);
        GameObject cube = Instantiate(cubePrefab, parent1.transform);
        GameObject pyramid = Instantiate(pyramidPrefab, parent2.transform);
        GameObject concave1 = Instantiate(concave1Prefab, parent2.transform);
        GameObject concave2 = Instantiate(concave2Prefab);

        // Add rotators to children
        sphere.AddComponent<ObjectRotator>();
        cube.AddComponent<ObjectRotator>();
        pyramid.AddComponent<ObjectRotator>();
        concave1.AddComponent<ObjectRotator>();
        concave2.AddComponent<ObjectRotator>();

        // Position children relative to parents
        sphere.transform.localPosition = new Vector3(2, 0, 0);
        cube.transform.localPosition = new Vector3(-2, 0, 0);
        pyramid.transform.localPosition = new Vector3(2, 0, 0);
        concave1.transform.localPosition = new Vector3(-2, 0, 0);
        concave2.transform.position = new Vector3(0, 3, 0);
    }
}