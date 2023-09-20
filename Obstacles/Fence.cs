namespace Obstacles;
class Fence : Obstacle {
    private int[] _endCoordinates;
    private int _length;

    protected override void InitalizeObject()
    {
        PromptCoordinates("Balls");
    }
}