namespace Obstacles
{
    class MineField : Obstacle
    {
        protected override void InitializeObstacle()
        {
            PromptCoordinates("Balls");
        }

        public override List<int[]> GetVision(int[] topLeft, int[] bottomRight)
        {
            // Originally it was int[,] but in reality the size of the vision would be unknown.
            // Especially for more complex objects.
            List<int[]> vision = new List<int[]>() { _coordinates };
            return vision;
        }
    }
}
