using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteCoin : MonoBehaviour {
    public int coinCount;
    private Text txt;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            coinCount++;
        }
    }
    private void Update()
    {
        txt=GameObject.Find("CoinText").GetComponent<Text>();
        txt.text = coinCount + "/5";
    }
}
