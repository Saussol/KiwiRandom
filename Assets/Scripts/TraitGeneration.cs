using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TraitGeneration : MonoBehaviour
{
    public bool isMen; //Paire true impaire false
    public int age; // 

    private string[] nameGirl = new string[] { "Lea", "Marine", "Ines", "Fanny", "juliette", "Mathilda", "Lynoa", "Lena", "Celia", "Berenice" };
    private string[] nameBoy = new string[] { "Davide", "Nicolas", "Romain", "Julien", "Damien", "Gabin", "Adrien", "Jean", "Jules", "Arthur" };

    private string[] corpulence = new string[] { "Sac d'os","Tres Tres maigre", "Tres maigre", "Maigre", "Standar", "Musclé", "Gros", "Tres gros", "Tres tres gros", "Obesiter Legendaire" };
    private string[] taille = new string[] { "Jouet 10cm","Gnome 50cm", "Nain 1m", "De petit taille 1m50", "Standar 1m75", "Grand 1m90", "Tres Grand 2m", "Geant 2m20", "Titan 3m", "immeuble 6m"};

    private string[] trait01 = new string[] { "Adroit", "Affectueux", "Aimable", "Agressif ", "Amusant", "Arrogant", "Audacieux", "Attachant", "Attendrissant", "Asocial" };
    private string[] trait02 = new string[] { "Beau parleur", "Bête", "Bienveillant", "Brave ", "Brutal", "Belliqueux", "Bout-en-train" , "Brillant" , "Bavard " , "Brillant" };
    private string[] trait03 = new string[] { "Chanceux", "Chaleureux", "Cinglé", "Comique ", "Consciencieux", "Courageux", "Cupide", "Créatif", "Courtois", "Cynique" };

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI ageText;
    public TextMeshProUGUI sexText;
    public TextMeshProUGUI corpuText;
    public TextMeshProUGUI tailleText;
    public TextMeshProUGUI trait01Text;
    public TextMeshProUGUI trait02Text;
    public TextMeshProUGUI trait03Text;

    public TMP_InputField inputField;
    public RandomSeedController randomSeed;
    public RandomisationPerso randomisationPerso;

    public List<int> seedList = new List<int>();

    public void GestionUi(int seed)// with all seed
    {
        if (seed % 2 == 0)
        {
            isMen = true; sexText.text = "Sex : Boy";
        }
        else
        {
            isMen = false; sexText.text = "Sex : Girl";
        }
    }

    public void GetInputField()
    {
        SplitSeedDigits(inputField.text);
        randomSeed.textMeshProUGUI.text = inputField.text;
    }

    public void SplitSeedDigits(string seed)// Split seed 
    {
        seedList.Clear();

        foreach (char digitChar in seed)
        {
            if (int.TryParse(digitChar.ToString(), out int digit))
            {
                // Faites quelque chose avec chaque chiffre (digit)
                Debug.Log("Chiffre : " + digit);
                seedList.Add(digit);
            }
            else
            {
                Debug.LogError("Impossible de convertir le caractère en chiffre : " + digitChar);
            }
        }

        seedList.Reverse();

        

        PlayerSeed();
        randomisationPerso.RandomizeCharacter();
    }


    void PlayerSeed()
    {
        if (isMen)
        {
            nameText.text = "Name : " + nameBoy[seedList[0]];

        }
        else
        {
            nameText.text = "Name : " + nameGirl[seedList[0]];

        }

        switch (seedList.Count)
        {
            case 0:
                Debug.Log("Seed egale a null");
                
                break;
            case 1:
                Debug.Log("Seed count =  1");

                if (seedList[0] != 0 && seedList[0] != 0)
                {
                    ageText.text = "Age : " + seedList[0] * seedList[0];
                }
                else
                {
                    ageText.text = "Age : " + seedList[0] + seedList[0];
                }
                
                corpuText.text = "Corpulence : " + corpulence[seedList[0]];
                tailleText.text = "Taille : " + taille[seedList[0]];
                trait01Text.text = "Trait 01 : " + trait01[seedList[0]];
                trait02Text.text = "Trait 02 : " + trait02[seedList[0]];
                trait03Text.text = "Trait 03 : " + trait03[seedList[0]];
                break;
            case 2:
                Debug.Log("Seed count =  2");

                if (seedList[0] != 0 && seedList[1] != 0)
                {
                    ageText.text = "Age : " + seedList[0] * seedList[1];
                } 
                else
                {
                    ageText.text = "Age : " + seedList[0] + seedList[1];
                }

                corpuText.text = "Corpulence : " + corpulence[seedList[0]];
                tailleText.text = "Taille : " + taille[seedList[1]];
                trait01Text.text = "Trait 01 : " + trait01[seedList[0]];
                trait02Text.text = "Trait 02 : " + trait02[seedList[1]];
                trait03Text.text = "Trait 03 : " + trait03[seedList[0]];
                break;
            case 3:
                Debug.Log("Seed count =  3");

                if (seedList[0] != 0 && seedList[1] != 0)
                {
                    ageText.text = "Age : " + seedList[0] * seedList[1];
                }
                else
                {
                    ageText.text = "Age : " + seedList[0] + seedList[1];
                }

                corpuText.text = "Corpulence : " + corpulence[seedList[2]];
                tailleText.text = "Taille : " + taille[seedList[0]];
                trait01Text.text = "Trait 01 : " + trait01[seedList[1]];
                trait02Text.text = "Trait 02 : " + trait02[seedList[2]];
                trait03Text.text = "Trait 03 : " + trait03[seedList[0]];
                break;
            case 4:
                Debug.Log("Seed count =  4");

                if (seedList[0] != 0 && seedList[1] != 0)
                {
                    ageText.text = "Age : " + seedList[0] * seedList[1];
                }
                else
                {
                    ageText.text = "Age : " + seedList[0] + seedList[1];
                }

                corpuText.text = "Corpulence : " + corpulence[seedList[2]];
                tailleText.text = "Taille : " + taille[seedList[3]];
                trait01Text.text = "Trait 01 : " + trait01[seedList[0]];
                trait02Text.text = "Trait 02 : " + trait02[seedList[1]];
                trait03Text.text = "Trait 03 : " + trait03[seedList[2]];
                break;
            case 5:
                Debug.Log("Seed count =  5");

                if (seedList[0] != 0 && seedList[1] != 0)
                {
                    ageText.text = "Age : " + seedList[0] * seedList[1];
                }
                else
                {
                    ageText.text = "Age : " + seedList[0] + seedList[1];
                }

                corpuText.text = "Corpulence : " + corpulence[seedList[2]];
                tailleText.text = "Taille : " + taille[seedList[3]];
                trait01Text.text = "Trait 01 : " + trait01[seedList[4]];
                trait02Text.text = "Trait 02 : " + trait02[seedList[0]];
                trait03Text.text = "Trait 03 : " + trait03[seedList[1]];
                break;
            case 6:
                Debug.Log("Seed count =  6");

                if (seedList[0] != 0 && seedList[1] != 0)
                {
                    ageText.text = "Age : " + seedList[0] * seedList[1];
                }
                else
                {
                    ageText.text = "Age : " + seedList[0] + seedList[1];
                }

                corpuText.text = "Corpulence : " + corpulence[seedList[2]];
                tailleText.text = "Taille : " + taille[seedList[3]];
                trait01Text.text = "Trait 01 : " + trait01[seedList[4]];
                trait02Text.text = "Trait 02 : " + trait02[seedList[5]];
                trait03Text.text = "Trait 03 : " + trait03[seedList[0]];
                break;
            case 7:
                Debug.Log("Seed count =  7");

                if (seedList[0] != 0 && seedList[1] != 0)
                {
                    ageText.text = "Age : " + seedList[0] * seedList[1];
                }
                else
                {
                    ageText.text = "Age : " + seedList[0] + seedList[1];
                }

                corpuText.text = "Corpulence : " + corpulence[seedList[2]];
                tailleText.text = "Taille : " + taille[seedList[3]];
                trait01Text.text = "Trait 01 : " + trait01[seedList[4]];
                trait02Text.text = "Trait 02 : " + trait02[seedList[5]];
                trait03Text.text = "Trait 03 : " + trait03[seedList[6]];
                break;
            case 8:
                Debug.Log("Seed count =  8");

                if (seedList[0] != 0 && seedList[1] != 0 && seedList[7] != 0)
                {
                    ageText.text = "Age : " + seedList[0] * seedList[1] * seedList[7];
                }
                else
                {
                    ageText.text = "Age : " + seedList[0] + seedList[1] + seedList[7];
                }

                corpuText.text = "Corpulence : " + corpulence[seedList[2]];
                tailleText.text = "Taille : " + taille[seedList[3]];
                trait01Text.text = "Trait 01 : " + trait01[seedList[4]];
                trait02Text.text = "Trait 02 : " + trait02[seedList[5]];
                trait03Text.text = "Trait 03 : " + trait03[seedList[6]];
                break;
            case 9:
                Debug.Log("Seed count =  9");

                if (seedList[0] != 0 && seedList[1] != 0 && seedList[7] != 0)
                {
                    ageText.text = "Age : " + seedList[0] * seedList[1] * seedList[7];
                }
                else
                {
                    ageText.text = "Age : " + seedList[0] + seedList[1] + seedList[7];
                }

                corpuText.text = "Corpulence : " + corpulence[seedList[2]];
                tailleText.text = "Taille : " + taille[seedList[3]];
                trait01Text.text = "Trait 01 : " + trait01[seedList[4]];
                trait02Text.text = "Trait 02 : " + trait02[seedList[5]];
                trait03Text.text = "Trait 03 : " + trait03[seedList[6]];
                break;
            case 10:
                Debug.Log("Seed count =  10");

                if (seedList[0] != 0 && seedList[1] != 0 && seedList[7] != 0)
                {
                    ageText.text = "Age : " + seedList[0] * seedList[1] * seedList[7];
                }
                else
                {
                    ageText.text = "Age : " + seedList[0] + seedList[1] + seedList[7];
                }

                corpuText.text = "Corpulence : " + corpulence[seedList[2]];
                tailleText.text = "Taille : " + taille[seedList[3]];
                trait01Text.text = "Trait 01 : " + trait01[seedList[4]];
                trait02Text.text = "Trait 02 : " + trait02[seedList[5]];
                trait03Text.text = "Trait 03 : " + trait03[seedList[6]];
                break;
            case >= 11:
                Debug.Log(" Seed pas pris en compte ");      
                break;
            

        }
        
    }

   
}
