using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveVRCameraLerp : MonoBehaviour
{
    public Transform target;

    public Transform fromRot;
    public Transform toRot;
    public float smoothTime = 3F;
    public float rotateSpeed = 2F;
    private Vector3 velocity = Vector3.zero;

     public float timeCounter;

    void FixedUpdate()
    {
        timeCounter -= Time.fixedDeltaTime;

        if (timeCounter < 0.0f)
        {
            // Define a target position above and behind the target transform
            Vector3 targetPosition = target.transform.position;// .TransformPoint(new Vector3(0, 5, -10));
            Vector3 targetRotation = target.transform.rotation.eulerAngles;

            // Smoothly move the camera towards that target position
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
            transform.rotation = Quaternion.Slerp(fromRot.rotation, toRot.rotation, rotateSpeed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(0);
    }
}
