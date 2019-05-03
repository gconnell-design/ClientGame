using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour {

    public List<Unit> UnitList = new List<Unit>();


	// Use this for initialization
	void Start () {
        Unit newUnit = new Unit();
        newUnit.Name = "Pikachu";
        UnitList.Add(newUnit);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
