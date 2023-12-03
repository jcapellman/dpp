using DPP.lib.Nodes.Base;

namespace DPP.lib.Nodes
{
    public class CasingNode : BaseNode
    {
        public override string Name => "Casing";

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