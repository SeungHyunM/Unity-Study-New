using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LogoMotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ���� �����ϴ� ���
        RectTransform Vector2 = GetComponent<RectTransform>();
        Vector2.DOAnchorPosY(50,1).SetEase(Ease.OutBounce); 
    }


    // Update is called once per frame
    void Update()
    {

    }
}
