//Steven Szekely
//Enemy bounce around script



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemy_Speed;
    private float oldTime;
    private float currentTime;
    private Rigidbody2D rb2D;
    private Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        //Sets a new random direction for enemy to travel to.
        velocity = new Vector2 (Random.Range(-1f, 1f),  Random.Range(-1f, 1f));
        enemy_Speed = Random.Range(1f, 2f);
    }

    // Update is called once per frame, fixedupdate is used to coordinate with physics engine.
    void FixedUpdate()
    {
        Timer();
        Move();
    }

     public void Timer()
     {
         //increases time
         currentTime += Time.deltaTime;
         //checks if 1-4 seconds have passed
         if (oldTime <= (currentTime - Random.Range(1f, 4f)))
         {
            oldTime = currentTime;
            ChangeDirection();
         }
     }

    public void ChangeDirection()
    {
        //Switches enemy movement direction by updating with new random direction
        Debug.Log("Switch Triggered");
        velocity = new Vector2 (Random.Range(-1f, 1f),Random.Range(-1f, 1f));
    }

   public void Move()
   {
        //Applies locomotion to rigidbody using position, speed and deltaTime
        rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime * enemy_Speed);    
   }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ChangeDirection();
    }
}
