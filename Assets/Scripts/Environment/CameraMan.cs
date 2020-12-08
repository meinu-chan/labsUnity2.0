using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float rotationSpeed = 50;
    [SerializeField] float zoomSpeed = 50;
    [SerializeField] Camera _camera;
    [SerializeField] float minDistance;
    [SerializeField] float maxDistance;
    private Vector3 rotation;
    private float zoom = 0f;


    private void Start() {
    }
    private void LateUpdate()
    {
        transform.position = target.position;
        RotateCamera();
        if(Input.GetAxis("Mouse ScrollWheel")!=0)
        {
            CameraZoom();      
        }
        if(Input.GetMouseButton(2)){
            Debug.Log(Input.GetMouseButton(2));
        }
    }

    private void RotateCamera(){
        rotation = transform.eulerAngles;
        rotation.y += Input.GetAxis("Horizontal") * -rotationSpeed * Time.deltaTime;
        transform.eulerAngles = rotation;
    }

    private void CameraZoom(){
        zoom = Input.GetAxis("Mouse ScrollWheel") * -zoomSpeed;
        if(_camera.fieldOfView + zoom < maxDistance  && _camera.fieldOfView + zoom > minDistance){
            _camera.fieldOfView += zoom;
        }
    }
}