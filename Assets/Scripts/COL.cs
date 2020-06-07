using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class COL : MonoBehaviour
{
    private GameObject Sphere1, Sphere2;
    public Vector3 Po1, Po2;
    float pnum, M1, M2, V1, V2, e ,R, Vc1, Vc2, x1i, x2i;
    public InputField M1T, M2T, V1T, V2T, eT;

    // Start is called before the first frame update
    void Start()
    {

        Sphere1 = GameObject.Find("Sphere_A");
        Sphere2 = GameObject.Find("Sphere_B");
        Po1 = Sphere1.GetComponent<Transform>().position;
        Po2 = Sphere2.GetComponent<Transform>().position;
        R = 10f;
        x1i = Po1.x; x2i = Po2.x;
        V1 = 0;
        V2 = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Mathf.Abs(Po1.x - Po2.x) <= (R))
        {
            V1 = Vc1; V2 = Vc2;
        }
        
      
            Po1.x = Po1.x + Time.fixedDeltaTime * V1;
            Po2.x = Po2.x + Time.fixedDeltaTime * V2;


        Sphere1.GetComponent<Transform>().position = Po1;
        Sphere2.GetComponent<Transform>().position = Po2;
    }

   public void StartAp()
    {
        M1 = float.Parse(M1T.text); 
        M2 = float.Parse(M2T.text);
        V1 = float.Parse(V1T.text);
        V2 = float.Parse(V2T.text);
        e = float.Parse(eT.text);
        Vc1 = ((M1 - e * M2) / (M1 + M2)) * V1 + (((1 + e) * M2) / (M1 + M2)) * V2;
        Vc2 = (((1 + e) * M1) / (M1 + M2)) * V1 + ((M2 - (e * M1)) / (M1 + M2)) * V2;
        Debug.Log(" =C  auch");
    }




    public void Reset()
    {
        V1 = 0f;
        V2 = 0f;
        Po1.x = x1i; Po2.x = x2i;
        Sphere1.GetComponent<Transform>().position = Po1;
        Sphere2.GetComponent<Transform>().position = Po2;
       
    }
}
