using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityChanController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rigid2D;
    GameObject sound;
    private float groundLevel = -3.0f;
    private float dump = 0.8f;
    private float jumpVelocity = 20;
    private float deadLine = -9;


    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.sound = GameObject.Find("SoundManager");
    }

    // Update is called once per frame
    void Update()
    {
        this.animator.SetFloat("Horizontal", 1);
        bool isGround = (transform.position.y > this.groundLevel) ? false : true;
        animator.SetBool("isGround", isGround);
        GetComponent<AudioSource>().volume = (isGround) ? 1 : 0;

        if (Input.GetMouseButtonDown(0) && isGround)
        {
            this.rigid2D.velocity=new Vector2(0, jumpVelocity);
            this.sound.GetComponent<SoundManager>().SE_ya();
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (this.rigid2D.velocity.y > 0)
            {
                this.rigid2D.velocity *= this.dump;
            }
        }

        if (transform.position.x < this.deadLine)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            this.sound.GetComponent<SoundManager>().SE_achaa(); 
            Destroy(gameObject);
        }
    }
}
