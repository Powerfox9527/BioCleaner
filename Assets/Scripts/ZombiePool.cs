using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePool : MonoBehaviour
{
    public Zombie zombie;
    public Player player;
    public float generateTime = 3.0f;
    public float generateRadius = 30.0f;

    private void Awake()
    {
        StartCoroutine(generateZombie());
    }

    private IEnumerator generateZombie()
    {
        Zombie obj = Instantiate(zombie, transform);
        Vector3 dir = Vector3.right * generateRadius;
        dir = Quaternion.Euler(0, Random.Range(0, 360), 0) * dir;
        obj.transform.position = player.gameObject.transform.position + dir;
        zombie.player = player;
        yield return new WaitForSeconds(generateTime);
        StartCoroutine(generateZombie());
    }
}
