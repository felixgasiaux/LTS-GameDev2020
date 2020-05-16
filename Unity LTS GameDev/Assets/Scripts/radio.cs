using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class radio : MonoBehaviour
{
    public GameObject PressEtorepair;
    private bool radiocanbeopen;
    public GameObject radio_group;
    private bool radioopen;
    public GameObject aim;
    public GameObject NoWIFI;
    public GameObject WIFI;
    public GameObject button_repair;
    public GameObject button_menu;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;
    public Slider mainSlider;
    private bool finish;
    public TextMeshProUGUI Text_Display_Mission;
    public AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        radiocanbeopen = false;
        radioopen = false;
        radio_group.SetActive(false);
        aim.SetActive(true);
        WIFI.SetActive(false);
        NoWIFI.SetActive(true);
        button_repair.SetActive(true);
        button_menu.SetActive(false);
        text1.text = "No signal...";
        text2.text = "Error 42";
        text3.text = "";
        text4.text = "";
        finish = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (radiocanbeopen == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E pressed"+radioopen);
                if (radioopen == false)
                {
                    radio_group.SetActive(true);
                    PressEtorepair.SetActive(false);
                    aim.SetActive(false);
                    Cursor.visible = true;
                    radioopen = true;                }
                else
                {
                    text1.text = "No signal...";
                    text2.text = "Error 42";
                    text3.text = "";
                    text4.text = "";
                    radio_group.SetActive(false);
                    PressEtorepair.SetActive(true);
                    aim.SetActive(true);
                    Cursor.visible = false;
                    radioopen = false;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PressEtorepair.SetActive(true);
        radiocanbeopen = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        PressEtorepair.SetActive(false);
        radiocanbeopen = false;
    }
    public void repair()
    {
        audioData.Play(0);
        Debug.Log("repair");


        if (mainSlider.value == 100)
        {
            text1.text = "Signal back";
            text2.text = "Radio repaired";
            text3.text = mainSlider.value + "/100 metal";
            text4.text = "You did it !!!";
            WIFI.SetActive(true);
            NoWIFI.SetActive(false);
            NoWIFI.SetActive(false);
            button_repair.SetActive(false);
            button_menu.SetActive(true);
            finish = true;
            Text_Display_Mission.text = "You finished the game !";
        }
        else
        {
            text1.text = "No signal...";
            text2.text = "Cannot repair";
            text3.text = "Error 404";
            text4.text = mainSlider.value + "/100 metal";
        }
    }
    public void menu()
    {
        audioData.Play(0);
        if (finish == true)
        {
            SceneManager.LoadScene("You won");
        }
    }
}

