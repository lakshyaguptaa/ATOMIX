using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnableDisableObject : MonoBehaviour, IPointerClickHandler
{
    public GameObject objectToToggle;

    private void Start()
    {
        // Make sure the object to toggle is set in the Unity editor.
        if (objectToToggle == null)
        {
            Debug.LogError("Object to toggle is not set. Please assign it in the Unity editor.");
            enabled = false;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Toggle the active state of the object.
        objectToToggle.SetActive(!objectToToggle.activeSelf);
    }
}
