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

    public string[] adroit = new string[] { "A toujours excellemment mani� ses comp�tences.", "Se d�brouille habilement dans toutes les situations.", "Trouve toujours une solution cr�ative aux probl�mes." };
    public string[] affectueux = new string[] { "A toujours exprim� ses sentiments avec tendresse.", "Montre un amour sinc�re envers ses proches.", "Cherche constamment � r�conforter ceux qui en ont besoin." };
    public string[] aimable = new string[] { "A toujours �t� gentil et attentionn� envers autrui.", "Se comporte avec une grande politesse et courtoisie.", "Cultive des relations harmonieuses avec son entourage." };
    public string[] agressif = new string[] { "A toujours eu un temp�rament explosif.", "Cherche souvent le conflit plut�t que la conciliation.", "Affiche une attitude hostile envers ceux qui le contrarient." };
    public string[] amusant = new string[] { "A toujours �t� le centre de l'attention avec son humour.", "Anime les rassemblements avec des blagues et des anecdotes.", "Fait de chaque moment une occasion de rire et de d�tente." };
    public string[] arrogant = new string[] { "A toujours agi avec un air de sup�riorit�.", "Se croit souvent au-dessus des autres.", "Refuse g�n�ralement d'admettre ses erreurs." };
    public string[] audacieux = new string[] { "A toujours os� relever les d�fis les plus difficiles.", "Se lance dans des aventures risqu�es sans h�sitation.", "Est pr�t � prendre des risques pour atteindre ses objectifs." };
    public string[] attachant = new string[] { "A toujours su charmer les autres par sa personnalit� chaleureuse.", "Cr�e facilement des liens affectifs avec ceux qu'il rencontre.", "Poss�de un pouvoir naturel d'attirer la sympathie." };
    public string[] attendrissant = new string[] { "A toujours touch� les c�urs par sa sensibilit�.", "Inspire de la compassion et de la tendresse chez les autres.", "D�gage une aura de douceur et de vuln�rabilit�." };
    public string[] associal = new string[] { "A toujours pr�f�r� la solitude � la compagnie des autres.", "�vite les interactions sociales autant que possible.", "Se sent plus � l'aise dans son propre monde." };
    public string[] beauParleur = new string[] { "A toujours su convaincre avec ses mots.", "Enchante son auditoire avec son �loquence.", "Poss�de un don pour persuader et influencer." };
    public string[] bete = new string[] { "A toujours eu du mal � comprendre les choses simples.", "Se laisse souvent guider par ses instincts plut�t que par sa raison.", "Ne brille pas par son intelligence." };
    public string[] bienveillant = new string[] { "A toujours agi avec empathie et compassion.", "Se soucie sinc�rement du bien-�tre des autres.", "Offre son soutien inconditionnel � ceux qui en ont besoin." };
    public string[] brave = new string[] { "A toujours fait preuve de courage face � l'adversit�.", "Affronte les d�fis avec d�termination et intr�pidit�.", "Ne recule jamais devant les obstacles." };
    public string[] brutal = new string[] { "A toujours r�solu les probl�mes par la force.", "Adopte une approche agressive dans ses interactions.", "Ne montre aucune piti� envers ses ennemis." };
    public string[] belliqueux = new string[] { "A toujours �t� enclin � se battre pour ce qu'il croit �tre juste.", "Cherche souvent la confrontation pour affirmer sa position.", "Poss�de un temp�rament querelleur et agressif." };
    public string[] boutEnTrain = new string[] { "A toujours anim� les rassemblements avec sa joie de vivre.", "Apporte une ambiance joyeuse et enjou�e o� qu'il aille.", "Est toujours pr�t � faire rire les autres." };
    public string[] brillant = new string[] { "A toujours �bloui par son intelligence exceptionnelle.", "Se distingue par sa capacit� � r�soudre les probl�mes complexes.", "Brille dans tous les domaines qu'il aborde." };
    public string[] bavard = new string[] { "A toujours eu du mal � garder sa langue dans sa poche.", "Parle sans arr�t, souvent sans r�fl�chir.", "Remplit l'espace avec un flot incessant de paroles." };
    public string[] chanceux = new string[] { "A toujours eu la chance du d�butant.", "Semble attirer les bonnes opportunit�s.", "Vit une vie pleine de bonnes surprises." };
    public string[] chaleureux = new string[] { "A toujours r�chauff� les c�urs avec son empathie.", "Irradie une chaleur humaine qui r�conforte les autres.", "Cr�e des liens �troits gr�ce � sa bienveillance." };
    public string[] cingle = new string[] { "A toujours eu des id�es folles et impr�visibles.", "D�fie souvent les normes avec son comportement excentrique.", "Fait des choses que la plupart des gens consid�reraient comme insens�es." };
    public string[] comique = new string[] { "A toujours fait rire les autres avec son sens de l'humour.", "Cr�e des moments hilarants avec ses blagues et ses fac�ties.", "Poss�de un talent naturel pour divertir et amuser." };
    public string[] consciencieux = new string[] { "A toujours agi avec diligence et s�rieux dans tout ce qu'il fait.", "Accorde une grande importance aux d�tails et � la qualit� du travail.", "Fait preuve d'un engagement constant envers l'excellence." };
    public string[] courageux = new string[] { "A toujours fait preuve de bravoure face aux d�fis.", "N'h�site pas � affronter l'adversit� avec d�termination.", "Se distingue par sa force int�rieure et sa r�silience." };
    public string[] cupide = new string[] { "A toujours �t� obs�d� par l'accumulation de richesses.", "Recherche constamment son int�r�t personnel au d�triment des autres.", "Ne pense qu'� s'enrichir, peu importe les cons�quences." };
    public string[] creatif = new string[] { "A toujours �t� un v�ritable g�nie cr�atif.", "Imagine des solutions innovantes aux probl�mes.", "Transforme les id�es en �uvres d'art avec aisance." };
    public string[] courtois = new string[] { "A toujours agi avec politesse et respect envers autrui.", "Se comporte de mani�re courtoise dans toutes les situations.", "Cultive des relations harmonieuses gr�ce � son attitude respectueuse." };
    public string[] cynique = new string[] { "A toujours adopt� une vision pessimiste de la vie.", "Doute souvent des intentions des autres et de la sinc�rit� des actions.", "Voit le monde � travers un prisme de scepticisme et de m�fiance." };
   
    
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
