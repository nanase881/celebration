using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CountDown : MonoBehaviour
{
    [SerializeField] float countDownTime = 30f;
    [SerializeField] TextMeshProUGUI countDownText;
    [SerializeField] TextMeshProUGUI finishText;
    [SerializeField] GameObject player;
    [SerializeField] GameObject playSE;
    [SerializeField] GameObject BGM;
    bool playWhistle = false;
    // Update is called once per frame
    void Update()
    {
        countDownTime -= Time.deltaTime;
        countDownText.text = countDownTime.ToString("f1");

        if (countDownTime > 0 && countDownTime < 10)
        {
            Debug.Log("Ten seconds left!");
        }
        if(countDownTime <= 0)
        {
            if (!playWhistle)
            {
                Instantiate(playSE, transform.position, transform.rotation);
                playWhistle = true;
            }
            //Debug.Log("Finish!");
            BGM.SetActive(false);
            countDownText = null;
            finishText.text = "Finish!";
            player.SetActive(false);
            Invoke("ChangeScene", 3f);
        }

    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Result");
    }
}
