using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSample : MonoBehaviour

{
	public Image antennes;
	public Image bouche;
	public Image bras;
	public Image corps;
	public Image jambes;
	public Image morves;
	public Image nez;
	public Image yeux;

    public Sprite[] antennesL;
    public Sprite[] boucheL;
    public Sprite[] brasL;
    public Sprite[] corpsL;
    public Sprite[] jambesL;
    public Sprite[] morvesL;
    public Sprite[] nezL;
    public Sprite[] yeuxL;


	void Start ()
	{
		RandomizeCharacter();
	}
	
	public void RandomizeCharacter(){
        antennes.sprite = antennesL[Random.Range(0, antennesL.Length)];
        bouche.sprite = boucheL[Random.Range(0, boucheL.Length)];
        bras.sprite = brasL[Random.Range(0, brasL.Length)];
        corps.sprite = corpsL[Random.Range(0, corpsL.Length)];
        jambes.sprite = jambesL[Random.Range(0, jambesL.Length)];
        morves.sprite = morvesL[Random.Range(0, morvesL.Length)];
        nez.sprite = nezL[Random.Range(0, nezL.Length)];
        yeux.sprite = yeuxL[Random.Range(0, yeuxL.Length)];
	}

}
