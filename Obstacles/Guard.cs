namespace Obstacles;
class Guard : Obstacle 
{
    protected override void InitializeObstacle()
    {
        _coordinates = PromptCoordinates("Enter the guard's location (X,Y):");
    }
}