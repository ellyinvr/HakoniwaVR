using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonInteractionMenu : MonoBehaviour
{

    // public TextMeshProUGUI simpleUIText; 
    public GameObject trees;
    public GameObject rocks;
    public GameObject plants;
    public GameObject characters;
    public GameObject houses;
    public GameObject props2;
    public GameObject props3;
    public GameObject props4;
    public GameObject terrain;

    public GameObject treeButton;
    public GameObject rockButton;
    public GameObject plantButton;
    public GameObject charaButton;
    public GameObject houseButton;
    public GameObject props2Button;
    public GameObject props3Button;
    public GameObject props4Button;
    public GameObject terrainButton;



    public void OnTreesButtonClicked()
    {
        trees.SetActive(true);
        treeButton.SetActive(true);

        rocks.SetActive(false);
        rockButton.SetActive(false);

        plants.SetActive(false);
        plantButton.SetActive(false);


        houses.SetActive(false);
        houseButton.SetActive(false);

        characters.SetActive(false);
        charaButton.SetActive(false);

        props2.SetActive(false);
        props2Button.SetActive(false);

        props3.SetActive(false);
        props3Button.SetActive(false);

        props4.SetActive(false);
        props4Button.SetActive(false);

        terrain.SetActive(false);
        terrainButton.SetActive(false);
    }

    public void OnRocksButtonClicked()
    {
        trees.SetActive(false);
        treeButton.SetActive(false);

        rocks.SetActive(true);
        rockButton.SetActive(true);

        plants.SetActive(false);
        plantButton.SetActive(false);


        houses.SetActive(false);
        houseButton.SetActive(false);

        characters.SetActive(false);
        charaButton.SetActive(false);

        props2.SetActive(false);
        props2Button.SetActive(false);

        props3.SetActive(false);
        props3Button.SetActive(false);

        props4.SetActive(false);
        props4Button.SetActive(false);

        terrain.SetActive(false);
        terrainButton.SetActive(false);
    }


    public void OnPlantsButtonClicked()
    {
        trees.SetActive(false);
        treeButton.SetActive(false);

        rocks.SetActive(false);
        rockButton.SetActive(false);

        plants.SetActive(true);
        plantButton.SetActive(true);


        houses.SetActive(false);
        houseButton.SetActive(false);

        characters.SetActive(false);
        charaButton.SetActive(false);

        props2.SetActive(false);
        props2Button.SetActive(false);

        props3.SetActive(false);
        props3Button.SetActive(false);

        props4.SetActive(false);
        props4Button.SetActive(false);

        terrain.SetActive(false);
        terrainButton.SetActive(false);
    }

    public void OnHousesButtonClicked()
    {
        trees.SetActive(false);
        treeButton.SetActive(false);

        rocks.SetActive(false);
        rockButton.SetActive(false);

        plants.SetActive(false);
        plantButton.SetActive(false);


        houses.SetActive(true);
        houseButton.SetActive(true);

        characters.SetActive(false);
        charaButton.SetActive(false);

        props2.SetActive(false);
        props2Button.SetActive(false);

        props3.SetActive(false);
        props3Button.SetActive(false);

        props4.SetActive(false);
        props4Button.SetActive(false);

        terrain.SetActive(false);
        terrainButton.SetActive(false);
    }

    public void OnCharactersButtonClicked()
    {
        trees.SetActive(false);
        treeButton.SetActive(false);

        rocks.SetActive(false);
        rockButton.SetActive(false);

        plants.SetActive(false);
        plantButton.SetActive(false);


        houses.SetActive(false);
        houseButton.SetActive(false);

        characters.SetActive(true);
        charaButton.SetActive(true);

        props2.SetActive(false);
        props2Button.SetActive(false);

        props3.SetActive(false);
        props3Button.SetActive(false);

        props4.SetActive(false);
        props4Button.SetActive(false);

        terrain.SetActive(false);
        terrainButton.SetActive(false);
    }

    public void OnProps2ButtonClicked()
    {
        trees.SetActive(false);
        treeButton.SetActive(false);

        rocks.SetActive(false);
        rockButton.SetActive(false);

        plants.SetActive(false);
        plantButton.SetActive(false);


        houses.SetActive(false);
        houseButton.SetActive(false);

        characters.SetActive(false);
        charaButton.SetActive(false);

        props2.SetActive(true);
        props2Button.SetActive(true);

        props3.SetActive(false);
        props3Button.SetActive(false);

        props4.SetActive(false);
        props4Button.SetActive(false);

        terrain.SetActive(false);
        terrainButton.SetActive(false);
    }

    public void OnProps3ButtonClicked()
    {
        trees.SetActive(false);
        treeButton.SetActive(false);

        rocks.SetActive(false);
        rockButton.SetActive(false);

        plants.SetActive(false);
        plantButton.SetActive(false);


        houses.SetActive(false);
        houseButton.SetActive(false);

        characters.SetActive(false);
        charaButton.SetActive(false);

        props2.SetActive(false);
        props2Button.SetActive(false);

        props3.SetActive(true);
        props3Button.SetActive(true);

        props4.SetActive(false);
        props4Button.SetActive(false);

        terrain.SetActive(false);
        terrainButton.SetActive(false);
    }

    public void OnProps4ButtonClicked()
    {
        trees.SetActive(false);
        treeButton.SetActive(false);

        rocks.SetActive(false);
        rockButton.SetActive(false);

        plants.SetActive(false);
        plantButton.SetActive(false);


        houses.SetActive(false);
        houseButton.SetActive(false);

        characters.SetActive(false);
        charaButton.SetActive(false);

        props2.SetActive(false);
        props2Button.SetActive(false);

        props3.SetActive(false);
        props3Button.SetActive(false);

        props4.SetActive(true);
        props4Button.SetActive(true);

        terrain.SetActive(false);
        terrainButton.SetActive(false);
    }

    public void OnTerrainButtonClicked()
    {
        trees.SetActive(false);
        treeButton.SetActive(false);

        rocks.SetActive(false);
        rockButton.SetActive(false);

        plants.SetActive(false);
        plantButton.SetActive(false);


        houses.SetActive(false);
        houseButton.SetActive(false);

        characters.SetActive(false);
        charaButton.SetActive(false);

        props2.SetActive(false);
        props2Button.SetActive(false);

        props3.SetActive(false);
        props3Button.SetActive(false);

        props4.SetActive(false);
        props4Button.SetActive(false);

        terrain.SetActive(true);
        terrainButton.SetActive(true);
    }

}
