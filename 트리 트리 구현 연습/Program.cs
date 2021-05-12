using System;
using System.Collections.Generic;

namespace 트리_트리_구현_연습
{
    class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Childen { get; set; } = new List<TreeNode<T>>();
    }
    class Program
    {
        static TreeNode<string> MakeTree()
        {
            TreeNode<string> root = new TreeNode<string>() { Data = "R1 개발실" };
            {
                {
                    TreeNode<string> node = new TreeNode<string>() { Data = "디자인팀" };
                    node.Childen.Add(new TreeNode<string>() { Data = "전투" });
                    node.Childen.Add(new TreeNode<string>() { Data = "경제" });
                    node.Childen.Add(new TreeNode<string>() { Data = "스토리" });
                    root.Childen.Add(node);
                }
                {
                    TreeNode<string> node = new TreeNode<string>() { Data = "프로그래밍팀" };
                    node.Childen.Add(new TreeNode<string>() { Data = "서버" });
                    node.Childen.Add(new TreeNode<string>() { Data = "클라" });
                    node.Childen.Add(new TreeNode<string>() { Data = "엔진" });
                    root.Childen.Add(node);
                }
                {
                    TreeNode<string> node = new TreeNode<string>() { Data = "아트팀" };
                    node.Childen.Add(new TreeNode<string>() { Data = "배경" });
                    node.Childen.Add(new TreeNode<string>() { Data = "캐릭터" });
                    root.Childen.Add(node);
                }
            }
            return root;
        }

        static void PrintTree(TreeNode<string> root)
        {
            Console.WriteLine(root.Data);

            foreach (TreeNode<string> child in root.Childen)
                PrintTree(child);
        }

        static int GetHeight(TreeNode<string> root)
        {
            int height = 0;

            foreach (TreeNode<string> child in root.Childen)
            {
                int newHeight = GetHeight(child) + 1;
                height = Math.Max(height, newHeight);
            }

            return height;
        }

        static void Main(string[] args)
        {
            TreeNode<string> root = MakeTree();
            PrintTree(root);
            Console.WriteLine(GetHeight(root));
        }
    }
}
