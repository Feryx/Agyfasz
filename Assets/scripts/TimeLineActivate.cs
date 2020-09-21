using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLineActivate : MonoBehaviour {
    public int bassed = 0;
    public GameObject Cameram;
    public GameObject[] feliratok;
    public GameObject[] kacatok;
    // Use this for initialization
    void Start()
    {
        AudioProcessor processor = FindObjectOfType<AudioProcessor>();
        processor.onBeat.AddListener(onOnbeatDetected);
        processor.onSpectrum.AddListener(onSpectrum);
    }
    void onOnbeatDetected()
    {
        bassed++;
        switch (bassed)
        {/*
            case 2: Caam_9(); break;
            case 3: Caam_9(); break;
            case 4: Caam_9(); break;
            case 5: Caam_9(); break;
            /*debug*/

            case 1: Caam_2(); kacatok[3].SetActive(false); kacatok[4].SetActive(true); break;
            case 10: Caam_1(); break;
            case 24: Caam_2(); break;
            case 25: Caam_1(); feliratok[0].SetActive(true); kacatok[1].SetActive(true); kacatok[3].SetActive(false); kacatok[4].SetActive(false);  break;
            case 34: Caam_2(); break;
            case 37: Caam_1(); feliratok[1].SetActive(true); feliratok[0].SetActive(false); kacatok[1].SetActive(false); kacatok[2].SetActive(true); break;
            case 44: Caam_2(); break;
            case 55: Caam_1(); feliratok[2].SetActive(true); feliratok[1].SetActive(false); kacatok[1].SetActive(true); kacatok[2].SetActive(true); break;

            case 65: Caam_1(); feliratok[2].SetActive(false); feliratok[3].SetActive(true); break;
            case 111: Caam_1(); feliratok[3].SetActive(false); feliratok[4].SetActive(true); break;
            case 122: Caam_3(); feliratok[4].SetActive(false); feliratok[5].SetActive(true); break;
            case 131: Caam_4(); feliratok[5].SetActive(false); feliratok[6].SetActive(true); break;
                case 140: Caam_8(); kacatok[0].SetActive(true); break;
            case 141: Caam_5(); feliratok[6].SetActive(false); feliratok[7].SetActive(true); break;
            case 151: Caam_6(); feliratok[7].SetActive(false); kacatok[0].SetActive(false); feliratok[8].SetActive(true); break;
            case 161: Caam_4(); feliratok[8].SetActive(false); feliratok[9].SetActive(true); break;
            case 171: Caam_8(); feliratok[9].SetActive(false); feliratok[10].SetActive(true); kacatok[2].SetActive(false); break;
            case 181: Caam_3(); feliratok[10].SetActive(false); feliratok[11].SetActive(true);  break;
            case 193: Caam_6(); feliratok[11].SetActive(false); feliratok[12].SetActive(true); break;
            case 205: Caam_4(); feliratok[12].SetActive(false); feliratok[12].SetActive(true); kacatok[1].SetActive(false);  break;


            case 215: Caam_1(); feliratok[12].SetActive(false); feliratok[13].SetActive(true); kacatok[0].SetActive(true); break;
            case 273: Caam_1(); feliratok[13].SetActive(false); break;
            case 310: Caam_1(); feliratok[13].SetActive(true); break;


            case 101: Caam_5(); break;
            case 133: Caam_3(); break;
            case 152: Caam_6(); break;
            case 197: Caam_4(); break;
            case 159: Caam_5(); break;
            case 136: Caam_8(); break;
            case 149: Caam_2(); break;
            case 112: Caam_4(); break;
            case 213: Caam_6(); break;

            case 194: Caam_5(); break;

            //215-től szabadkéz 440ig? :D
            case 251: Caam_7(); break;
            case 300: Caam_5(); break;
            case 311: Caam_3(); break;
            case 323: Caam_6(); kacatok[3].SetActive(true); break;
            case 345: Caam_4(); break;
            case 350: Caam_5(); break;
            case 353: Caam_8(); break;
            case 376: Caam_2(); break;
            case 357: Caam_4(); break;
            case 380: Caam_6(); kacatok[3].SetActive(false); break;
            case 392: Caam_7(); break;
            case 400: Caam_5(); kacatok[3].SetActive(true); break;
            case 410: Caam_6(); feliratok[3].SetActive(false); feliratok[13].SetActive(true); break;
            case 420: Caam_3(); break;
                ///InnentolDIFIAS
            case 220: Caam_4(); break;
            case 230: Caam_9(); kacatok[7].SetActive(true);  break;
            case 340: Caam_6(); kacatok[5].SetActive(true); kacatok[7].SetActive(false); break;
            case 250: Caam_8(); kacatok[5].SetActive(false); break;
            case 360: Caam_3(); break;
            case 270: Caam_4(); kacatok[5].SetActive(true); kacatok[7].SetActive(true); break;
            case 381: Caam_5(); kacatok[5].SetActive(false); kacatok[7].SetActive(false); break;
            case 280: Caam_7(); break;
            case 322: Caam_8(); kacatok[1].SetActive(true); break;
            case 432: Caam_3(); break;
            case 440: Application.Quit();  break;
        }
    }

    void Caam_1()
    {
        Cameram.transform.position = new Vector3(8.37f, 0f, -17.1f);
        Camera.main.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
    void Caam_2()
    {
        Cameram.transform.position = new Vector3(0f, 0f, -17.1f);
        Camera.main.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    void Caam_3()
    {//grafika
        Cameram.transform.position = new Vector3(14.4f, -4.39f, -16.17f);
        Camera.main.transform.rotation = Quaternion.Euler(new Vector3(-15, -15, 0));
    }
    void Caam_4()
    {//gamedev
        Cameram.transform.position = new Vector3(0f, 1.99f, -16.17f);
        Camera.main.transform.rotation = Quaternion.Euler(new Vector3(8.485001f, 30, 0f));
    }
    void Caam_5()
    {//wild
        Cameram.transform.position = new Vector3(8.18f, 0f, -18.08f);
        Camera.main.transform.rotation = Quaternion.Euler(new Vector3(0, -3.985f, 0));
    }
    void Caam_6()
    {//256
        Cameram.transform.position = new Vector3(13.14f, 0f, -10.17f);
        Camera.main.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
    }
    void Caam_7()
    {//4k
        Cameram.transform.position = new Vector3(-6.12f, 5.48f, -20.03f);
        Camera.main.transform.rotation = Quaternion.Euler(new Vector3(14.685f, 41.001f, -8.777f));
    }
    void Caam_8()
    {//64
        Cameram.transform.position = new Vector3(10.47f, -1.74f, -20.03f);
        Camera.main.transform.rotation = Quaternion.Euler(new Vector3(-10.192f, -11.359f, -7.504f));
    }
    void Caam_9()
    {//
        Cameram.transform.position = new Vector3(0,0, -44.11f);
        Camera.main.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
    }



    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }

    void onSpectrum(float[] spectrum)
    {

        //The spectrum is logarithmically averaged
        //to 12 bands
        /*
        transform.Rotate(Vector3.left * Time.deltaTime * forog1);
        transform.Rotate(Vector3.up * Time.deltaTime * forog2);
        if (zenemeretes == 0f)
        {
            transform.localScale = new Vector3(Size + Mathf.Abs(spectrum[2] * 0.1f), Size + Mathf.Abs(spectrum[2] * 0.1f), Size + Mathf.Abs(spectrum[2] * 0.1f));
        }
        else { transform.localScale = new Vector3(Size + Mathf.Abs(spectrum[2] * zenemeretes), Size + Mathf.Abs(spectrum[2] * zenemeretes), Size + Mathf.Abs(spectrum[2] * zenemeretes)); }
        /*for (int i = 0; i < spectrum.Length; ++i)
        {

        }*/
    }
}
