using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

public class UsingClassExample : MonoBehaviour
{
    [SerializeField] private int GetPunteggio1;
    [SerializeField] public int Attacco;
    [SerializeField] public int salute;


    Persona Player1 = new Persona();
    Persona Player2 = new Persona();
    Enemy Nemico1 = new Enemy();

    void Start()
    {

        Nemico1.salute = salute;

        Player1.GetPunteggio1(GetPunteggio1);
        Player1.Nome = "Andrea";
        Player1.Attacco = Attacco;
        Player2.Nome = "Michelle";



        Debug.Log(Player1.GetPunteggio1(GetPunteggio1) + Player1.Nome);
        IncrementaPunteggio(Player1.GetPunteggio1(GetPunteggio1));
        Debug.Log(IncrementaPunteggio(Player1.GetPunteggio1(GetPunteggio1)) + Player1.Nome);

        Debug.Log(Player2.GetPunteggio1(GetPunteggio1) + Player2.Nome);
        IncrementaPunteggio(Player2.GetPunteggio1(GetPunteggio1));
        Debug.Log(IncrementaPunteggio(Player2.GetPunteggio1(GetPunteggio1)) + Player2.Nome);


        IsVincitore();

        SetPunteggio(GetPunteggio1);

        SubisciDanno(Player1.Attacco, Nemico1.salute, Nemico1);

        //Test per capire se la funzione subiscedanno modificasse effettivamente il valore di 
        //getpunteggio1 fino a zero in modo da far divenire true la funzione setpunteggio e false isvincitore 


        // SubisciDanno(Player1.Attacco, GetPunteggio1, Nemico1);
        //IsVincitore();


        //SetPunteggio(GetPunteggio1);
    }
    public int IncrementaPunteggio(int a)
    {
        int Incremento;
        Incremento = a++;
        return a;
    }

    public bool IsVincitore()
    {
        int valore;
        valore = GetPunteggio1;
        if (valore >= 100)
        {
            Debug.Log("Hai vinto!!!! " + valore);
        }
        return true;
    }

    public void SetPunteggio(int valore)
    {
        if (valore < 0)
        {
            valore = 0;
            GetPunteggio1 = valore;
            Debug.Log("sei sotto lo zero");
        }

    }
    private void SubisciDanno(int a, int b, Enemy nomeNemico)
    {


        while (a > b && b > 0)
        {
            b--;

            Debug.Log("il nemico " + nomeNemico + "ha " + b + "di vita");
        }
        if (b == 0)
        {
            Debug.Log("nemico muore");
        }
    }
}
