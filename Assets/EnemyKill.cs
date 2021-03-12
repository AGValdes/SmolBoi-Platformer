using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{

  [SerializeField] private EdgeCollider2D topOfHead;
  [SerializeField] private BoxCollider2D restOfBody;
  [SerializeField] private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
   
    }


}
