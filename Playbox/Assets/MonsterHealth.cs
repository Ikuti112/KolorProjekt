using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHealth : MonoBehaviour {
    Attack refScript;
    public ParticleSystem collisionParticlePrefab;
    private ParticleSystem tempCollisionParticle;
    public int HP;
    public GameObject sword;
    public string Trigger;
    // Use this for initialization
    public float sec = 5f;
    private void Start()
    {
        refScript = sword.GetComponent<Attack>();
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(sec);
        gameObject.SetActive(false);
        Debug.Log("Dead");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword" && HP>0)
        {
            tempCollisionParticle = Instantiate(collisionParticlePrefab, transform.position, Quaternion.identity) as ParticleSystem;
            tempCollisionParticle.Play();
            HP = HP - 10;
            if (HP <= 0)
            {
                refScript.ChangeCount();
            }
        }
    }
    // Update is called once per frame
    void Update () {
        if (HP <= 0)
        {
            GetComponent<Animator>().SetTrigger(Trigger);
            StartCoroutine(Wait());
        }
	}
}
