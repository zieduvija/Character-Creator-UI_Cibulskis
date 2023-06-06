using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject panelLeft;
    public GameObject panelLeft2;

    public void Switch()
    {
        panelLeft.SetActive(false);
        panelLeft2.SetActive(true);
    }
}