using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    GameManager manager;

    private void Start()
    {
        manager = FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball")) // ✅ cek bola
        {
            Debug.Log("Ball masuk zone");

            if (tag == "PlayerZone")
            {
                manager.OpponentWin(); // ✅ panggil function
            }
            else if (tag == "OpponentZone")
            {
                manager.PlayerWin(); // ✅ panggil function
            }
        }
    }

//     void OnTriggerEnter2D(Collider2D other)
// {
//     Debug.Log("Trigger kena: " + other.name);

//     manager.PlayerWin(); // paksa tambah skor
// }
   
    // GameManager manager;
    
    // private void Start()
    // {
    //     manager = FindFirstObjectByType<GameManager>();
    // }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (tag == "PlayerZone")
    //     {
    //         manager.opponentWin.Invoke();
    //     }
    //     else if (tag == "OpponentZone")
    //     {
    //         manager.playerWin.Invoke();
    //     }
    // }
}
