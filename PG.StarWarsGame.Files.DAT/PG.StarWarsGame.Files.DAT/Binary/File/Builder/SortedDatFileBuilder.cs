using System.Runtime.CompilerServices;
using PG.Commons.Binary.File.Builder;
using PG.StarWarsGame.Files.DAT.Binary.File.Type.Definition;
using PG.StarWarsGame.Files.DAT.Holder;

[assembly: InternalsVisibleTo("PG.StarWarsGame.Files.DAT.Test")]

namespace PG.StarWarsGame.Files.DAT.Binary.File.Builder
{
    internal class SortedDatFileBuilder : ADatFileBuilder, IBinaryFileBuilder<DatFile, SortedDatFileHolder>
    {
        public SortedDatFileBuilder() : base()
        {
        }

        public DatFile FromBytes(byte[] byteStream)
        {
            return FromBytesInternal(byteStream);
        }

        public DatFile FromHolder(SortedDatFileHolder holder)
        {
            return FromHolderInternal(holder.Content);
        }
    }
}
