﻿using CFGLib.Parsers.Forests;
using CFGLib.Parsers.Sppf;
using CFGLib.Parsers.Sppf.Old;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFGLib.Parsers.Graphs {
	internal struct ForestNodeNode : INode {
		public readonly ForestNode Node;
		public int Rank { get; set; }
		public readonly string Id;
		private Family2<SppfNode>[] _theFamily;
		public Family2<SppfNode> TheFamily {
			get {
				return _theFamily[0];
			}
			set {
				_theFamily[0] = value;
			}
		}

		public string Other {
			get {
				return "";
			}
		}
		public int StartPosition {
			get { return Node.StartPosition; }
		}
		public int EndPosition {
			get { return Node.EndPosition; }
		}

		public string Name {
			get {
				// return string.Format("\"{0} {1}\"", Node.ToStringSelf(), Id);
				return string.Format("{0}", Id);
				// return string.Format("{0}", &Node);
			}
		}
		public string Label {
			get {
				// return string.Format("{0} {1}", Node.ToStringSelf(), Id);
				return string.Format("{0}", Node.ToStringSelf());
			}
		}
		public string Shape {
			get {
				return "oval";
			}
		}
		public string Color {
			get {
				if (Node is ForestLeaf) {
					return "yellow";
				} else {
					return "white";
				}
			}
		}
		public string Ordering {
			get {
				return "";
			}
		}
		public ForestNodeNode(ForestNode node, string id, int rank) {
			Node = node;
			Id = id;
			Rank = rank;
			_theFamily = new Family2<SppfNode>[1];
			// _theFamily = null;
		}
	}
}
