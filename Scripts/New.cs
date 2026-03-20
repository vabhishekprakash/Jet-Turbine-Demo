using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceAfterTracking : MonoBehaviour
{
    public GameObject turbine;
    public float distance = 1.5f;

    private bool placed = false;

    void Update()
    {
        if (!placed && ARSession.notTrackingReason == NotTrackingReason.None)
        {
            Transform cam = Camera.main.transform;
            Vector3 forward = cam.forward;
            Vector3 newPos = cam.position + forward * distance;
            turbine.transform.position = newPos;

            // Optional: rotate to face the camera
            turbine.transform.LookAt(cam);
            placed = true;
        }
    }
}
