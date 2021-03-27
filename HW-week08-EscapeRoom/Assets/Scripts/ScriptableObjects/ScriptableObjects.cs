using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Locations", menuName = "ScriptableObjects/Locations",order = 0)]
public class ScriptableObjects : ScriptableObject
{
    public string localName = "New Location";
    public string description = "Default Description";

    public ScriptableObjects LocationNorth;
    public ScriptableObjects LocationSouth;
    public ScriptableObjects LocationWest;
    public ScriptableObjects LocationEast;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
