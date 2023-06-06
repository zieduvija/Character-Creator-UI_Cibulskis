using UnityEngine;
using UnityEngine.UI;

public class Size : MonoBehaviour
{
    public GameObject character;
    public Slider widthSlider;
    public Slider heightSlider;

    private Vector3 originalScale;

    private void Start()
    {
        // Store the original scale of the character
        originalScale = character.transform.localScale;

        // Add listeners to the sliders
        widthSlider.onValueChanged.AddListener(ChangeWidth);
        heightSlider.onValueChanged.AddListener(ChangeHeight);
    }

    private void ChangeWidth(float value)
    {
        Vector3 newScale = new Vector3(value, character.transform.localScale.y, character.transform.localScale.z);
        character.transform.localScale = newScale;
    }

    private void ChangeHeight(float value)
    {
        Vector3 newScale = new Vector3(character.transform.localScale.x, value, character.transform.localScale.z);
        character.transform.localScale = newScale;
    }

    public void ResetScale()
    {
        character.transform.localScale = originalScale;
        widthSlider.value = originalScale.x;
        heightSlider.value = originalScale.y;
    }
}