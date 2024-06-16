using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class butonlar : MonoBehaviour
{
    public GameObject canvasObject; // Canvas GameObject'u
    public GameObject ayarlarcubuk; 
    public GameObject sehircubuk;
    public GameObject secondCanvas;
    public GameObject sesacik;
    public GameObject seskapali;
    public GameObject infocanvas;
    public GameObject sekme1kapatma;
    public GameObject sekme2kapatma;
    public GameObject agaccesitleri;
    public GameObject sistemleracma;


    private void Start()
    {

        ayarlarcubuk.gameObject.SetActive(false);
        sehircubuk.gameObject.SetActive(false);
        SetCanvasActive(canvasObject, true);
        SetCanvasActive(secondCanvas, false);
        SetCanvasActive(infocanvas, false);
        sesacik.gameObject.SetActive(true);
        seskapali.gameObject.SetActive(false);
        sekme1kapatma.gameObject.SetActive(false);
        sekme2kapatma.gameObject.SetActive(false);
        agaccesitleri.gameObject.SetActive(false);
        sistemleracma.gameObject.SetActive(false);
    }

    public void sestusu()
    {
        // Butona týklanýnca fotoðrafý etkinleþtir veya devre dýþý býrak
        bool isses = sesacik.gameObject.activeSelf;
        bool isses2 = seskapali.gameObject.activeSelf;
        sesacik.gameObject.SetActive(!isses);
        seskapali.gameObject.SetActive(!isses2);

    }

    public void ayarlartusu()
    {
        // Butona týklanýnca fotoðrafý etkinleþtir veya devre dýþý býrak
        bool isayarlarcubuk = ayarlarcubuk.gameObject.activeSelf;
        ayarlarcubuk.gameObject.SetActive(!isayarlarcubuk);

    }

    public void agactusu()
    {
        // Butona týklanýnca fotoðrafý etkinleþtir veya devre dýþý býrak
        bool isagac = agaccesitleri.gameObject.activeSelf;
        agaccesitleri.gameObject.SetActive(!isagac);
        sistemleracma.gameObject.SetActive(false);

    }

    public void sistemtusu()
    {
        // Butona týklanýnca fotoðrafý etkinleþtir veya devre dýþý býrak
        bool issistem = sistemleracma.gameObject.activeSelf;
        sistemleracma.gameObject.SetActive(!issistem);
        agaccesitleri.gameObject.SetActive(false);

 

    }

    public void sekme1tusu()
    {
        // Butona týklanýnca fotoðrafý etkinleþtir veya devre dýþý býrak
        bool issekme = sekme1kapatma.gameObject.activeSelf;
        sekme1kapatma.gameObject.SetActive(!issekme);

    }

    public void sekme2tusu()
    {
        // Butona týklanýnca fotoðrafý etkinleþtir veya devre dýþý býrak
        bool issekme2 = sekme2kapatma.gameObject.activeSelf;
        sekme2kapatma.gameObject.SetActive(!issekme2);

    }

    public void sehirtusu()
    {
        bool issehircubuk = sehircubuk.gameObject.activeSelf;
        sehircubuk.gameObject.SetActive(!issehircubuk);
    }

    public void SwitchCanvases()
    {
        // Ýlk Canvas devre dýþý, ikinci Canvas aktif
        SetCanvasActive(canvasObject, false);
        SetCanvasActive(secondCanvas, true);
    }

    public void canvasdegistir()
    {
        SetCanvasActive(canvasObject, true);
        SetCanvasActive(secondCanvas, false);
    }

    void SetCanvasActive(GameObject canvas, bool isActive)
    {
        // Canvas'ýn etkinliðini ayarla
        if (canvas != null)
        {
            canvas.SetActive(isActive);
        }
    }

    public void oyunukapat()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }

    public void SwitchToSecondScene()
    {
        // 2. sahneye geç
        SceneManager.LoadScene("ekraninfosu");
    }
}