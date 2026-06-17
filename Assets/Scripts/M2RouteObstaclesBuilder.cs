using UnityEngine;

public class M2RouteObstaclesBuilder : MonoBehaviour
{
    [ContextMenu("Build Route Obstacles Scene")]
    public void BuildRouteObstaclesScene()
    {
        ClearOldObjects();

        // Route / terrain
        CreateCube("Road", new Vector3(0, 0, 25), new Vector3(9, 0.2f, 50), Color.gray);

        // Murs pour délimiter le parcours
        CreateCube("LeftWall", new Vector3(-5, 1, 25), new Vector3(0.3f, 2, 50), Color.black);
        CreateCube("RightWall", new Vector3(5, 1, 25), new Vector3(0.3f, 2, 50), Color.black);

        // Lignes simples pour montrer les voies
        CreateCube("LeftLaneLine", new Vector3(-1.5f, 0.15f, 25), new Vector3(0.08f, 0.05f, 50), Color.white);
        CreateCube("RightLaneLine", new Vector3(1.5f, 0.15f, 25), new Vector3(0.08f, 0.05f, 50), Color.white);

        // Obstacles simples avec des cubes
        CreateCube("Obstacle_1_Middle", new Vector3(0, 0.75f, 8), new Vector3(1.5f, 1.5f, 1.5f), Color.red);
        CreateCube("Obstacle_2_Left", new Vector3(-3, 0.75f, 15), new Vector3(1.5f, 1.5f, 1.5f), Color.red);
        CreateCube("Obstacle_3_Right", new Vector3(3, 0.75f, 23), new Vector3(1.5f, 1.5f, 1.5f), Color.red);
        CreateCube("Obstacle_4_Middle", new Vector3(0, 0.75f, 32), new Vector3(1.5f, 1.5f, 1.5f), Color.red);
        CreateCube("Obstacle_5_Left", new Vector3(-3, 0.75f, 42), new Vector3(1.5f, 1.5f, 1.5f), Color.red);

        // Petit décor de base sur les côtés
        CreateCube("Decoration_Left_Block", new Vector3(-7, 0.5f, 12), new Vector3(1.5f, 1, 3), Color.yellow);
        CreateCube("Decoration_Right_Block", new Vector3(7, 0.5f, 28), new Vector3(1.5f, 1, 3), Color.yellow);
        CreateCube("Decoration_Back_Block", new Vector3(0, 0.5f, 52), new Vector3(9, 1, 0.5f), Color.yellow);
    }

    void CreateCube(string objectName, Vector3 position, Vector3 scale, Color color)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.name = objectName;
        cube.transform.SetParent(transform);
        cube.transform.position = position;
        cube.transform.localScale = scale;

        Renderer renderer = cube.GetComponent<Renderer>();
        renderer.material.color = color;
    }

    void ClearOldObjects()
    {
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            DestroyImmediate(transform.GetChild(i).gameObject);
        }
    }
}
