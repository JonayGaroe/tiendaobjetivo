using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
public class ButtonShop : MonoBehaviour
{
    [SerializeField]
    Wallet myWallet;
    // [SerializeField]
    TextMeshProUGUI textButton;
    [SerializeField]
    string nameItem = "Objeto"; 
    [SerializeField]
    float priceItem;
    [SerializeField]
    GameObject confirmarSi;

    [SerializeField]
    GameObject clickReinicio;

    void Start()
    {
     textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
     priceItem = Random.Range(25f, 350f);
     textButton.text = priceItem.ToString() + " €";
    }
    public void ClickEnBotonDeTienda()
    {
     confirmarSi.SetActive(true);

    }
    public void ClickReinicio()
    {
     clickReinicio.SetActive(false);
    }
    public void ConfirmarSi()
    {
        confirmarSi.SetActive(false);
        myWallet.RestarSaldo(priceItem);

    }
    public void confirmarNO()
    {
        confirmarSi.SetActive(false);

    }


}