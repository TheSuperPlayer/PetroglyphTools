using PG.Commons.Xml.Values;

namespace PG.StarWarsGame.Commons.Xml.Tags.Engine.FoC
{
    public sealed class MaxWaypointsPerPathXmlTagDefinition : AXmlTagDefinition
    {
        private const string KEY_ID = "MaxWaypointsPerPath";
        private const XmlValueType PG_TYPE = XmlValueType.IntType5;
        private const XmlValueTypeInternal INTERNAL_TYPE = XmlValueTypeInternal.Undefined;
        private const bool IS_SINGLETON = true;

        public override string Id => KEY_ID;
        public override XmlValueType Type => PG_TYPE;
        public override XmlValueTypeInternal TypeInternal => INTERNAL_TYPE;
        public override bool IsSingleton => IS_SINGLETON;
    }
}