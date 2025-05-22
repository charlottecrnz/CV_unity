using UnityEngine;
using System;
using TMPro;
using System.Collections;


public class Dropdown : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private TMP_Dropdown dropdown1;
    [SerializeField] private GameObject dropdown_object1;
    [SerializeField] private GameObject dropdown_object2;
    
    void Start(){
        dropdown_object2.SetActive(false);
    }

    public void GetDropdownValue(){
        int choix_index = dropdown.value;
        string option_choisie = dropdown.options[choix_index].text;
        Debug.Log(choix_index);
    }

    public void Change(){
        dropdown_object1.SetActive(false);
        int choix_index = dropdown.value;
        string option_choisie = dropdown.options[choix_index].text;
        if (option_choisie == "Projets scolaires") {
            dropdown_object2.SetActive(true);
        }
    }
}
