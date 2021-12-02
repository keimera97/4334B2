using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FogOfWar : MonoBehaviour
{
    public GameObject m_fogOfWarPlane;
    public GameObject[] G_player;

     Transform[] t_player; 

    public LayerMask m_fogLayer;
    public float m_radius = 5f;
    private float m_radiusSqr{get{ return m_radius * m_radius;}}

    private Mesh m_mesh;
    private Vector3[] m_vertices;
    private Color[] m_color;
    


private void Start()
    {
        Initialize();
    }


    private void Update()
    {

        //GetComponent<Renderer>().enabled = false;

        // WhoPlayer.length = m_player.lenght;

        t_player = new Transform[G_player.Length];

        for (int np = 0; np < G_player.Length; np++)
        {
            t_player[np] = G_player[np].transform;
        }
        for (int np = 0; np < t_player.Length; np++)
        {


            Ray r = new Ray(transform.position,t_player[np].position - transform.position);
            RaycastHit hit; 
            
            if (Physics.Raycast(r, out hit, 1000, m_fogLayer, QueryTriggerInteraction.Collide))
        {
            for (int i=0;i< m_vertices.Length; i++)
            {
                Vector3 v = m_fogOfWarPlane.transform.TransformPoint(m_vertices[i]);
                    //Debug.DrawRay(transform.position, v, Color.green, 2, false);
                float dist = Vector3.SqrMagnitude(v - hit.point);
                if(dist < m_radiusSqr)
                {
                    float alpha = Mathf.Min(m_color[i].a, dist/m_radiusSqr);
                    m_color[i].a = alpha;
                }
            }

            UpdateColor();

        }

        }
       
        


    }

    void Initialize()
    {
        m_mesh = m_fogOfWarPlane.GetComponent<MeshFilter>().mesh;
        m_vertices = m_mesh.vertices;
        m_color = new Color[m_vertices.Length];
        for (int i=0; i<m_color.Length; i++)
        {
            m_color[i] = Color.black;
        }
        UpdateColor();
    }

    void UpdateColor()
    {
        m_mesh.colors = m_color;
    }

}
