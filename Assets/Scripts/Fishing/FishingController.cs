using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
[System.Serializable]
public class GradeProbability
{
    public Grade Grade;
    public float Probability;
}

[System.Serializable]
public class Grades
{
    public List<GradeProbability> grades;
}
[System.Serializable]
public class FishGroups
{
   public  List<FishData> fishs;
}

public class FishingController : MonoBehaviour
{
    [SerializeField] private FishingRobData fishingRod;
    [SerializeField] private FishGroups[] fishGroups;
    [SerializeField] private Grades[] gradeProbability;
    [SerializeField] private Grades probability;

    [SerializeField] private Slider clickSlider;
    [SerializeField] private TMP_Text clickText;

    [SerializeField] private GameObject successWindow;
    [SerializeField] private TMP_Text successText;
    [SerializeField] private ParticleSystem paticle;

    [SerializeField] private GameObject[] fishPrefabs;

    private PlayerInventory playerInventory;
    private FishData fish;

    private Animator animator;

    private int clickAmount;
    private bool isFishing = false;

    void Start()
    {
        animator = GetComponent<Animator>();   
    }
    public void StartFIshing()
    {
        StartCoroutine(WaitFishing());
    }
    public void ClickFishing()
    {
        if (isFishing)
        {
            clickAmount++; 

            clickSlider.value = clickAmount;
            clickText.text = $"{clickAmount} / {fish.Strength}";
            paticle.Play();

        }
       
    }

    private FishData SelectFish()
    {
        Grade grade = Grade.S;
        float gradeWeight = 0f;
        
        for(int i = 0; i < gradeProbability[fishingRod.FishingRobID - 1].grades.Count; i++)
        {
            gradeWeight += gradeProbability[fishingRod.FishingRobID - 1].grades[i].Probability + probability.grades[i].Probability;
        }

        float randomValue = UnityEngine.Random.value * gradeWeight;

        for (int i = 0; i < gradeProbability[fishingRod.FishingRobID - 1].grades.Count; i++)
        {
            randomValue -= (gradeProbability[fishingRod.FishingRobID - 1].grades[i].Probability) + probability.grades[i].Probability;

            if (randomValue <= 0)
            {
                grade = gradeProbability[fishingRod.FishingRobID - 1].grades[i].Grade;
                break;
            }
            else grade = gradeProbability[fishingRod.FishingRobID - 1].grades[gradeProbability[fishingRod.FishingRobID - 1].grades.Count - 1].Grade;
        }

        int randomFish = UnityEngine.Random.Range(0, fishGroups[(int)grade].fishs.Count);

        return fishGroups[(int)grade].fishs[randomFish];

    }

    private IEnumerator Fishing()
    {
        clickAmount = 0;
        isFishing = true;
        clickSlider.gameObject.SetActive(true);

        clickSlider.maxValue = fish.Strength;
        clickSlider.value = clickAmount;
        clickText.text = $"{clickAmount} / {fish.Strength}";

        float time = 5;
        while (time > 0)
        {
            if (clickAmount > fish.Strength)
            {
                animator.SetTrigger("fishing");
                fishPrefabs[fish.PrefabIndex].SetActive(true);

                yield return new WaitForSeconds(0.5f);

                //if (fish.Amount <= 0) playerInventory.OwnedFIsh.Add(fish);
                fish.Amount++;

                successWindow.SetActive(true);
                successText.text = $"물고기를 잡았다! : \n{fish.Name}";

                yield return new WaitForSeconds(2f);

                animator.SetTrigger("fishing");
                fishPrefabs[fish.PrefabIndex].SetActive(false);
                successWindow.SetActive(false);

                break;
            }

            time -= Time.deltaTime;
            yield return null;

        }

        isFishing = false;
        clickSlider.gameObject.SetActive(false);
    }

    private IEnumerator WaitFishing()
    {
        clickSlider.gameObject.SetActive(false);
        while (true)
        {
            yield return new WaitForSeconds(20f);

            if (!isFishing)
            {
                Debug.Log("잡힘");
                fish = SelectFish();
                StartCoroutine(Fishing());
            }
        }
    }
}
