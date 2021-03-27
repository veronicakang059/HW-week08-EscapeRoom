using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public ScriptableObjects currentLocation;
    public Text LocationName;
    public Text LocationDescription;

    public GameObject buttonNorth;
    public GameObject buttonSouth;
    public GameObject buttonWest;
    public GameObject buttonEast;
    
    void Start()
    {
        updateLocation();
    }
    
    public void moveDirection(int dir)
    {
        switch (dir)
        {
            case 0:
                currentLocation = currentLocation.LocationNorth;
                break;
            case 1:
                currentLocation = currentLocation.LocationSouth;
                break;
            case 2:
                currentLocation = currentLocation.LocationWest;
                break;
            case 3:
                currentLocation = currentLocation.LocationEast;
                break;
            default:
                break;
        }
        updateLocation();
    }
    
    void updateLocation()
    {
        LocationName.text = currentLocation.localName;
        LocationDescription.text = currentLocation.description;

        if (currentLocation.LocationNorth == null)
        {
            buttonNorth.SetActive(false);
        }
        else
        {
            currentLocation.LocationNorth.LocationSouth = currentLocation;
            buttonNorth.SetActive(true);
        }

        if (currentLocation.LocationSouth == null)
        {
            buttonSouth.SetActive(false);
        }
        else
        {
            currentLocation.LocationSouth.LocationNorth = currentLocation;
            buttonSouth.SetActive(true);
        }

        if (currentLocation.LocationEast == null)
        {
            buttonEast.SetActive(false);
        }
        else
        {
            currentLocation.LocationEast.LocationWest = currentLocation;
            buttonEast.SetActive(true);
        }

        if (currentLocation.LocationWest == null)
        {
            buttonWest.SetActive(false);
        }
        else
        {
            currentLocation.LocationWest.LocationEast = currentLocation;
            buttonWest.SetActive(true);
        }

    }
    
  
}
