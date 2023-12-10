using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TouchToStartMotion : MonoBehaviour
{
    // �̹����� ũ�⸦ �ø��� ���� ������ ����
    private Vector2 _originalScale;
    private Vector2 _scaleTo;

    // Start is called before the first frame update
    void Start()
    {
        // �̹����� ũ�� ���� �Ҵ�
        _originalScale = transform.localScale;
        _scaleTo = new Vector2(_originalScale.x * 1.1f, _originalScale.y * 1.1f);

        // ���ӽð�, ���� �� ����
        transform.DOScale(_scaleTo, 1.0f)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1,LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
