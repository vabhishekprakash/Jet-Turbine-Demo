using UnityEngine;

public class PlaceInFrontOfCamera : MonoBehaviour
{
    void Start()
    {
        Transform cam = Camera.main.transform;
        transform.position = cam.position + cam.forward * 1.0f;  // 1 meter in front
        transform.LookAt(cam.position); // optional
    }
}
