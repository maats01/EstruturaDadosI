using Exe06;

Tree<Person> tree = new Tree<Person>();
tree.Root = new TreeNode<Person>() {
    Data = new Person(1, "Marcin Jamro", "CEO")
};

tree.Root.Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>{
        Data = new Person(2, "John Smith", "Head of Development"),
        Parent = tree.Root
    },

    new TreeNode<Person>{
        Data = new Person(3, "Mary Fox", "Head of Research"),
        Parent = tree.Root
    },
    new TreeNode<Person>{
        Data = new Person(4, "Lily Smith", "Head of Sales"),
        Parent = tree.Root
    }
};

tree.Root.Children[0].Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>{
        Data = new Person(5, "Chris Moris", "Senior Developer"),
        Parent = tree.Root.Children[0]
    }
};

tree.Root.Children[1].Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>{
        Data = new Person(6, "Jimmy Stewart", "Senior Researcher"),
        Parent = tree.Root.Children[1]
    },
    new TreeNode<Person>{
        Data = new Person(7, "Andy Wood", "Senior Researcher"),
        Parent = tree.Root.Children[1]
    }
};

tree.Root.Children[2].Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>{
        Data = new Person(8, "Anthony Black", "Senior Sales Specialist"),
        Parent = tree.Root.Children[2]
    },
    new TreeNode<Person>{
        Data = new Person(9, "Angela Evans", "Senior Sales Specialist"),
        Parent = tree.Root.Children[2]
    },
    new TreeNode<Person>{
        Data = new Person(10, "Tommy Butler", "Senior Sales Manager"),
        Parent = tree.Root.Children[2]
    }
};
