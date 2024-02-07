using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomSeedController : MonoBehaviour
{
    public int currentSeed;    //Current Loaded Seed
    public TextMeshProUGUI textMeshProUGUI;
    public TraitGeneration traitGeneration;

    
    private void Awake() =>  GenerateRandomSeed();

    //Generate Random seed for the system
    public void GenerateRandomSeed()
    {
        int tempSeed = (int)System.DateTime.Now.Ticks;
        currentSeed = tempSeed;

        Random.InitState(tempSeed);

        traitGeneration.GestionUi(currentSeed);
        traitGeneration.SplitSeedDigits(currentSeed.ToString());
        textMeshProUGUI.text = currentSeed.ToString();
    }

}
