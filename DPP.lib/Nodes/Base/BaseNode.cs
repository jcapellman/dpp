namespace DPP.lib.Nodes.Base
{
    public abstract class BaseNode
    {
        public abstract string Name { get; }

        public abstract object Process(object input);
    }
}