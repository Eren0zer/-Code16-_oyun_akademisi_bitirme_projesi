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
    public float mesesüresi = 5f; // Para üretme aralýðý (saniye)
    public float camsüresi = 10f; // Para üretme aralýðý (saniye)

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


        // Aðaçlar için belirli aralýklarla para üret
        if (timer1 >= mesesüresi)
        {
            money += 40;
            // Timer'ý sýfýrla
            timer1 = 0f;
            UpdateStatText();
        }

        // Binalar için belirli aralýklarla para üret
        if (timer2 >= camsüresi)
        {
            money += 50;
            // Timer'ý sýfýrla
            timer2 = 0f;
            UpdateStatText();
        }


    }

   


    private void UpdateStatText()
    {
        statstext.text = string.Format("{0}",new object[] { money });   
    }
}

