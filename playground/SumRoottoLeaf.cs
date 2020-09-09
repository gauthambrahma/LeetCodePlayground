using System;
namespace playground
{
    public class SumRoottoLeaf
    {
        public int SumRootToLeaf(TreeNode root)
        {
            int sum = 0;
            return ReccursivelyAddSum(root, "", sum);
        }

        public int ReccursivelyAddSum(TreeNode node, string binary_string, int sum)
        {
            if (node.left == null && node.right == null)
            {
                sum += Convert.ToInt32(binary_string + node.val, 2);
                return sum;
            }

            if (node.left != null)
            {
                sum = ReccursivelyAddSum(node.left, binary_string + node.val, sum);
            }

            if (node.right != null)
            {
                sum = ReccursivelyAddSum(node.right, binary_string + node.val, sum);
            }
            return sum;
        }
    }

}
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
