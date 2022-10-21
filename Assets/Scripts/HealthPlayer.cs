using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField]
    float MAX_HEALTH = 20f;

    [SerializeField]
    int healthPlayer = 5;

    [SerializeField]
    Slider sliderHealth;

    [SerializeField]
    Button Curar;

    [SerializeField]
    Button Dañar;


    // Start is called before the first frame update
    void Start()
    {
        sliderHealth.maxValue = MAX_HEALTH;
        sliderHealth.value = MAX_HEALTH / 2;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void TaskOnClick_Dañar() 
    {
        sliderHealth.value += 5;
    }
    public 
        void TaskOnClick_Curar()
    {
        sliderHealth.value -= 5;
    }
}
