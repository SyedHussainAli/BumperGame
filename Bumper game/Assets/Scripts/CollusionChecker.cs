using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollusionChecker : MonoBehaviour
{
    public GameObject otherObject = null;
    private float lowBound = -2;

    public Texture[] m_MainTexture;
    private Renderer m_Renderer;
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
      //  m_Renderer.material.EnableKeyword("_NORMALMAP");
       // m_Renderer.material.EnableKeyword("_METALLICGLOSSMAP");
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y<lowBound&&otherObject!=null)
        {
            BoostPlayer();
            Destroy(gameObject);
        }
        else if(gameObject.transform.position.y<lowBound)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ground"))
            otherObject = collision.gameObject;
    }
   private void BoostPlayer() 
    {
        int position = Random.Range(0, m_MainTexture.Length);
        otherObject.gameObject.GetComponent<Rigidbody>().mass += 1;
        otherObject.transform.localScale += transform.localScale;
        //m_Renderer.material.SetTexture("_MainTex", m_MainTexture);
        otherObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", m_MainTexture[position]);
    }
}
