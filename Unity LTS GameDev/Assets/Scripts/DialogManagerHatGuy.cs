using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManagerHatGuy : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject BlueGuyTalk;
    private AudioSource clicksound;
    void Start()
    {
        StartCoroutine(Type());
        clicksound = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (textDisplay.text == sentences[index])
        {
          
        }
      
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence()
    {
        clicksound.Play();
        if (index < sentences.Length -1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            BlueGuyTalk.SetActive(false);
        }
    }

    private void EndDialogue()
    {

    }

}
