using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material customMaterial;
    public Material originalMaterial;

    // Set custom material to object
    public void setCustomMaterial()
    {
        GetComponent<MeshRenderer>().material = customMaterial;
    }

    // Reset object`s material
    public void resetTexture()
    {
        GetComponent <MeshRenderer>().material = originalMaterial;
    }
}
