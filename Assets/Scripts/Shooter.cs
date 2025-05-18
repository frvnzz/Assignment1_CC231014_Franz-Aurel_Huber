using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float rayLength = 10f;
    public LayerMask raycastLayers = -1;  // all layers by default
    public Color primaryRayColor = Color.red;
    public Color reflectionRayColor = Color.green;
    public float rayDuration = 1f;
    public bool showRaysConstantly = true;

    private Ray currentRay;
    private RaycastHit currentHit;
    private bool hasHit;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || showRaysConstantly)
        {
            ShootRay();
        }
    }

    void ShootRay()
    {
        currentRay = new Ray(transform.position, transform.forward);
        hasHit = Physics.Raycast(currentRay, out currentHit, rayLength, raycastLayers);

        if (hasHit)
        {
            // log the name of the object hit
            Debug.Log("Hit object: " + currentHit.transform.gameObject.name);

            // initial ray
            Debug.DrawLine(currentRay.origin, currentHit.point, primaryRayColor, rayDuration);

            // draw reflection
            Vector3 reflectDir = Vector3.Reflect(currentRay.direction, currentHit.normal);
            Debug.DrawRay(currentHit.point, reflectDir * rayLength, reflectionRayColor, rayDuration);

            // impact effect
            CreateImpactEffect(currentHit.point);
        }
        else
        {
            // draw ray when nothing is hit
            Debug.DrawRay(currentRay.origin, currentRay.direction * rayLength, primaryRayColor, rayDuration);
        }
    }

    // optional impact effect
    void CreateImpactEffect(Vector3 position)
    {
        Debug.DrawLine(
            position + Vector3.up * 0.1f,
            position - Vector3.up * 0.1f,
            Color.yellow,
            rayDuration
        );
    }
}