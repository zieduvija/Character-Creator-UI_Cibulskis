using UnityEngine;
using UnityEngine.UI;

public class RAAHH : MonoBehaviour
{
    public Texture[] objectImages; // Array of images
    private int currentImageIndex = 0; // Index of the current image
    private bool isDragging = false; // Flag to indicate if the object is being dragged

    private Vector3 offset;

    // Reference to other draggable objects
    public RAAHH[] otherObjects;

    private void OnMouseDown()
    {
        isDragging = true;
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        SetObjectOnTop(); // Set the object on top of others
        ResetOtherObjects(); // Reset the other objects
        ChangeObjectImage(); // Change the object's image
        SetObjectSize(); // Set the object's size
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        transform.position = new Vector3(newPosition.x, newPosition.y, 0f);
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

    private void ChangeObjectImage()
    {
        string objectTag = gameObject.tag; // Get the tag of the selected object

        // Check the object's tag and update the image accordingly
        switch (objectTag)
        {
            case "p1":
                currentImageIndex = 2;
                Debug.Log("RAAH");
                break;
            case "p2":
                currentImageIndex = 1;
                break;
            case "p3":
                currentImageIndex = 2;
                break;
            case "p4":
                currentImageIndex = 3;
                break;
            case "p5":
                currentImageIndex = 4;
                break;
            default:
                currentImageIndex = 0; // Default to the first image if the tag is not found
                break;
        }

        // Change the object's image
        RawImage rawImage = GetComponent<RawImage>();
        if (rawImage != null && objectImages.Length > currentImageIndex)
        {
            rawImage.texture = objectImages[currentImageIndex];
        }
    }

    private void SetObjectSize()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            rectTransform.sizeDelta = new Vector2(178f, 333f);
        }
    }

    private void SetObjectOnTop()
    {
        transform.SetAsLastSibling();
    }

    private void ResetOtherObjects()
    {
        foreach (RAAHH otherObject in otherObjects)
        {
            if (otherObject != null && otherObject != this)
            {
                otherObject.ResetObject();
            }
        }
    }

    private void ResetObject()
    {
        currentImageIndex = 0; // Reset the current image index

        // Reset the object's image and size
        RawImage rawImage = GetComponent<RawImage>();
        if (rawImage != null && objectImages.Length > currentImageIndex)
        {
            rawImage.texture = objectImages[currentImageIndex];
        }

        RectTransform rectTransform = GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            rectTransform.sizeDelta = Vector2.zero; // Reset the size
        }
    }
}
