using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region FIELDS
    [Header("Battle")]
    public float HP = 100.0f;
    public float Attack = 10.0f;
    public float Defense = 5.0f;
    [Header("Movement")]
    public float Speed = 10.0f;
    public float Acceleration = 2.0f;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
