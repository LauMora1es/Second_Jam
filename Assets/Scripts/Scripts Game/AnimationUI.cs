using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationUI : MonoBehaviour
{
    [SerializeField] private GameObject logoMined;
    [SerializeField] private GameObject logoPlatform;
    [SerializeField] private GameObject CanvasGroup;

    void Start()
    {
        LeanTween.moveX(logoMined.GetComponent<RectTransform>(), -445, 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.moveX(logoPlatform.GetComponent<RectTransform>(), -445, 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutBounce);
        alphaButtons();
    }

    private void alphaButtons()
    {
        LeanTween.alpha(CanvasGroup.GetComponent<RectTransform>(), 1f, 1f).setDelay(1f);
        
    }



    void Update()
    {
        
    }
}
