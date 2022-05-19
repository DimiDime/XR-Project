using System;
using System.Collections;
using System.Collections.Generic;
using Mirage;
using UnityEngine;

public class DisableComponentsIfNotLocal : MonoBehaviour
{
   public NetworkIdentity identity;
   public List<MonoBehaviour> observedComponents = new List<MonoBehaviour>();

   private void Update()
   {
      bool shouldBeEnabled = identity.IsLocalPlayer; // Value true if player prefab spawned by client
      
      foreach (var component in observedComponents)
      {
         component.enabled = shouldBeEnabled;
      }
   }
}
