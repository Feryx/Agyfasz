using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsovekKi : MonoBehaviour
{
    public GameObject Cso1;
    public GameObject Cso2;
    public GameObject Cso3;
    public GameObject Cso4;
    public GameObject Cso5;
    public GameObject Cso6;
    public GameObject CsoVeg1;
    public GameObject CsoVeg2;
    public GameObject CsoVeg3;
    public GameObject CsoVeg4;
    public GameObject CsoVeg5;
    public GameObject NagyBize;

    public void CsoKI1() { Cso1.SetActive(false); }
    public void CsoKI2() { Cso2.SetActive(false); }
    public void CsoKI3() { Cso3.SetActive(false); }
    public void CsoKI4() { Cso4.SetActive(false); }
    public void CsoKI5() { Cso5.SetActive(false); }
    public void CsoKI6() { Cso6.SetActive(false); }
    public void CsoVegKI1() { CsoVeg1.SetActive(false); }
    public void CsoVegKI2() { CsoVeg2.SetActive(false); }
    public void CsoVegKI3() { CsoVeg3.SetActive(false); }
    public void CsoVegKI4() { CsoVeg4.SetActive(false); }
    public void CsoVegKI5() { CsoVeg5.SetActive(false); }

    public void CsoBE1() { Cso1.SetActive(true); }
    public void CsoBE2() { Cso2.SetActive(true); }
    public void CsoBE3() { Cso3.SetActive(true); }
    public void CsoBE4() { Cso4.SetActive(true); }
    public void CsoBE5() { Cso5.SetActive(true); }
    public void CsoBE6() { Cso6.SetActive(true); }
    public void CsoVeg_Be1() { CsoVeg1.SetActive(true); }
    public void CsoVeg_Be2() { CsoVeg2.SetActive(true); }
    public void CsoVeg_Be3() { CsoVeg3.SetActive(true); }
    public void CsoVeg_Be4() { CsoVeg4.SetActive(true); }
    public void CsoVeg_Be5() { CsoVeg5.SetActive(true); }

    public void NagyBizeBe() { NagyBize.SetActive(true); }
}