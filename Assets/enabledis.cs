using UnityEngine;

public class enabledis : MonoBehaviour
{
    public GameObject objectToControl;

    // This method is called when the event trigger component on another object is triggered
    public void ToggleObject()
    {
        if (objectToControl != null)
        {
            // Check if the object is currently enabled or disabled
            if (objectToControl.activeSelf)
            {
                // Disable the object if it is currently enabled
                objectToControl.SetActive(false);
            }
            else
            {
                // Enable the object if it is currently disabled
                objectToControl.SetActive(true);
            }
        }
        else
        {
            Debug.LogError("Object to control is not assigned!");
        }
    }
}