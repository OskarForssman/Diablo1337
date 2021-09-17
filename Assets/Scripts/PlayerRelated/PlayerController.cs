using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{


    
    private FlowerPickedUp setScore;
   private  bool eventTrigger;
   [SerializeField] GameObject npc;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] Camera cam;
    [SerializeField] GameObject bullet;
    float horizontal;
    float vertical;
    Insect insect;
    CalculateForMe calmc;
    TileBase[] tiles;

    
    public float runSpeed = 0.1f;
    void Start()
    {
        insect = new Insect(3, 3, 3);
        calmc = new CalculateForMe();
     setScore = new FlowerPickedUp();
        }

   
    void Update()
    {
  
        if (setScore.getFlower() >= 10)
        {
            GenerateNpc();
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Fire1"))
        {

               shoot();
    
            }

        if (Vector3.Distance(transform.position, npc.gameObject.transform.position) < 5f && Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Talk TO NPC");
        }
    }
    private void FixedUpdate()
    {
        rigid.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.gameObject.tag == "Collider")
        {
           
            Debug.Log("collision collidder");
        }
        if (collision.gameObject.tag == "Block")
        {
          
            Debug.Log("collision collidder");
        }
        if (collision.gameObject.tag == "Bullet")
        {
         
                Destoryplayer();
            
        }
        
        if (collision.gameObject.tag == "Enemy")
        {
           
           
                Destoryplayer();
            
        }

    }

    private void shoot()
    {
        
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 mousepos = cam.ScreenToWorldPoint(screenPosition);

        Vector2 mypos = transform.position;
        Vector2 directionVector = (mousepos - mypos).normalized;
        Debug.Log("1: "+ mousepos);
        Debug.Log("2: " + mypos);
        Debug.Log("3: " + (mousepos - mypos));

      FlyStupidBullet bulletz=  Instantiate(bullet, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), gameObject.transform.rotation)?.GetComponent<FlyStupidBullet>();
        bulletz.shoot(directionVector*15);
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.tag== "SlowPlayerDown")
        {
            runSpeed = 10f;
        }

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "SmallFlower")
        {


            setScore.setFlower(0.5f);
            Debug.Log("Ur Nectar Score: " + setScore.getFlower());

        }
        if (collider.gameObject.tag == "SlowPlayerDown")
        {
            runSpeed = 2f;

          

        }
        
            
        if (collider.gameObject.tag == "BigFlower")
        {
            setScore.setFlower(1f);
            Debug.Log("Ur Nectar Score: " + setScore.getFlower());
        }
        if (collider.gameObject.tag == "Hole")
        {
            Destoryplayer();

        }
        if (collider.gameObject.tag == "Stone")
        {
            Destoryplayer();
        }
        
    }





    public void GenerateNpc()
    {
        if (!eventTrigger)
        {
            eventTrigger = true;

            Instantiate(npc,new Vector2(0,0), npc.transform.rotation);

        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 430, 40, 25), setScore.getFlower().ToString());
    }
    void Destoryplayer()
    {
        GameObject[] gameObject = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < gameObject.Length; i++)
        {
            Destroy(gameObject[i]);
        }
    }
  
  


}
