using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TouchToStartMotion : MonoBehaviour
{
    // 이미지의 크기를 늘리기 위해 변수를 지정
    private Vector2 _originalScale;
    private Vector2 _scaleTo;

    // Start is called before the first frame update
    void Start()
    {
        // 이미지에 크기 값을 할당
        _originalScale = transform.localScale;
        _scaleTo = new Vector2(_originalScale.x * 1.1f, _originalScale.y * 1.1f);

        // 지속시간, 루프 값 설정
        transform.DOScale(_scaleTo, 1.0f)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1,LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
