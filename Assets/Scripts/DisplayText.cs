using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public string text;
    public int str;
    public GameObject nameInput;
    public GameObject ageInput;
    public GameObject textContent;
    public Slider widthSlider;
    public Slider heightSlider;

    public void SaveText()
    {
        text = nameInput.GetComponent<InputField>().text;
        str = int.Parse(ageInput.GetComponent<InputField>().text);
        textContent.GetComponent<Text>().text = "This man's name is " + text.ToUpper() + ", he is " + str + " years old.\nHe is a great person because he helps people.\nLegend says that he once saved the president of Latvia, Egils Levits." +
                                                "\nHis superpower is handing homework in fashionably late.";
        
        widthSlider.interactable = false;
        heightSlider.interactable = false;
    }
}
