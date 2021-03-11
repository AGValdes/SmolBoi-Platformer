using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStar : MonoBehaviour
{

  [SerializeField] private bool WasCollected;
  [SerializeField] private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame

	private void OnTriggerEnter2D(Collider2D collision)
	{
       Destroy(gameObject);
	}
}
