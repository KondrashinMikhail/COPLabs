using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class TreeViewControl : UserControl
    {
        public List<string> Hierarchy { private get; set; }
        private TreeNode selectedNode;
        private string path;
        public int? Index 
        {
            get 
            {
                if (selectedNode != null)
                    return selectedNode.Index;
                else
                    return null;
            }
            set 
            {
                if (value != null && value < selectedNode.Parent.Nodes.Count)
                {
                    TreeNodeCollection array = selectedNode.Parent.Nodes;
                    TreeNode secondNode = (TreeNode)array[(int)value].Clone();

                    array[(int)value].Text += " ";
                    array[selectedNode.Index] = secondNode;
                    array[(int)value] = selectedNode;
                }
            }
        }

        public TreeViewControl(List<string> Hierarchy)
        {
            InitializeComponent();
            this.Hierarchy = Hierarchy;
        }

        public void FillChildNodes<T>(TreeNode parentNode, List<T> childObjects)
        {
            foreach (var obj in childObjects)
            {
                string text = obj.GetType().GetProperty(Hierarchy.ElementAt(parentNode.Level)).GetValue(obj).ToString();
                bool flag = false;

                for (int i = 0; i < parentNode.Nodes.Count; i++)
                    if (parentNode.Nodes[i].Text == text)
                        flag = true;

                if (!flag)
                {
                    TreeNode childNode = new TreeNode { Text = text };
                    parentNode.Nodes.Add(childNode);
                }
            }
        }

        public TreeNodeCollection GetCollection()
        {
            return treeView.Nodes;
        }

        public void RecursiveFill<T>(TreeNodeCollection collection, List<T> objects)
        {
            if (treeView.Nodes.Count == 0)
            {
                foreach (var obj in objects)
                {
                    string text = obj.GetType().GetProperty(Hierarchy.First()).GetValue(obj).ToString();
                    bool flag = false;

                    for (int i = 0; i < treeView.Nodes.Count; i++)
                        if (treeView.Nodes[i].Text == text)
                            flag = true;

                    if (!flag)
                    {
                        TreeNode rootNode = new TreeNode { Text = text };
                        FillChildNodes(rootNode, objects.Where(x => x.GetType().GetProperty(Hierarchy.ElementAt(0)).GetValue(obj).ToString() == text).ToList());
                        treeView.Nodes.Add(rootNode);
                    }
                }
            }
            foreach (TreeNode node in collection)
            {
                node.Nodes.Clear();
                List<object> childObjects = new List<object>();
                foreach (var obj in objects)
                    if (obj.GetType().GetProperty(Hierarchy.ElementAt(node.Level)).GetValue(obj).ToString() == node.Text)
                        childObjects.Add(obj);

                if (childObjects.Count != 0 && node.Level + 1 < Hierarchy.Count)
                {
                    foreach (var obj in childObjects)
                    {
                        bool flag = false;

                        for (int i = 0; i < node.Nodes.Count; i++)
                            if (node.Nodes[i].Text == obj.GetType().GetProperty(Hierarchy.ElementAt(node.Level + 1)).GetValue(obj).ToString())
                                flag = true;

                        if (!flag && node.Level + 1 < Hierarchy.Count)
                        {
                            TreeNode newNode = new TreeNode { Text = obj.GetType().GetProperty(Hierarchy.ElementAt(node.Level + 1)).GetValue(obj).ToString() };
                            FillChildNodes(newNode, new List<object> { obj });
                            node.Nodes.Add(newNode);
                        }
                    }
                }

                RecursiveFill(node.Nodes, objects);
            }
        }

        public object GetSelectedObject<T>(List<T> objects) 
        {
            string[] fields = new string[Hierarchy.Count];
            if (path != null)
                fields = path.Split('/');

            foreach (var obj in objects) 
            {
                bool flag = true;
                if (fields != null)
                foreach (var str in Hierarchy) 
                        if (obj.GetType().GetProperty(str).GetValue(obj).ToString() != fields[Hierarchy.IndexOf(str)]) 
                            flag = false;
                if (flag) 
                    return obj;
            }
            return null;
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView.PathSeparator = "/";
            if (e.Node.Level == Hierarchy.Count - 1)
                path = e.Node.FullPath;
            selectedNode = e.Node;
        }

        public string ToStr<T>(T obj) 
        {
            string str = "";
            foreach (var property in Hierarchy) 
                str += property + ": " + obj.GetType().GetProperty(property).GetValue(obj).ToString() + "; ";
            return str;
        }
    }
}