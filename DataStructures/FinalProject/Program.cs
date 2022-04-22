using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            DoublyCircularLinkedList();
        }

        private static void DoublyCircularLinkedList()
        {
            var list = new DCLinkedList<int>();
            var node = new GenericNode<int>(2);
            list.AddFirst(new GenericNode<int>(10));
            list.AddFirst(new GenericNode<int>(5));
            list.AddFirst(node);
            list.AddFirst(new GenericNode<int>(2));
            list.AddFirst(new GenericNode<int>(1));
            list.AddBefore(node, new GenericNode<int>(9));
        }
    }
}
