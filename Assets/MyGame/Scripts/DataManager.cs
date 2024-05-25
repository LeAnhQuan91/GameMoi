using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // luu data coin vao de truyen canh van coin da an man truoc
    public static int DataCoin
    {
        get => PlayerPrefs.GetInt(DataContainer.CoinId, 0);
        set => PlayerPrefs.SetInt(DataContainer.CoinId, value);
    }
    public static float DataFuel
    {
        get => PlayerPrefs.GetFloat(DataContainer.FuelId, 0f);
        set => PlayerPrefs.GetFloat(DataContainer.FuelId, value);
    }

}
