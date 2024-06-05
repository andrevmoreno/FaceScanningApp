using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class FaceTracking : MonoBehaviour
{
    private ARFaceManager arFaceManager;

    void Start()
    {
        arFaceManager = FindObjectOfType<ARFaceManager>();

        if (arFaceManager == null)
        {
            Debug.LogError("ARFaceManager component not found in the scene.");
        }
        else
        {
            Debug.Log("ARFaceManager component found, loading FacePrefab.");
            arFaceManager.facePrefab = Resources.Load<GameObject>("FacePrefab");

            if (arFaceManager.facePrefab != null)
            {
                Debug.Log("FacePrefab loaded successfully.");
            }
            else
            {
                Debug.LogError("Failed to load FacePrefab.");
            }
        }
    }

    void Update()
    {
        if (arFaceManager.trackables.count > 0)
        {
            // Example: Get the first detected face
            ARFace face = arFaceManager.trackables.GetEnumerator().Current as ARFace;

            if (face != null)
            {
                // Example: Log the position of the face
                Debug.Log($"Face position: {face.transform.position}");
            }
        }
    }
}
