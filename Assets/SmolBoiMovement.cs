using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmolBoiMovement : MonoBehaviour
{
  private Rigidbody2D rigidbody;
  public Vector2 speed = new Vector2(10, 10);

  private Vector2 movement = new Vector2(1, 1);

  // Use this for initialization
  void Start()
  {
    rigidbody = GetComponent<Rigidbody2D>();
    rigidbody.gravityScale = 20;
  }

  // Update is called once per frame
  void Update()
  {
    float inputX = Input.GetAxis("Horizontal");
    float inputY = Input.GetAxis("Vertical");

    movement = new Vector2(
        speed.x * inputX,
        speed.y * 0);

    if (Input.GetKeyDown("space"))
    {
      transform.Translate(Vector3.up * 110 * Time.deltaTime, Space.World);
    }

  }
  void FixedUpdate()
  {
    // 5 - Move the game object
    rigidbody.velocity = movement;
    //rigidbody2D.AddForce(movement);

  }

}
