class FrogJmp
{
    public int Solution(int X, int Y, int D)
    {
        if (Y == X) return 0;

        int mj = (Y - X) / D;
        return (Y - X) % D > 0 ? mj + 1 : mj;
    }
}