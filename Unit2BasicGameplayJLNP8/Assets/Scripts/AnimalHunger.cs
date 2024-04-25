using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    //public Slider hungerSlider;
    public int hunger = 1;

    private int currentHunger = 0;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
       // hungerSlider.maxValue = hunger;
       // hungerSlider.value = 0;
       // hungerSlider.fillRect.gameObject.SetActive(false);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void FeedAnimal(int amount)
    {
        currentHunger += amount;
       // hungerSlider.fillRect.gameObject.SetActive(true);
       // hungerSlider.value = currentHunger;

        if(currentHunger >= hunger)
        {
            gameManager.AddScore(hunger);
            Destroy(gameObject, 0.1f);
        }
    }
}
