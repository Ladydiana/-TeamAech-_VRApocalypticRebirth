using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {

    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private GameObject player;

    public void UILookAtCamera()
    {
        Vector3 position = mainCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 1.5f));
        transform.position = position;
        transform.rotation = Quaternion.LookRotation(position - player.transform.position);
    }
}
