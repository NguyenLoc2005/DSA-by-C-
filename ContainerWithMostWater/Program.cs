
class ContaierWithMostWater
{
    static void Main()
    {
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        int maxArea = 0;
        for (int i = 0; i < height.Length; i++)
        {
            for (int j = i + 1; j < height.Length; j++)
            {
                if (height[i] < height[j])
                {
                    int area = height[i] * (j - i);
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
                else
                {
                    int area = height[j] * (j - i);
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
        }
        Console.WriteLine(""+maxArea);
    }
}