using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PanelHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        // transform의 scale값을 모두 0.1f로 변경합니다.
        transform.localScale = new Vector2(0.1f, 0.1f);
        //객체를 비활성화 합니다.
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);

        //DOTween 함수를 차례대로 수행하도록
        var seq = DOTween.Sequence();

        //Doscale의 첫번째 파라미터는 목표 Scale값, 두번째는 시간
        seq.Append(transform.DOScale(1.1f, 0.2f));
        seq.Append(transform.DOScale(1f, 0.1f));

        seq.Play();
    }

    public void Hide()
    {
        var seq = DOTween.Sequence();

        transform.localScale = Vector3.one * 0.2f;

        seq.Append(transform.DOScale(1.1f, 0.1f));
        seq.Append(transform.DOScale(0.2f, 0.2f));

        // OnComplete 는 seq 에 설정한 애니메이션의 플레이가 완료되면
        // { } 안에 있는 코드가 수행된다는 의미입니다.
        // 여기서는 닫기 애니메이션이 완료된 후 객첼르 비활성화 합니다.
        seq.Play().OnComplete(() =>
        {
            gameObject.SetActive(false);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
