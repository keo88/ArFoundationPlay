using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBallManager : MonoBehaviour
{
    public GameObject Ball;
    public Transform CamObj;
    public Transform ShootBallPoint;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            ShootBallObj();
        }
    }

    public void ShootBallObj()
    {
        GameObject bObj = Instantiate(Ball);
        bObj.transform.position = ShootBallPoint.transform.position;
        Vector3 tVec = (ShootBallPoint.transform.position - CamObj.transform.position).normalized;

        Rigidbody tR = bObj.GetComponent<Rigidbody>();

        tR.AddForce(tVec * 100f);
    }
}
