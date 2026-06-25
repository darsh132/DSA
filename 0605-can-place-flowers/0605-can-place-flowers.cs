public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        bool canPlant = false;
        int noPlant = 0;
        for(int i = 0; i < flowerbed.Length; i++)
        {
			if(flowerbed[i] == 0)
			{
				bool leftEmpty = (i == 0) || (flowerbed[i - 1] == 0);
				bool rightEmpty = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);
				
				if(leftEmpty && rightEmpty)
				{
					flowerbed[i] = 1;
					noPlant++;
					
					if(noPlant >= n)
					{
						return true;
					}
				}
			}
        }

        return noPlant >= n;
    }
}