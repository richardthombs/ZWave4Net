﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZWave
{
    public class NodeCollection : IEnumerable<Node>
    {
        private readonly List<Node> _nodes = new List<Node>();

        internal void Add(Node node)
        {
            _nodes.Add(node);
        }

        public Node this[byte nodeID]
        {
            get { return _nodes.FirstOrDefault(element => element.NodeID == nodeID); }
        }

        public IEnumerator<Node> GetEnumerator()
        {
            return _nodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _nodes.GetEnumerator();
        }
    }
}
