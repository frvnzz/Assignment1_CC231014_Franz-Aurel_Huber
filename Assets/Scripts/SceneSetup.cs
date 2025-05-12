using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    public GameObject spherePrefab;
    public GameObject cubePrefab;
    public GameObject pyramidPrefab;
    public GameObject concave1Prefab;
    public GameObject concave2Prefab;

    [SerializeField] private float objectRotationSpeed = 30f;

    void Start()
    {
        // parent objects
        GameObject parent1 = new GameObject("Parent1");
        GameObject parent2 = new GameObject("Parent2");

        // position parents
        parent1.transform.position = new Vector3(-5, 0, 0);
        parent2.transform.position = new Vector3(5, 0, 0);

        // children
        GameObject sphere = Instantiate(spherePrefab, parent1.transform);
        GameObject cube = Instantiate(cubePrefab, parent1.transform);
        GameObject pyramid = Instantiate(pyramidPrefab, parent2.transform);
        GameObject concave1 = Instantiate(concave1Prefab, parent2.transform);
        GameObject concave2 = Instantiate(concave2Prefab);

        // rotators for children
        sphere.AddComponent<ObjectRotator>().SetRotationSpeed(objectRotationSpeed);
        cube.AddComponent<ObjectRotator>().SetRotationSpeed(objectRotationSpeed);
        pyramid.AddComponent<ObjectRotator>().SetRotationSpeed(objectRotationSpeed);
        concave1.AddComponent<ObjectRotator>().SetRotationSpeed(objectRotationSpeed);
        concave2.AddComponent<ObjectRotator>().SetRotationSpeed(objectRotationSpeed);

        // positioning children relative to parents
        sphere.transform.localPosition = new Vector3(2, 0, 0);
        cube.transform.localPosition = new Vector3(-2, 0, 0);
        pyramid.transform.localPosition = new Vector3(2, 0, 0);
        concave1.transform.localPosition = new Vector3(-2, 0, 0);
        concave2.transform.position = new Vector3(0, 3, 0);
    }
}