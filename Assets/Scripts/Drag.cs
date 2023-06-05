using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importē, lai varētu lietot pointer darbību Interfeisu
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IPointerDownHandler, 
    IBeginDragHandler, IDragHandler, IEndDragHandler{
    private RectTransform transformacijasLogs;
    public Canvas kanva;


    void Start () {
        transformacijasLogs = GetComponent<RectTransform> ();
    }
	
    public void OnPointerDown(PointerEventData notikums){
        //Debug.Log ("Kreisais klikšḱis uz velkama objekta!");
    }

    public void OnBeginDrag(PointerEventData notikums){
        //Debug.Log ("Uzsākta objekta vilkšana!");
    }

    public void OnDrag(PointerEventData notikums){
       // Debug.Log ("Notiek objekta vilkšana!");
        transformacijasLogs.anchoredPosition += 
            notikums.delta / kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData notikums){
       Debug.Log ("Objekta vilkšana pārtraukta!");
    }
}