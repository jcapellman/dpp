using DPP.lib.Enums;

namespace DPP.lib.Nodes.Base
{
    public abstract class BaseNode
    {
        public abstract string Name { get; }

        public abstract NodeType AllowedInputs { get; }

        public abstract NodeType AllowedOutputs { get; }

        public abstract object Process(object input);
    }
}