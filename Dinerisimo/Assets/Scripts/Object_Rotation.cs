using UnityEngine;

public class Object_Rotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5f;
    private bool isDragging = false;                    //Necessary so the object doesn't move just mantaining the mouse button clicked.

    private void Update()
    {
        //Reset the object rotation to 0.
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation = Quaternion.identity;
        }
    }

    private void OnMouseDrag()
    {
        //First we check if its moving (horizontally or vertically) or not
        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            isDragging = true;
        }
        else
        {
            isDragging = false;
        }

        //If there's movement, we rotate the object accordingly.
        if (isDragging)
        {
            //In order to rotate in the way we want, it has to be in WORLD COORDINATES instead of local ones.
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0) * rotationSpeed, Space.World);
        }
    }

}
