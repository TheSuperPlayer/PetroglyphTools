using PG.Commons.Xml.Values;

namespace PG.StarWarsGame.Commons.Xml.Tags.Engine.FoC
{
    public sealed class StrategicMinScrollSpeedXmlTagDefinition : AXmlTagDefinition
    {
        private const string KEY_ID = "Strategic_Min_Scroll_Speed";
        private const XmlValueType PG_TYPE = XmlValueType.IntType6;
        private const XmlValueTypeInternal INTERNAL_TYPE = XmlValueTypeInternal.Undefined;
        private const bool IS_SINGLETON = true;

        public override string Id => KEY_ID;
        public override XmlValueType Type => PG_TYPE;
        public override XmlValueTypeInternal TypeInternal => INTERNAL_TYPE;
        public override bool IsSingleton => IS_SINGLETON;
    }
}