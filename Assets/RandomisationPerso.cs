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

    public string[] adroit = new string[] { "A toujours excellemment manié ses compétences.", "Se débrouille habilement dans toutes les situations."};
    public string[] affectueux = new string[] { "A toujours exprimé ses sentiments avec tendresse.", "Montre un amour sincère envers ses proches."};
    public string[] aimable = new string[] { "A toujours été gentil et attentionné envers autrui.", "Se comporte avec une grande politesse et courtoisie."};
    public string[] agressif = new string[] { "A toujours eu un tempérament explosif.", "Cherche souvent le conflit plutôt que la conciliation."};
    public string[] amusant = new string[] { "A toujours été le centre de l'attention avec son humour.", "Anime les rassemblements avec des blagues et des anecdotes."};
    public string[] arrogant = new string[] { "A toujours agi avec un air de supériorité.", "Se croit souvent au-dessus des autres.",};
    public string[] audacieux = new string[] { "A toujours osé relever les défis les plus difficiles.", "Se lance dans des aventures risquées sans hésitation."};
    public string[] attachant = new string[] { "A toujours su charmer les autres par sa personnalité chaleureuse.", "Crée facilement des liens affectifs avec ceux qu'il rencontre."};
    public string[] attendrissant = new string[] { "A toujours touché les cœurs par sa sensibilité.", "Inspire de la compassion et de la tendresse chez les autres."};
    public string[] associal = new string[] { "A toujours préféré la solitude à la compagnie des autres.", "Évite les interactions sociales autant que possible."};
    public string[] beauParleur = new string[] { "A toujours su convaincre avec ses mots.", "Enchante son auditoire avec son éloquence."};
    public string[] bete = new string[] { "A toujours eu du mal à comprendre les choses simples.", "Se laisse souvent guider par ses instincts plutôt que par sa raison."};
    public string[] bienveillant = new string[] { "A toujours agi avec empathie et compassion.", "Se soucie sincèrement du bien-être des autres."};
    public string[] brave = new string[] { "A toujours fait preuve de courage face à l'adversité.", "Affronte les défis avec détermination et intrépidité."};
    public string[] brutal = new string[] { "A toujours résolu les problèmes par la force.", "Adopte une approche agressive dans ses interactions."};
    public string[] belliqueux = new string[] { "A toujours été enclin à se battre pour ce qu'il croit être juste.", "Cherche souvent la confrontation pour affirmer sa position."};
    public string[] boutEnTrain = new string[] { "A toujours animé les rassemblements avec sa joie de vivre.", "Apporte une ambiance joyeuse et enjouée où qu'il aille."};
    public string[] brillant = new string[] { "A toujours ébloui par son intelligence exceptionnelle.", "Se distingue par sa capacité à résoudre les problèmes complexes."};
    public string[] bavard = new string[] { "A toujours eu du mal à garder sa langue dans sa poche.", "Parle sans arrêt, souvent sans réfléchir."};
    public string[] chanceux = new string[] { "A toujours eu la chance du débutant.", "Semble attirer les bonnes opportunités."};
    public string[] chaleureux = new string[] { "A toujours réchauffé les cœurs avec son empathie.", "Irradie une chaleur humaine qui réconforte les autres."};
    public string[] cingle = new string[] { "A toujours eu des idées folles et imprévisibles.", "Défie souvent les normes avec son comportement excentrique."};
    public string[] comique = new string[] { "A toujours fait rire les autres avec son sens de l'humour.", "Crée des moments hilarants avec ses blagues et ses facéties."};
    public string[] consciencieux = new string[] { "A toujours agi avec diligence et sérieux dans tout ce qu'il fait.", "Accorde une grande importance aux détails et à la qualité du travail."};
    public string[] courageux = new string[] { "A toujours fait preuve de bravoure face aux défis.", "N'hésite pas à affronter l'adversité avec détermination."};
    public string[] cupide = new string[] { "A toujours été obsédé par l'accumulation de richesses.", "Recherche constamment son intérêt personnel au détriment des autres."};
    public string[] creatif = new string[] { "A toujours été un véritable génie créatif.", "Imagine des solutions innovantes aux problèmes."};
    public string[] courtois = new string[] { "A toujours agi avec politesse et respect envers autrui.", "Se comporte de manière courtoise dans toutes les situations."};
    public string[] cynique = new string[] { "A toujours adopté une vision pessimiste de la vie.", "Doute souvent des intentions des autres et de la sincérité des actions."};
   
    
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
