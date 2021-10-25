using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCylinder : MonoBehaviour
{
    [SerializeField]
    GameObject hitpoint1;
    [SerializeField]
    GameObject hitpoint2;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Red")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = new Color(245f / 255f, 79f / 255f, 61f / 255f);
        }

        if (other.gameObject.name == "Magenta")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = Color.magenta;
        }

        if (other.gameObject.name == "Yellow")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = new Color(245f / 255f, 217f / 255f, 3f / 255f);
        }

        if (other.gameObject.name == "Green")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = new Color(42f / 255f, 156f / 255f, 24f / 255f);
        }

        if (other.gameObject.name == "Cyan")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (other.gameObject.name == "Blue")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = new Color(37f / 255f, 120f / 255f, 250f / 255f);
        }

        if (other.gameObject.name == "Brown")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = new Color(171f / 255f, 79f / 255f, 52f / 255f);
        }

        if (other.gameObject.name == "Gray")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = new Color(133f / 255f, 131f / 255f, 132f / 255f);
        }

        if (other.gameObject.name == "Orange")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = new Color(226f / 255f, 154f / 255f, 82f / 255f);
        }

        if (other.gameObject.name == "YellowGreen")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = new Color(12f / 255f, 197f / 255f, 47f / 255f);
        }

        if (other.gameObject.name == "Pink")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = new Color(236f / 255f, 114f / 255f, 250f / 255f);
        }

        if (other.gameObject.name == "BlueGreen")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = new Color(6f / 255f, 251f / 255f, 162f / 255f);
        }

        if (other.gameObject.name == "White")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = Color.white;
        }

        if (other.gameObject.name == "Black")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = Color.black;
        }

        if (other.gameObject.name == "Orange2")
        {
            Destroy(hitpoint1);
            Destroy(hitpoint2);

            GetComponent<Renderer>().material.color = new Color(233f / 255f, 120f / 255f, 6f / 255f);
        }
    }
}