using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class watchSelect : MonoBehaviour
{
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    Animation w1WindowAnimation;
    Animation w2WindowAnimation;
    Animation w3WindowAnimation;
    // Start is called before the first frame update
    void Start()
    {
        w1WindowAnimation = w1Window.GetComponent<Animation>();
        w2WindowAnimation = w2Window.GetComponent<Animation>();
        w3WindowAnimation = w3Window.GetComponent<Animation>();
    }

    public void WatchOneButtonClicked()
    {
        //1. Show watch one
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        //2. Animate watch one window
        w1WindowAnimation["W1animation"].speed = 1;
        w1WindowAnimation.Play();
    }

    public void WatchTwoButtonClicked()
    {
        //1. Show watch two
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        //2. Animate watch two window
        w2WindowAnimation["W2animation"].speed = 1;
        w2WindowAnimation.Play();

    }

    public void WatchThreeButtonClicked()
    {
        //1. Show watch three
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);

        //2. Animate watch three window
        w3WindowAnimation["W3animation"].speed = 1;
        w3WindowAnimation.Play();
    }

    public void CloseButtonClicked()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if(buttonName == "w1Close")
        {
            w1WindowAnimation["W1animation"].speed = -1;
            w1WindowAnimation["W1animation"].time = w1WindowAnimation["W1animation"].length;
            w1WindowAnimation.Play();
        }
        else if(buttonName == "w2Close")
        {
            w2WindowAnimation["W2animation"].speed = -1;
            w2WindowAnimation["W2animation"].time = w2WindowAnimation["W2animation"].length;
            w2WindowAnimation.Play();
        }
        else if(buttonName == "w3Close")
        {
            w3WindowAnimation["W3animation"].speed = -1;
            w3WindowAnimation["W3animation"].time = w3WindowAnimation["W3animation"].length;
            w3WindowAnimation.Play();
        }
    }
}