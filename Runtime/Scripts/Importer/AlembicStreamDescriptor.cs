using UnityEngine;
using UnityEngine.UI;

namespace UnityEngine.Formats.Alembic.Importer
{
    internal class AlembicStreamDescriptor : ScriptableObject
    {
        [SerializeField]
        private string pathToAbc;
        public string PathToAbc
        {
            get { return pathToAbc; }
            set { pathToAbc = value; }
        }

        [SerializeField]
        private AlembicStreamSettings settings = new AlembicStreamSettings();
        public AlembicStreamSettings Settings
        {
            get { return settings; }
            set { settings = value; }
        }

        [SerializeField]
        private bool hasVaryingTopology = false;
        public bool HasVaryingTopology
        {
            get { return hasVaryingTopology; }
            set { hasVaryingTopology = value; }
        }

        [SerializeField]
        private bool hasAcyclicFramerate = false;
        public bool HasAcyclicFramerate
        {
            get { return hasAcyclicFramerate; }
            set { hasAcyclicFramerate = value; }
        }

        [SerializeField]
        public double abcStartTime = double.MinValue;

        [SerializeField]
        public double abcEndTime = double.MaxValue;

        public double duration { get { return abcEndTime - abcStartTime; } }
    }
}
