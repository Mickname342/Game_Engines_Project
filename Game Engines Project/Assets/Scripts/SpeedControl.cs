using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedControl : MonoBehaviour
{
    public Text globalSpeed;
    public Text individualSpeed;


    public Slider slider;

    bool running = true;
    float previosTime = 1;

    int boidSelect = 0;

    public Boid[] ducks;
    public Boid whale;
    public Boid babyWhale;
    public Boid[] fish;
    public Boid anglerFish1;
    public Boid anglerFish2;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = ducks[0].maxSpeed;
        individualSpeed.text = ducks[0].maxSpeed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (!running)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = previosTime;
        }
    }

    public void ControlSpeed(float speed)
    {
        if (running)
        {
            Time.timeScale = speed;
            previosTime = speed;
            globalSpeed.text = previosTime.ToString();
        }
        
    }

    public void Stop()
    {
        running = !running;
        globalSpeed.text = previosTime.ToString();
    }

    public void SelectBoid(int boid)
    {
        boidSelect = boid;
        switch (boidSelect)
        {
            case 0:
                slider.value = ducks[0].maxSpeed;
                individualSpeed.text = ducks[0].maxSpeed.ToString();
                break;
            case 1:
                slider.value = whale.maxSpeed;
                individualSpeed.text = whale.maxSpeed.ToString();
                break;
            case 2:
                slider.value = babyWhale.maxSpeed;
                individualSpeed.text = babyWhale.maxSpeed.ToString();
                break;
            case 3:
                slider.value = fish[0].maxSpeed;
                individualSpeed.text = fish[0].maxSpeed.ToString();
                break;
            case 4:
                slider.value = anglerFish1.maxSpeed;
                individualSpeed.text = anglerFish1.maxSpeed.ToString();
                break;
            case 5:
                slider.value = anglerFish2.maxSpeed;
                individualSpeed.text = anglerFish2.maxSpeed.ToString();
                break;
        }
    }

    public void IndividualSpeed(float speed)
    {
        individualSpeed.text = speed.ToString();
        switch (boidSelect)
        {
            case 0:
                for(int i = 0; i < ducks.Length; i++)
                {
                    ducks[i].maxSpeed = speed;
                }
                break;
            case 1:
                whale.maxSpeed = speed;
                break;
            case 2:
                babyWhale.maxSpeed = speed;
                break;
            case 3:
                for(int i = 0;i < fish.Length; i++)
                {
                    fish[i].maxSpeed = speed;
                }
                break;
            case 4:
                anglerFish1.maxSpeed = speed;
                break;
            case 5:
                anglerFish2.maxSpeed = speed;
                break;
        }
    }


}
