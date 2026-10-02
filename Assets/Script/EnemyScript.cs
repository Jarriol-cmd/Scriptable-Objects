using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyScript : MonoBehaviour
{

    public PlayerInfoSO information;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.equalsKey.wasPressedThisFrame)
        {
            information.health += 1;
        }

        if(Keyboard.current.minusKey.wasPressedThisFrame)
        {
            information.health -= 1;
        }


       
    }
}
