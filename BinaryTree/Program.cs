using BinaryTree.Controller;
using BinaryTree.Model;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Binary Search Tree\n");

        TreeController treeController = new TreeController();

        treeController.Insert(75);
        treeController.Insert(57);
        treeController.Insert(90);
        treeController.Insert(32);
        treeController.Insert(7);
        treeController.Insert(44);
        treeController.Insert(60);
        treeController.Insert(86);
        treeController.Insert(93);
        treeController.Insert(99);
        treeController.Insert(100);


        Console.WriteLine("In Order Traversal (Left->Root->Right)");
        treeController.InOrderTraversal();
        Console.WriteLine("\nPre Order Traversal (Root->Left->Right)");
        treeController.PreorderTraversal();
        Console.WriteLine("\nPost Order Traversal (Left->Right->Root)");
        treeController.PostorderTraversal();

        Console.WriteLine("\nFind 99");
        var node = treeController.Find(99);
        Console.WriteLine(node.Data);
        Console.WriteLine("Find Recursively 99");
        var nodeR = treeController.FindRecursive(99);
        Console.WriteLine(nodeR.Data);
        Console.WriteLine("Delete a Leaf Node (44)");
        treeController.Remove(44);
        Console.WriteLine("Delete a Node with one child (93)");
        treeController.Remove(93);
        Console.WriteLine("Delete a Node with two child nodes (75)");
        treeController.Remove(75);
        Console.WriteLine("SoftDelete a Node with one child (93)");
        treeController.SoftDelete(93);


        Console.WriteLine("Get Smallest node");
        Console.WriteLine(treeController.Smallest());
        Console.WriteLine("Get Largest node");
        Console.WriteLine(treeController.Largest());
        Console.WriteLine("Get the number of leaf nodes");
        Console.WriteLine(treeController.NumberOfLeafNodes());
        Console.WriteLine("Get the height of the tree");
        Console.WriteLine(treeController.Height());
    }


    public static int getHeight(TreeModel root)
    {
        if (root == null)
        {
            return 0;
        }

        return Math.Max(getHeight(root.LeftNode), getHeight(root.RightNode)) + 1;
    }

    public static bool isBalanced(TreeModel root)
    {
        if (root == null)
        {
            return true;
        }

        int heightDiff = getHeight(root.LeftNode) - getHeight(root.RightNode);
        if (Math.Abs(heightDiff) > 1)
        {
            return false;
        }
        else
        {
            return (isBalanced(root.LeftNode) && isBalanced(root.RightNode));
        }
    }
}
