using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float currentTime =0f;
    public float startingTime=10f;
    [SerializeField] TextMeshProUGUI txtCountdown;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        txtCountdown.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(2);
        }
    }
}
