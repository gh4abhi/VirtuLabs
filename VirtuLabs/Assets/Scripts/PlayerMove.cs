using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yinc;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 5;
    public GameObject effect;
    public Text healthDisplay;
    public Text Score;
    public Text finalScore;
    public int indexLoad;
    int score = 0;

    private void Awake()
    {
        finalScore.enabled = false;
    }

    void Start()
    {
        increase();
    }
    private float timeElapsed = 0;
    void Update()
    {
        if (health <= 0)
        {
            Destroy(healthDisplay);
            Destroy(Score);
            if (health == 0)
            {
                finalScore.text += score.ToString();
                finalScore.enabled = true;
                health = -1;
            }
            timeElapsed += Time.deltaTime;
            if(timeElapsed>5f)
                changeScreen();
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        else
        {
            healthDisplay.text = health.ToString();
            Score.text = score.ToString();
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        }
    }

    public void changeScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void increase()
    {
        score += 1;
        if(health>0)
            Invoke("increase",1f);
    }

    public void moveUp()
    {
        if (transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yinc);
            Instantiate(effect, transform.position, Quaternion.identity);
        }
    }

    public void moveDown()
    {
        if (transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yinc);
            Instantiate(effect, transform.position, Quaternion.identity);
        }
    }
    }
