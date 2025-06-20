using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    [SerializeField] private GameObject startText;
    [SerializeField] private FishingController fishingController;

    private bool isWait = true;

    void Start()
    {
        StartCoroutine(StartGame());
    }

    private IEnumerator StartGame()
    {
        while (isWait) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                startText.SetActive(false);

                float time = 1;
                while(time > 0)
                {
                    Camera.main.transform.position += new Vector3(0, -0.28f, 0);

                    time -= Time.deltaTime;
                    yield return new WaitForFixedUpdate();
                }
                isWait = false;
                fishingController.StartFIshing();
            }

            yield return new WaitForFixedUpdate();
        }
    }
}
