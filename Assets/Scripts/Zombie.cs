using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour, Damageable
{
    public GameObject loot;
    public Player player;
    public float HP = 100.0f;
    public float Speed = 2.0f;
    public CharacterController controller;
    public Animator animator;
    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip hitClip;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && !player.isDead)
        {
            Vector3 dir = player.transform.position - transform.position;
            dir.y = 0;
            dir.Normalize();
            controller.Move(dir * Speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(dir);
        }
    }

    public void GetHit(float Damage) 
    {
        HP -= Damage; 
        if(audioSource && hitClip)
        {
            audioSource.PlayOneShot(hitClip);
        }
        if(HP < 0)
        {
            if(loot)
                Instantiate(loot);
            Destroy(this.gameObject);
        }
    }
}
