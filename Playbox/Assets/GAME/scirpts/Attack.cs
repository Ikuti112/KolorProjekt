using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Attack : MonoBehaviour {
    public int monsterKilledCount=0;
    private Text txt;
    public KeyCode AttackKey;
    public string Trigger;
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(AttackKey))
        {
            GetComponent<Animator>().SetTrigger(Trigger);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            Debug.Log("Animation called");
        }
        txt = GameObject.Find("MonsterText").GetComponent<Text>();
        txt.text = monsterKilledCount + "/6";
    }
    public int ChangeCount()
    {
        monsterKilledCount++;
        return monsterKilledCount;
    }
}
