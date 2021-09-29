using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SetARBall : MonoBehaviour
{
    public ARRaycastManager MyRayCastManager;
    static List<ARRaycastHit> Hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0) 
        {
            Vector2 touchPosition = Input.GetTouch(0).position;
            if(MyRayCastManager.Raycast(touchPosition, Hits, TrackableType.PlaneWithinPolygon))
            {
                var hitPose = Hits[0].pose;
                Instantiate(MyRayCastManager.raycastPrefab, hitPose.position, hitPose.rotation);
            }
        }
    }
}
