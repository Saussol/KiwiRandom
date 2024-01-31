using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class RandomisationPerso : MonoBehaviour
{
    public Image antennesD;
    public Image antennesG;
    public Image bouche;
    public Image brasD;
    public Image brasG;
    public Image corps;
    public Image jambesD;
    public Image jambesG;
    public Image morves;
    public Image nez;
    public Image yeuxD;
    public Image yeuxG;
    public Image SoucilD;
    public Image SoucilG;

    public Sprite[] antennesDL;
    public Sprite[] antennesGL;
    public Sprite[] boucheL;
    public Sprite[] brasDL;
    public Sprite[] brasGL;
    public Sprite[] corpsL;
    public Sprite[] jambesDL;
    public Sprite[] jambesGL;
    public Sprite[] morvesL;
    public Sprite[] nezL;
    public Sprite[] yeuxDL;
    public Sprite[] yeuxGL;
    public Sprite[] SoucilDL;
    public Sprite[] SoucilGL;


    void Start()
    {
        RandomizeCharacter();
    }

    public void RandomizeCharacter()
    {
        antennesD.sprite = antennesDL[Random.Range(0, antennesDL.Length)];
        antennesG.sprite = antennesGL[Random.Range(0, antennesGL.Length)];
        bouche.sprite = boucheL[Random.Range(0, boucheL.Length)];
        brasD.sprite = brasDL[Random.Range(0, brasDL.Length)];
        brasG.sprite = brasGL[Random.Range(0, brasGL.Length)];
        corps.sprite = corpsL[Random.Range(0, corpsL.Length)];
        jambesD.sprite = jambesDL[Random.Range(0, jambesDL.Length)];
        jambesG.sprite = jambesGL[Random.Range(0, jambesGL.Length)];
        morves.sprite = morvesL[Random.Range(0, morvesL.Length)];
        nez.sprite = nezL[Random.Range(0, nezL.Length)];
        yeuxD.sprite = yeuxDL[Random.Range(0, yeuxDL.Length)];
        yeuxG.sprite = yeuxGL[Random.Range(0, yeuxGL.Length)];
        SoucilD.sprite = SoucilDL[Random.Range(0, SoucilDL.Length)];
        SoucilG.sprite = SoucilGL[Random.Range(0, SoucilGL.Length)];
    }
}
