using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UICollection : MonoBehaviour
{
    private TextMeshProUGUI txtCollectible;

    private void Start()
    {
        txtCollectible = GetComponent<TextMeshProUGUI>();
    }

    public void txtUpdateCollectible(PlayerCollect playerCollect)
    {
        txtCollectible.text = playerCollect.ItemQuant.ToString();
    }
}
