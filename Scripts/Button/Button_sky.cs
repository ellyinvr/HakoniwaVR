using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_sky : MonoBehaviour
{

    public Material sky1;
    public Material sky2;
    public Material sky3;
    public Material sky4;
    public Material sky5;


    public void OnSky1ButtonClicked()
    {
        RenderSettings.skybox = sky1;
    }

    public void OnSky2ButtonClicked()
    {
        RenderSettings.skybox = sky2;
    }

    public void OnSky3ButtonClicked()
    {
        RenderSettings.skybox = sky3;
    }

    public void OnSky4ButtonClicked()
    {
        RenderSettings.skybox = sky4;
    }

    public void OnSky5ButtonClicked()
    {
        RenderSettings.skybox = sky5;
    }

}
