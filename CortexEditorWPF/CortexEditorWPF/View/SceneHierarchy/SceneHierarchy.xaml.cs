﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CortexEditorWPF.View.SceneHierarchy
{
    /// <summary>
    /// Interaction logic for SceneHierarchy.xaml
    /// </summary>
    public partial class SceneHierarchy : UserControl
    {

        
        public SceneHierarchy()
        {
            InitializeComponent();

            TreeViewItem item = new TreeViewItem();
            item.Header = "Entity";
            item.Tag = "Entity";

            SceneHierarchyTree.Items.Add(item);
        }
    }
}
