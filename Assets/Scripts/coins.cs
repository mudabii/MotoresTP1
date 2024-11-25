using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour

    {
    public TMPro.TextMeshProUGUI Score;
    public int totalcoins;
    public int collectedcoins;
    public GameObject goal;

    void Start()
    {
        UpdateScore();
    }
    private void UpdateScore()
    {
        Score.text = collectedcoins + "/" + totalcoins;
    }


    void Update()
    {
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("colision con" + collision.gameObject.name);

        //if (collision.gameObject.CompareTag("Kill"))
        //{
        //    Debug.Log("killzone ");
        //    SceneManager.LoadScene(0);
        //}

        //if (collision.gameObject.CompareTag("Goal")) 
        //{ 
        //    SceneManager.LoadScene(1); 
        // }

        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            collectedcoins++;
            Score.text = totalcoins.ToString();
            UpdateScore();
        }
        if (collectedcoins == totalcoins) 
        {
            goal.SetActive(true);
        }

    }
}