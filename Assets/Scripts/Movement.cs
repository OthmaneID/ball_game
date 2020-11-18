using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    float horizontal;
    [SerializeField]
    float Speed = 6f;
    Vector3 moveDirection = Vector3.zero;
    Rigidbody rb;
    int score;
    int bestScore;
    CharacterController controller;
     [SerializeField]
	 Text txtscore;
	 [SerializeField]
	 Text txtbestScore; 
	 
    void Start()
    {
	   // PlayerPrefs.DeleteAll();
        rb = GetComponent<Rigidbody>();
        score = 0;
		bestScore = 0;
        bestScore = PlayerPrefs.GetInt("bestScore");
		txtbestScore.text = ""+ bestScore;
		Cursor.visible = false;
	
    }


    void Update()
    {
		
		
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
		
		
        //  rb.velocity =  moveDirection * Time.deltaTime * Speed;

        //else
        //{
        //    moveDirection.y -= Jump * Time.deltaTime;
        //}
              moveDirection = new Vector3(horizontal,0,1);

        //  transform.Translate(moveDirection);
        rb.velocity = moveDirection * Time.deltaTime * Speed;
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.collider.CompareTag("Enemy"))
        {
          Cursor.visible = true;
            SceneManager.LoadScene("gameOver");
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Zone"))
        {
            score++;
			txtscore.text = "Score : "+score;
            Speed += 50;
          if(score > bestScore){
			 
			  PlayerPrefs.SetInt("bestScore",score);
		  }
		  
        }
    }
   
}
