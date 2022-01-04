
using UnityEngine;
using UnityEngine.UI;

public class CarHealth : MonoBehaviour
{
    public float health;
    public Slider slider;
    public Text text;
    public PlayerMovement movement;

    private bool dead;
    void Start()
    {
        
    }

    void Update()
    {
        slider.value = health;
        text.text = "Car Health: " + health;
        if (dead == true)
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obs")
        {
            health = health - 10f;

            if (health < 1)
            {
                dead = true;
                movement.enabled = false;
            }
        }
    }
}
