using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingplacement : MonoBehaviour
{
    private bool currentlyplacing;

    private yerlestirme curbuildingpresent;

    private float indicatorupdate = 0.05f;
    private float lastupdatetime;
    private Vector3 curIndicatorPos;

    public GameObject placementInd�cator;

    public void BeginNewBuildigs(yerlestirme preset)
    {
        if (city.instance.money > preset.cost)
        {
            currentlyplacing = true;
            curbuildingpresent = preset;
            placementInd�cator.SetActive(true);
        }

    }

    public void cancelbuildingplacement()
    {
        currentlyplacing = false;
        placementInd�cator.SetActive(false);
    }

    private void Update()
    {
        if (Time.time - lastupdatetime> indicatorupdate)
        {
            lastupdatetime = Time.time;

            curIndicatorPos = selector.instance.GetCurTilePoisition();

            if (currentlyplacing)
                placementInd�cator.transform.position = curIndicatorPos;
        
        }

        if(Input.GetMouseButtonDown(0) && currentlyplacing)
        {
            PlaceBuilding();
        }
    }

    void PlaceBuilding()
    {
        GameObject buldingobj = Instantiate(curbuildingpresent.prefab, curIndicatorPos, Quaternion.identity);
        city.instance.OnPlaveBuilding(buldingobj.GetComponent<building>());
        
        cancelbuildingplacement();
    }

}
