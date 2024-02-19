using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

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

    public string[] adroit = new string[] { "A toujours excellemment mani� ses comp�tences.", "Se d�brouille habilement dans toutes les situations."};
    public string[] affectueux = new string[] { "A toujours exprim� ses sentiments avec tendresse.", "Montre un amour sinc�re envers ses proches."};
    public string[] aimable = new string[] { "A toujours �t� gentil et attentionn� envers autrui.", "Se comporte avec une grande politesse et courtoisie."};
    public string[] agressif = new string[] { "A toujours eu un temp�rament explosif.", "Cherche souvent le conflit plut�t que la conciliation."};
    public string[] amusant = new string[] { "A toujours �t� le centre de l'attention avec son humour.", "Anime les rassemblements avec des blagues et des anecdotes."};
    public string[] arrogant = new string[] { "A toujours agi avec un air de sup�riorit�.", "Se croit souvent au-dessus des autres.",};
    public string[] audacieux = new string[] { "A toujours os� relever les d�fis les plus difficiles.", "Se lance dans des aventures risqu�es sans h�sitation."};
    public string[] attachant = new string[] { "A toujours su charmer les autres par sa personnalit� chaleureuse.", "Cr�e facilement des liens affectifs avec ceux qu'il rencontre."};
    public string[] attendrissant = new string[] { "A toujours touch� les c�urs par sa sensibilit�.", "Inspire de la compassion et de la tendresse chez les autres."};
    public string[] associal = new string[] { "A toujours pr�f�r� la solitude � la compagnie des autres.", "�vite les interactions sociales autant que possible."};
    public string[] beauParleur = new string[] { "A toujours su convaincre avec ses mots.", "Enchante son auditoire avec son �loquence."};
    public string[] bete = new string[] { "A toujours eu du mal � comprendre les choses simples.", "Se laisse souvent guider par ses instincts plut�t que par sa raison."};
    public string[] bienveillant = new string[] { "A toujours agi avec empathie et compassion.", "Se soucie sinc�rement du bien-�tre des autres."};
    public string[] brave = new string[] { "A toujours fait preuve de courage face � l'adversit�.", "Affronte les d�fis avec d�termination et intr�pidit�."};
    public string[] brutal = new string[] { "A toujours r�solu les probl�mes par la force.", "Adopte une approche agressive dans ses interactions."};
    public string[] belliqueux = new string[] { "A toujours �t� enclin � se battre pour ce qu'il croit �tre juste.", "Cherche souvent la confrontation pour affirmer sa position."};
    public string[] boutEnTrain = new string[] { "A toujours anim� les rassemblements avec sa joie de vivre.", "Apporte une ambiance joyeuse et enjou�e o� qu'il aille."};
    public string[] brillant = new string[] { "A toujours �bloui par son intelligence exceptionnelle.", "Se distingue par sa capacit� � r�soudre les probl�mes complexes."};
    public string[] bavard = new string[] { "A toujours eu du mal � garder sa langue dans sa poche.", "Parle sans arr�t, souvent sans r�fl�chir."};
    public string[] chanceux = new string[] { "A toujours eu la chance du d�butant.", "Semble attirer les bonnes opportunit�s."};
    public string[] chaleureux = new string[] { "A toujours r�chauff� les c�urs avec son empathie.", "Irradie une chaleur humaine qui r�conforte les autres."};
    public string[] cingle = new string[] { "A toujours eu des id�es folles et impr�visibles.", "D�fie souvent les normes avec son comportement excentrique."};
    public string[] comique = new string[] { "A toujours fait rire les autres avec son sens de l'humour.", "Cr�e des moments hilarants avec ses blagues et ses fac�ties."};
    public string[] consciencieux = new string[] { "A toujours agi avec diligence et s�rieux dans tout ce qu'il fait.", "Accorde une grande importance aux d�tails et � la qualit� du travail."};
    public string[] courageux = new string[] { "A toujours fait preuve de bravoure face aux d�fis.", "N'h�site pas � affronter l'adversit� avec d�termination."};
    public string[] cupide = new string[] { "A toujours �t� obs�d� par l'accumulation de richesses.", "Recherche constamment son int�r�t personnel au d�triment des autres."};
    public string[] creatif = new string[] { "A toujours �t� un v�ritable g�nie cr�atif.", "Imagine des solutions innovantes aux probl�mes."};
    public string[] courtois = new string[] { "A toujours agi avec politesse et respect envers autrui.", "Se comporte de mani�re courtoise dans toutes les situations."};
    public string[] cynique = new string[] { "A toujours adopt� une vision pessimiste de la vie.", "Doute souvent des intentions des autres et de la sinc�rit� des actions."};
   
    
    void Start()
    {
        RandomizeCharacter();
    }

    public void RandomizeCharacter()
    {
        antennesD.sprite = antennesDL[UnityEngine.Random.Range(0, antennesDL.Length)];
        antennesG.sprite = antennesGL[UnityEngine.Random.Range(0, antennesGL.Length)];
        bouche.sprite = boucheL[UnityEngine.Random.Range(0, boucheL.Length)];
        brasD.sprite = brasDL[UnityEngine.Random.Range(0, brasDL.Length)];
        brasG.sprite = brasGL[UnityEngine.Random.Range(0, brasGL.Length)];
        corps.sprite = corpsL[UnityEngine.Random.Range(0, corpsL.Length)];
        jambesD.sprite = jambesDL[UnityEngine.Random.Range(0, jambesDL.Length)];
        jambesG.sprite = jambesGL[UnityEngine.Random.Range(0, jambesGL.Length)];
        morves.sprite = morvesL[UnityEngine.Random.Range(0, morvesL.Length)];
        nez.sprite = nezL[UnityEngine.Random.Range(0, nezL.Length)];
        yeuxD.sprite = yeuxDL[UnityEngine.Random.Range(0, yeuxDL.Length)];
        yeuxG.sprite = yeuxGL[UnityEngine.Random.Range(0, yeuxGL.Length)];
        SoucilD.sprite = SoucilDL[UnityEngine.Random.Range(0, SoucilDL.Length)];
        SoucilG.sprite = SoucilGL[UnityEngine.Random.Range(0, SoucilGL.Length)];
    }
}
