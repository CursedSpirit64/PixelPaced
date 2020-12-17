using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //public Transform target;
    //public float smoothSpeed = 0.125f;
    public Vector3 cameraOffSet;
    private GameObject playerObj;

    void FixedUpdate()
    {
        //Vector3 desiredPosition = target.position + offset;
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        //transform.position = smoothedPosition;

        //transform.LookAt(target);
    }

    void Start()
    {
        playerObj = GameObject.Find("Player");
        //cameraOffSet = new Vector3(0, 1, -5);
    }

    void Update()
    {
        transform.position = playerObj.transform.position + cameraOffSet;
    }
}
