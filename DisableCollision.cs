using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class DisableCollision : MonoBehaviour
{
    public void Disable()
    {
        List<Deco> list =  AssetManager.Instance.getDecoObjects().ToList();
        foreach (Deco D in list)
        {
            try
            {
                foreach (BoundingVolume BV in D.GetComponents<BoundingVolume>())
                {
                    DestroyImmediate(BV);
                }
            }
            catch (Exception)
            {
                
            }
        }
        Debug.Log("Disabled Deco Collisions");

    }
}