using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomSeedController : MonoBehaviour
{
    public string currentSeed;    //Current Loaded Seed
    public TextMeshProUGUI textMeshProUGUI;

    private void Update()
    {
        textMeshProUGUI.text = currentSeed; 
    }

    public string GetCurrentSeed() { return currentSeed; }

    private void Awake() =>  GenerateRandomSeed();

    //Generate Random seed for the system
    public void GenerateRandomSeed()
    {
        int tempSeed = (int)System.DateTime.Now.Ticks;
        currentSeed = tempSeed.ToString();

        Random.InitState(tempSeed);
    }

    //Select the Seed for the System
    public void SetRandomSeed(string seed = "")
    {
        currentSeed = seed;

        int tempSeed = 0;

        if (isNumeric(seed))
            tempSeed = System.Int32.Parse(seed);
        else
            tempSeed = seed.GetHashCode();

        Random.InitState(tempSeed);
    }
    public void SetRandomSeed(int seed)
    {
        currentSeed = seed.ToString();
        int tempSeed = seed;
        Random.InitState(tempSeed);
    }

    //Copy Seed to Clipboard
    public void CopySeedToClipboard() => GUIUtility.systemCopyBuffer = currentSeed;

    //Check if Seed is All numbers
    public static bool isNumeric(string s)
    {
        return int.TryParse(s, out int n);
    }
}
