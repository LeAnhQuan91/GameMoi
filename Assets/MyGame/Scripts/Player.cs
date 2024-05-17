using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth = 100;
    public float fuelValue = 20;
    public float damageValue = 60;
    public int roundValue = 1;
    public GameObject explusionPrefabs;
    //prvate 
    private float currentHealth = 0;
    private bool isGate = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fuel")
        {
            Destroy(other.gameObject);
            GameManager.Instance.SetFuel(fuelValue);
            InstantiateGame(other);
        }
        else if (other.tag == "Damage")
        {
            DamageHealth(damageValue);
            InstantiateGame(other);
            Destroy(other.gameObject);
            //Debug.Log("va cham hop sat");
        }
        else if (other.tag == "finishGame")
        {
            if (isGate == true)
            {
                GameManager.Instance.SetRound(roundValue);
                isGate = false;
            }
        }
        else if (other.name == "Gate")
        {
            isGate = true;
        }

    }
    void InstantiateGame(Collider other)
    {
        Instantiate(explusionPrefabs, other.transform.position, Quaternion.identity);
    }
    private void DamageHealth(float health)
    {
        if (currentHealth > 0)
        {
            currentHealth -= health;
        }
        else
        {
            currentHealth = 0;
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, -60f, 60f), 0, Mathf.Clamp(transform.position.z, -60f, 60f));
    }
}
