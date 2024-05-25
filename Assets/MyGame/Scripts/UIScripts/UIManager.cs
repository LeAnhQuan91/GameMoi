using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textCoin;
    [SerializeField] private TextMeshProUGUI textRound;
    [SerializeField] private TextMeshProUGUI textFuel;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(UpdateValue());
        textCoin.text = DataManager.DataCoin.ToString();
        //textRound.text = "0";
        textFuel.text = DataManager.DataFuel.ToString();
        GameManager.Instance.CoinEvent.AddListener(UpdateCoin);
        //GameManager.Instance.RoundEvent.AddListener(UpdateRound);
        GameManager.Instance.FuelEvent.AddListener(UpdateFuel);
       
    }
    // Update is called once per frame
    void Update()
    {
        //UpdateCoin();
        //UpdateRound();
        //UpdateFuel();
    }
    void UpdateCoin(int coin)
    {
        if (textCoin != null)
        {
            //int coin = GameManager.Instance.GetCoin();
            textCoin.text = coin.ToString();
        }
    }
    void UpdateRound(int round)
    {
        if (textRound != null)
        {
            //int round = GameManager.Instance.GetRound();
            textRound.text = round.ToString();
        }
    }
    void UpdateFuel (float fuel) 
    {
        if (textFuel != null)
        {
           textFuel.text = fuel.ToString();
        }
       
    }

    #region
    //IEnumerator UpdateValue()
    //{
    //    while(true)
    //    {
    //        yield return new WaitForSeconds(0.5f);
    //        UpdateCoin();
    //        UpdateRound();
    //    }
    //}
    #endregion
}
