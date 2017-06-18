using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningCondition : MonoBehaviour {
    DeleteCoin refScript;
    Attack refScript2;
    public GameObject winningscreen;
    public GameObject coinUI;
    public GameObject monsterUI;
    public GameObject sword;

    private void Start()
    {
        refScript = GetComponent<DeleteCoin>();
        refScript2 = sword.GetComponent<Attack>();
    }
    // Update is called once per frame
    void Update () {
        if (refScript.coinCount == 5  && refScript2.monsterKilledCount == 6)
        {
                    Time.timeScale = 0.0F;
            Cursor.visible = true;
            winningscreen.SetActive(true);
            monsterUI.SetActive(false);
            coinUI.SetActive(false);
        }
	}
}
