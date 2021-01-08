using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float positionY;
    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHearts;
    public Animator camAnim;
    public GameObject mainCamera;
    public GameObject effect;

    AudioSource audioSource;
    public AudioClip hitSound;
    public AudioClip moveSound;
    public AudioClip coinSound;

    private Vector2 targetPos = new Vector2(-1.5f, 0f);
    private Vector2 startTouchPosition, endTouchPosition;

    public void Awake()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        camAnim = mainCamera.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) // Управление свайпами
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if ((endTouchPosition.y > startTouchPosition.y) && transform.position.y < maxHeight)
            {
                audioSource.PlayOneShot(moveSound);
                camAnim.SetTrigger("shake");
                Instantiate(effect, transform.position, Quaternion.identity);
                targetPos = new Vector2(-1.5f, transform.position.y + positionY);
            }

            if ((endTouchPosition.y < startTouchPosition.y) && transform.position.y > minHeight)
            {
                audioSource.PlayOneShot(moveSound);
                camAnim.SetTrigger("shake");
                Instantiate(effect, transform.position, Quaternion.identity);
                targetPos = new Vector2(-1.5f, transform.position.y - positionY);
            }
        }
        // Управление кнопками, отключить при заливе
        //if ((Input.GetKeyDown(KeyCode.UpArrow)) && transform.position.y < maxHeight)
        //{
        //    audioSource.PlayOneShot(moveSound);
        //    camAnim.SetTrigger("shake");
        //    Instantiate(effect, transform.position, Quaternion.identity);
        //    targetPos = new Vector2(-1.5f, transform.position.y + positionY);
        //}

        //if ((Input.GetKeyDown(KeyCode.DownArrow)) && transform.position.y > minHeight)
        //{
        //    audioSource.PlayOneShot(moveSound);
        //    camAnim.SetTrigger("shake");
        //    Instantiate(effect, transform.position, Quaternion.identity);
        //    targetPos = new Vector2(-1.5f, transform.position.y - positionY);
        //}

        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHearts;
            }
            else
            {
                hearts[i].sprite = emptyHearts;
            }


            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            audioSource.PlayOneShot(hitSound);
            camAnim.SetTrigger("shake2");
        }
        else if (other.CompareTag("Ground"))
        {
            camAnim.SetTrigger("shake2");
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            targetPos = new Vector2(-1.5f, 0f);
        }
        else if (other.CompareTag("CoinGold"))
        {
            GameMoney.moneyGold += 1;
            audioSource.PlayOneShot(coinSound);
        }
        else if (other.CompareTag("CoinTurtle"))
        {
            GameMoney.moneyTurtle += 1;
            audioSource.PlayOneShot(coinSound);
        }
        else if (other.CompareTag("CoinCandy"))
        {
            GameMoney.moneyCandy += 1;
            audioSource.PlayOneShot(coinSound);
        }
        else if (other.CompareTag("CoinLog"))
        {
            GameMoney.moneyLog += 1;
            audioSource.PlayOneShot(coinSound);
        }
        else if (other.CompareTag("CoinFeather"))
        {
            GameMoney.moneyFeather += 1;
            audioSource.PlayOneShot(coinSound);
        }
        else if (other.CompareTag("CoinFish"))
        {
            GameMoney.moneyFish += 1;
            audioSource.PlayOneShot(coinSound);
        }
        else if (other.CompareTag("CoinDice"))
        {
            GameMoney.moneyDice += 1;
            audioSource.PlayOneShot(coinSound);
        }
        else if (other.CompareTag("CoinHorn"))
        {
            GameMoney.moneyHorn += 1;
            audioSource.PlayOneShot(coinSound);
        }
        else if (other.CompareTag("CoinPowder"))
        {
            GameMoney.moneyPowder += 1;
            audioSource.PlayOneShot(coinSound);
        }
        else if (other.CompareTag("CoinHell"))
        {
            GameMoney.moneyHell += 1;
            audioSource.PlayOneShot(coinSound);
        }
    }
}