using System;
using TMPro;
using Unity.VectorGraphics;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerScript2 : MonoBehaviour
{
    public PlayerInfoSO information;
    public TextMeshProUGUI textBox;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            information.score += 1;
        }

        if (Keyboard.current.oKey.wasPressedThisFrame)
        {
            information.score -= 1;
        }

        textBox.text = "Current Player: " + information.playerName + "\nCurrent Health: " + information.health + "\nCurrent Live Count: " + information.lives + "\nCurrent Score: " + information.score;

    }
}
