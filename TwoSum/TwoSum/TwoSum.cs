using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    public class TwoSum
    {
        public static int[] GetAnswer (int[] nums, int target)
        {
            if (!IsValid(nums)) { return null; }
            
            var mapDic = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                
                var pastNum = target - num;
                if (mapDic.TryGetValue(pastNum, out var pastIndex))
                {
                    return new[] { pastIndex,  i};
                }

                mapDic[num] = i;
            }

            throw new ApplicationException($"target is Error. value: {target}");
        }

        private static bool IsValid(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            return true;
        }
    }
}