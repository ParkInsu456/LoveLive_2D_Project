using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    private Camera _camera;
   

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Start()
    {
    }

    private void Update()
    {
        _camera.transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    }

}
