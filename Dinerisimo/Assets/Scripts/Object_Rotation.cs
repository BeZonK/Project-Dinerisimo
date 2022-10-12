
using UnityEngine;


public class Object_Rotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10f;
    private bool isDragging = false;                    //Necessary so the object doesn't move just mantaining the mouse button clicked.

    private void OnMouseDrag()
    {
        //First we check if tis moving (horizontally or vertically) 
        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            isDragging = true;
        }

        //If there's no movement
        else
        {
            isDragging = false;
        }

        if (isDragging)
        {
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0) * rotationSpeed);
        }
    }

}
