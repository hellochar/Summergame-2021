using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereClickHandler : MonoBehaviour {
    public PlayerMovementHandler playerMovementHandler;

  void OnMouseDown() {
      playerMovementHandler.SetGoal(this.transform);
  }

  // Start is called before the first frame update
  void Start() {}

  // Update is called once per frame
  void Update() {}
}
