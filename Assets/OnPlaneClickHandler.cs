using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OnPlaneClickHandler : MonoBehaviour {
  public NavMeshAgent agent;

  void OnMouseDown() {
    RaycastHit hit;

    if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
      agent.destination = hit.point;
    }
  }

  // Start is called before the first frame update
  void Start() {
      agent = GameObject.Find("Player").GetComponent<NavMeshAgent>();
  }

  // Update is called once per frame
  void Update() { }
}
