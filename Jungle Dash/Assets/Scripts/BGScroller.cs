using UnityEngine;

public class BGScroller : MonoBehaviour
{ 
    [Range(-3f,3f)]
    [SerializeField] private float scrollSpeed = 1.5f;
    private float offset;
    [SerializeField] private PlayerController player;
    private Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offset += (Time.deltaTime*scrollSpeed)/10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset,0));
        if (player.upHIT() || player.Hitting() || player.FrontHIT() || player.BackHIT() || player.DownHIT())
        {
            scrollSpeed = 0f;
        }
        else if(player.ThrowITEM()){
            scrollSpeed = 0.5f;
        }
        else if(!player.IsAlive()){
            scrollSpeed = 0f;
        }
        else{
            scrollSpeed = 1.5f;
        }
    }
}