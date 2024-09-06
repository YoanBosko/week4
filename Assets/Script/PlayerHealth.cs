using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 10;
    public int HP;
    public UnityEvent slidereffects;
    public Slider slide;
    // Start is called before the first frame update
    void Start()
    {
        HP = PlayerPrefs.GetInt("HP",maxHP);
        slide.maxValue = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        slide.value = HP;
    }
    public void TakeDamage(int damage)
    {
        HP -= damage;
        
        if(HP <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void DeadScene()
    {
        SceneManager.LoadScene("Dead");
    }
    public void SaveHealth()
    {
        PlayerPrefs.SetInt("HP", HP);
    }
}
