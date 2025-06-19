using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FishingController : MonoBehaviour
{
    [SerializeField] private Slider clickSlider;
    [SerializeField] private TMP_Text clickText;

    //private 낚시대
    //private 물고기

    private int clickAmount;
    private bool isFishing;


    public void ClickFishing() //얘가 그 물고기 잡기
    {
        clickAmount += 0; // 낚싯대 파워만큼 추가

        clickSlider.value = clickAmount;
        clickText.text = $"{clickAmount} / 물고기힘";
    }

    private IEnumerator Fishing()
    {
        clickAmount = 0;
        isFishing = true;

        //슬라이더 clickSlider.maxValue = 물고기.Force;
        clickSlider.value = clickAmount;
        clickText.text = $"{clickAmount} / 물고기힘";

        float time = 5;
        while (time > 0)
        {
            if (clickAmount > 0)
            {
                //물고기 잡는 애니
                //물고기 인벤에 추가
            }
            else
            {
                //물고기 놓치는 애니
            }

            time -= Time.deltaTime;
            yield return new WaitForFixedUpdate();

        }
    }

    private IEnumerator WaitFishing()
    {
        while (true)
        {
            yield return new WaitForSeconds(50f);

            if (!isFishing)
            {
                //물고기 셀렉해서 잡기 (매개변수로 물고기 넣기)

                StartCoroutine(Fishing());
            }
        }
    }
}
