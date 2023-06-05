using UnityEngine;
using UnityEngine.UI;

public class testa : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    public int newWidth = 178;
    public int newHeight = 333;
    public Texture newTexture;

    private RawImage rawImage;
    private Vector3 originalScale;
    private Vector2 originalSizeDelta;

    private void Start()
    {
        rawImage = GetComponent<RawImage>();
        originalScale = transform.localScale;
        originalSizeDelta = GetComponent<RectTransform>().sizeDelta;
    }

    private void OnMouseDown()
    {
        if (!isDragging)
        {
            offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Change object's resolution
            RectTransform rectTransform = GetComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(newWidth, newHeight);

            // Change object's texture
            rawImage.texture = newTexture;

            isDragging = true;
        }
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
    }

    private void OnMouseUp()
    {
        if (isDragging)
        {
            // Reset object's scale
            transform.localScale = originalScale;

            // Lock the object in place
            isDragging = false;
        }
    }
}