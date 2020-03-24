using PG.Commons.Data.Holder;
using PG.Commons.Xml;

namespace PG.StarWarsGame.Services
{
    public interface IXmlFileProcessService<T> where T : IXmlFileDefinition
    {
        IXmlDocumentHolder Load(string filePath);
        void Store(IXmlDocumentHolder xmlDocumentHolder);
        void Store(IXmlDocumentHolder xmlDocumentHolder, string filePath);
    }
}