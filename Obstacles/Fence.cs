namespace Obstacles;
class Fence : Obstacle {
    private byte _endX;
    private byte _endY;
    public Fence(byte startX, byte startY, byte endX, byte endY) : base(startX, startY) {
        _endX = endX;
        _endY = endY;
    }
}