using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bilgisayfası : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;
    public GameObject canvas5;
    public GameObject canvas6;





    void Start()
    {
        SetCanvasActive(canvas1, true);
        SetCanvasActive(canvas2, false);
        SetCanvasActive(canvas3, false);
        SetCanvasActive(canvas4, false);
        SetCanvasActive(canvas5, false);
        SetCanvasActive(canvas6, false);

    }
    public void canvas0degistir()
    {
        SetCanvasActive(canvas1, true);
        SetCanvasActive(canvas2, false);
        SetCanvasActive(canvas3, false);
        SetCanvasActive(canvas4, false);
        SetCanvasActive(canvas5, false);
        SetCanvasActive(canvas6, false);
    }

    public void canvas1degistir()
    {
        SetCanvasActive(canvas1, false);
        SetCanvasActive(canvas2, true);
        SetCanvasActive(canvas3, false);
        SetCanvasActive(canvas4, false);
        SetCanvasActive(canvas5, false);
        SetCanvasActive(canvas6, false);
    }
    public void canvas2degistir()
    {
        SetCanvasActive(canvas1, false);
        SetCanvasActive(canvas2, false);
        SetCanvasActive(canvas3, true);
        SetCanvasActive(canvas4, false);
        SetCanvasActive(canvas5, false);
        SetCanvasActive(canvas6, false);
    }

    public void canvas3degistir()
    {
        SetCanvasActive(canvas1, false);
        SetCanvasActive(canvas2, false);
        SetCanvasActive(canvas3, false);
        SetCanvasActive(canvas4, true);
        SetCanvasActive(canvas5, false);
        SetCanvasActive(canvas6, false);
    }

    public void canvas4degistir()
    {
        SetCanvasActive(canvas1, false);
        SetCanvasActive(canvas2, false);
        SetCanvasActive(canvas3, false);
        SetCanvasActive(canvas4, false);
        SetCanvasActive(canvas5, true);
        SetCanvasActive(canvas6, false);
    }

    public void canvas5degistir()
    {
        SetCanvasActive(canvas1, false);
        SetCanvasActive(canvas2, false);
        SetCanvasActive(canvas3, false);
        SetCanvasActive(canvas4, false);
        SetCanvasActive(canvas5, false);
        SetCanvasActive(canvas6, true);
    }

    public void sahnedegis()
    {
        // 2. sahneye geç
        SceneManager.LoadScene("Anaekran");
        
    }


    void SetCanvasActive(GameObject canvas, bool isActive)
    {
        // Canvas'ın etkinliğini ayarla
        if (canvas != null)
        {
            canvas.SetActive(isActive);
        }
    }
}
