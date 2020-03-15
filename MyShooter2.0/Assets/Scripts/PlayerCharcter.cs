using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCharcter : MonoBehaviour
{
    private int _health = 500;

    public Slider slider;

    public void Hurt(int damage)
    {
        _health -= damage;
        slider.value = _health;
        if (_health <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        Debug.Log("Health: " + _health);
    }

       
    
}
