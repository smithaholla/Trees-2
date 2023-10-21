public class Soulution
    {
        // Time Complexity : O(n) - traverse all nodes
        // Space Complexity : O(h) - h is height of the tree- recursion stack will at the max have h function calls
        // Did this code successfully run on Leetcode : Yes
        // Any problem you faced while coding this : No

        int result = 0;
        public int SumNumbers(TreeNode root)
        {
            helper(root, 0);
            return result;
        }

        public void helper(TreeNode root, int currNum)
        {
            if (root == null) return;

            currNum = currNum * 10 + root.val;

            if (root.left == null && root.right == null)
            {
                result = result + currNum;
            }

            helper(root.left, currNum);
            //st.pop()
            
            helper(root.right, currNum);
            //st.pop()

        }
}
