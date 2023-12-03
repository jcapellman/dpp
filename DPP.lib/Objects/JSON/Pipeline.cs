using DPP.lib.Nodes.Base;

namespace DPP.lib.Objects.JSON
{
    public class Pipeline
    {
        public string Name { get; set; }

        public BaseNode[] Nodes { get; set; }
    }
}