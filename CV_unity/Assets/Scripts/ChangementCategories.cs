using System.Collections;
using TMPro;
using UnityEngine;
using System;

public class ChangementCategories : MonoBehaviour
{
    [SerializeField] private GameObject whoami;
    [SerializeField] private GameObject alternance;
    [SerializeField] private GameObject projet;
    [SerializeField] private GameObject stage;
    [SerializeField] private GameObject education;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangementMenu(){
        alternance.SetActive(false);
        stage.SetActive(false);
        education.SetActive(false);
        projet.SetActive(false);
        whoami.SetActive(false);
    }
    
    public void Retour(){
        alternance.SetActive(true);
        stage.SetActive(true);
        education.SetActive(true);
        projet.SetActive(true);
        whoami.SetActive(true);
    }
}
