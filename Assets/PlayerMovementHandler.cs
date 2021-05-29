using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovementHandler : MonoBehaviour {
  public Transform goal;

  private NavMeshAgent playerAgent;

  void Start() {
    playerAgent = GetComponent<NavMeshAgent>();
  }

  void Update() {}

  public void SetGoal(Transform newGoal) {
    playerAgent.destination = newGoal.position;
  }
}
