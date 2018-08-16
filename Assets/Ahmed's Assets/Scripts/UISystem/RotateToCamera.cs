using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCamera : MonoBehaviour {

    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private GameObject player;

    public void OnEnable()
    {
        Vector3 position = mainCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 1.5f));
        transform.position = position;
        transform.rotation = Quaternion.LookRotation(position - player.transform.position);
    }
}
