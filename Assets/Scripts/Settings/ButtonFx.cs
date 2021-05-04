using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonFx : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{

    private AudioSource audioSrc;
    [SerializeField] private AudioClip clipToPlay;
    private Vector3 defaultScale = new Vector3(0.413832f, 1.603192f, 0);
    private Vector3 tweenedScale = new Vector3(0.2f , 0.53f, 0);
    [SerializeField] private float duration = 1f; 

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = transform.root.GetComponent<AudioSource>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        audioSrc.PlayOneShot(clipToPlay);
        LeanTween.scale(gameObject,tweenedScale,duration).setEasePunch();
       
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }

   
   
}
