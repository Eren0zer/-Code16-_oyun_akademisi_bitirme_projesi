using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Data.SqlTypes;

public class city : MonoBehaviour
{
    public int money;
    public TextMeshProUGUI statstext;
    public List<building> buildings = new List<building>();
    public float meses�resi = 5f; // Para �retme aral��� (saniye)
    public float cams�resi = 10f; // Para �retme aral��� (saniye)

    public float timer1 = 0f;
    public float timer2 = 0f;


    public static city instance;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        UpdateStatText();
        UpdateStatText();
    }

    public void OnPlaveBuilding(building building)
    {
        money -= building.preset.cost;
        buildings.Add(building);
        
        UpdateStatText();
    }

    public void Update()
    {
        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;


        // A�a�lar i�in belirli aral�klarla para �ret
        if (timer1 >= meses�resi)
        {
            money += 40;
            // Timer'� s�f�rla
            timer1 = 0f;
            UpdateStatText();
        }

        // Binalar i�in belirli aral�klarla para �ret
        if (timer2 >= cams�resi)
        {
            money += 50;
            // Timer'� s�f�rla
            timer2 = 0f;
            UpdateStatText();
        }


    }

   


    private void UpdateStatText()
    {
        statstext.text = string.Format("{0}",new object[] { money });   
    }
}

