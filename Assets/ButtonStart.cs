using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ButtonBlock : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public Transform buttonScale;
    Vector3 defaultScale;
    // Start is called before the first frame update
    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.2f; 
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
