using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float rotationSpeed = 50;
    [SerializeField] float zoomSpeed = 1000;
    [SerializeField] Camera _camera;
    private Vector3 rotation;


    private void Start() {
    }
    private void LateUpdate()
    {
        transform.position = target.position;
        RotateCamera();
        // CameraZoom();
    }

    private void RotateCamera(){
        rotation = transform.eulerAngles;
        rotation.y += Input.GetAxis("Horizontal") * -rotationSpeed * Time.deltaTime;
        transform.eulerAngles = rotation;
    }

    // private void CameraZoom(){

    //     Vector3 cameraZoom = _camera.transform.position;
    //     cameraZoom += new Vector3(-1, 1 ,-1) * Input.GetAxis("Mouse ScrollWheel") * -zoomSpeed * Time.deltaTime;

    //     _camera.transform.position = cameraZoom;

    // }
}