using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {
        
    }

    private void Update()
    {
        transform.position += transform.right.normalized / speed;
    }
}
