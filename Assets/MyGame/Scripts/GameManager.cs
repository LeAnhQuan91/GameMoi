using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float fuel = 0;
    public float roundNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetFuel(float fuel)
    {
        this.fuel += fuel;
    }
    public void SetRound(int  roundNumber)
    {
        this.roundNumber += roundNumber;
    }
}
