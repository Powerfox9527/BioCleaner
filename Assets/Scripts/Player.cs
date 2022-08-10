using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, Damageable
{
    public bool isDead = false;
    public float HP = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetHit(float Damage)
    {
        HP -= Damage;
        if (HP < 0)
        {
            isDead = true;
        }
    }
}
