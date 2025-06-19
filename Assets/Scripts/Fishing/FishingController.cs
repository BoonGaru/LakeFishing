using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FishingController : MonoBehaviour
{
    [SerializeField] private Slider clickSlider;
    [SerializeField] private TMP_Text clickText;

    //private ���ô�
    //private �����

    private int clickAmount;
    private bool isFishing;


    public void ClickFishing() //�갡 �� ����� ���
    {
        clickAmount += 0; // ���˴� �Ŀ���ŭ �߰�

        clickSlider.value = clickAmount;
        clickText.text = $"{clickAmount} / �������";
    }

    private IEnumerator Fishing()
    {
        clickAmount = 0;
        isFishing = true;

        //�����̴� clickSlider.maxValue = �����.Force;
        clickSlider.value = clickAmount;
        clickText.text = $"{clickAmount} / �������";

        float time = 5;
        while (time > 0)
        {
            if (clickAmount > 0)
            {
                //����� ��� �ִ�
                //����� �κ��� �߰�
            }
            else
            {
                //����� ��ġ�� �ִ�
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
                //����� �����ؼ� ��� (�Ű������� ����� �ֱ�)

                StartCoroutine(Fishing());
            }
        }
    }
}
