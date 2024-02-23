using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookCamera : MonoBehaviour
{
    public float sensitivity = 6.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    private float _rotationX = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rotationX -= Input.GetAxis("Mouse Y")*sensitivity;
        _rotationX = Mathf.Clamp(_rotationX,minimumVert,maximumVert);
        transform.localEulerAngles = new Vector3(_rotationX,0,0); 
        //transform.Rotate(_rotationX,0,0);
        //float rotationY = transform.localEulerAngles.y;
        //transform.eulerAngles = new Vector3(_rotationX,rotationY,0);
    }
}
