using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARCore;
public class FaceSwap : MonoBehaviour
{
    private ARFaceManager faceManager;

    public List<Material> faceMaterials = new List<Material>();

    private int faceMaterialIndex = 1;



    // Start is called before the first frame update
    void Start()
    {

        faceManager = GetComponent<ARFaceManager>();
        SwitchFace();

    }

    public void SwitchFace()
    {

        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<Renderer>().material = faceMaterials[faceMaterialIndex];
        }
        faceMaterialIndex++;
        if (faceMaterialIndex == faceMaterials.Count)
        {
            faceMaterialIndex = 0;
        }

    }

}
