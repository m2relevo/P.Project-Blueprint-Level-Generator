using UnityEngine;
using System.Collections;

public class LevelGenerator : MonoBehaviour
{
    public Texture2D Level = null;

    public GameObject Tile_Terrain_Floor = null;
    public GameObject Tile_Terrain_Wall = null;

    public GameObject Tile_Terrain_eFloor_Down = null;
    public GameObject Tile_Terrain_eFloor_Up = null;
    public GameObject Tile_Terrain_eFloor_Slow = null;
    public GameObject Tile_Terrain_eFloor_Fast = null;
    public GameObject Tile_Terrain_eFloor_lowGrav = null;
    public GameObject Tile_Terrain_eFloor_highGrav = null;

    public GameObject Tile_Object_Key = null;
    public GameObject Tile_Object_Door = null;
    

    private Color C_black = new Color(0F, 0F, 0F, 1F);
    private Color C_white = new Color(1f, 1f, 1f, 1f);
    private Color C_red = new Color(1f, 0f, 0f, 1f);

    // Use this for initialization
    void Start()
    {
        lvl();
        Debug.Log("Level Blue size |-| X:" + Level.width + "Y:" + Level.height);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void lvl()
    {

        for (int xPixelcoor = 0; xPixelcoor < Level.width; xPixelcoor++)
        {
            for (int yPixelcoor = 0; yPixelcoor < Level.height; yPixelcoor++)
            {
                Color pixelColor = Level.GetPixel(xPixelcoor, yPixelcoor);

                if (pixelColor == C_red)
                {
                    GameObject TT_floor = (GameObject)Instantiate(Tile_Terrain_Floor);
                    TT_floor.transform.position = new Vector2(xPixelcoor, yPixelcoor);
                    Debug.Log("Tile_Terrain_Floor placed at location |-| " + "X:" + xPixelcoor + "Y:" + yPixelcoor);
                }

                if (pixelColor == C_white)
                {
                    GameObject TT_wall = (GameObject)Instantiate(Tile_Terrain_Wall);
                    TT_wall.transform.position = new Vector2(xPixelcoor, yPixelcoor);
                    Debug.Log("Tile_Terrain_Wall placed at location |-| " + "X:" + xPixelcoor + "Y:" + yPixelcoor);
                }

                if (pixelColor == null)
                {
                    Debug.Log("Empty Color location |-| " + "X:" + xPixelcoor + "Y:" + yPixelcoor);
                }
            }
        }
    }
}