using DPP.lib.Enums;
using DPP.lib.Nodes.Base;

namespace DPP.lib.Nodes
{
    public class CasingNode : BaseNode
    {
        public override string Name => "Casing";

        public override NodeType AllowedInputs => NodeType.TEXT_DATA;

        public override NodeType AllowedOutputs => NodeType.TEXT_DATA;

        public override object Process(object input)
        {
            if (input is not string str)
            {
                throw new ArgumentException($"Input is not a string");
            }

            return str.ToUpper();
        }
    }
}