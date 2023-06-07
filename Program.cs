namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(12);
            bst.Add(22);
            bst.Add(45);
            bst.Add(65);
            bst.Add(26);
            bst.Add(78);
            bst.Add(20);
            bst.Add(129);

            //if data found return true or false
            Console.WriteLine(bst.Search(78));
            bst.InOrder();
            bst.Preorder();
            bst.Postorder();

        }
    }
}