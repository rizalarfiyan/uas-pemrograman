class Program
{
    static void Main(string[] args)
    {
        Tree[] trees = new Tree[3];
        trees[0] = new Tree();
        trees[1] = new AppleTree();
        trees[2] = new OakTree();

        foreach (Tree tree in trees)
        {
            tree.Grow();
        }
    }
}