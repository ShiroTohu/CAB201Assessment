namespace Obstacles;
class Fence : Obstacle {
    private int _endX;
    private int _endY;
    public Fence(int startX, int startY, int endX, int endY) : base(startX, startY) {
        _endX = endX;
        _endY = endY;
    }
}