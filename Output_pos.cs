// Output_pos.cs
// AUTOR: Javier Garcia Santana
// FECHA: 27/09/2024
// EMAIL: alu0101391663@ull.edu.es
// VERSION: 1.0
// ASIGNATURA: Interfaces Inteligentes
// PRÁCTICA Nº: 1


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Output_pos : MonoBehaviour {


  void Start() {
    // Find all objects in the scene
    // Tag to filter by (change this to the tag you want to filter)
    string[] targetTags = {"beam", "Dragon", "beam_prefab", "pilar_right", "pilar_middle", "pilar_left"};
    GameObject[] allObjects = FindObjectsOfType<GameObject>();

    // Loop through each object
    foreach (GameObject obj in allObjects) {

      foreach (string targetTag in targetTags) {
        // Check if the object has the target tag and a Transform component
        //Debug.Log(obj.name);
        if (obj.tag == targetTag && obj.transform != null) {
          // Get the object's position from the Transform component
          Vector3 position = obj.transform.position;

          // Log the object's name and its position
          Debug.Log(obj.name + " is tagged and at position: " + position.ToString());
        }
      }
    }
  }

  // Update is called once per frame
  void Update()
  {
    
  }
}
