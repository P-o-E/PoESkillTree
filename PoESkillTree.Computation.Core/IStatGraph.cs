﻿using System.Collections.Generic;
using PoESkillTree.Computation.Common;

namespace PoESkillTree.Computation.Core
{
    public interface IStatGraph : IReadOnlyStatGraph
    {
        void RemoveNode(NodeType nodeType);
        void RemoveFormNodeCollection(Form form);

        void AddModifier(Modifier modifier);
        bool RemoveModifier(Modifier modifier);
        int ModifierCount { get; }
    }

    public interface IReadOnlyStatGraph
    {
        ISuspendableEventViewProvider<ICalculationNode> GetNode(NodeType nodeType);
        IReadOnlyDictionary<NodeType, ISuspendableEventViewProvider<ICalculationNode>> Nodes { get; }

        ISuspendableEventViewProvider<INodeCollection<Modifier>> GetFormNodeCollection(Form form);
        IReadOnlyDictionary<Form, ISuspendableEventViewProvider<INodeCollection<Modifier>>> FormNodeCollections { get; }
    }

}