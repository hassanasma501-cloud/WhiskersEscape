using UnityEngine;

public class RoadAndObstacles : MonoBehaviour
{
    void Start()
    {
        CreateRoad();
        CreateWalls();
        CreateObstacles();
    }

    void CreateRoad()
    {
        GameObject road = GameObject.CreatePrimitive(PrimitiveType.Cube);
        road.name = "Road";
        road.transform.position = new Vector3(0, 0, 20);
        road.transform.localScale = new Vector3(9, 0.2f, 40);
        road.GetComponent<Renderer>().material.color = Color.gray;
    }

    void CreateWalls()
    {
        GameObject leftWall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        leftWall.name = "LeftWall";
        leftWall.transform.position = new Vector3(-5, 1, 20);
        leftWall.transform.localScale = new Vector3(0.3f, 2, 40);
        leftWall.GetComponent<Renderer>().material.color = Color.black;

        GameObject rightWall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        rightWall.name = "RightWall";
        rightWall.transform.position = new Vector3(5, 1, 20);
        rightWall.transform.localScale = new Vector3(0.3f, 2, 40);
        rightWall.GetComponent<Renderer>().material.color = Color.black;
    }

    void CreateObstacles()
    {
        CreateObstacle("Obstacle_1", 0, 8);
        CreateObstacle("Obstacle_2", -3, 15);
        CreateObstacle("Obstacle_3", 3, 22);
        CreateObstacle("Obstacle_4", 0, 30);
        CreateObstacle("Obstacle_5", -3, 36);
    }

<<<<<<< Updated upstream
    void CreateObstacle(string name, float x, float z)
    {
        GameObject obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obstacle.name = name;
=======
    void CreateObstacle(string obstacleName, float x, float z)
    {
        GameObject obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obstacle.name = obstacleName;
>>>>>>> Stashed changes
        obstacle.transform.position = new Vector3(x, 0.75f, z);
        obstacle.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        obstacle.GetComponent<Renderer>().material.color = Color.red;
    }
<<<<<<< Updated upstream
}
=======
}
>>>>>>> Stashed changes
