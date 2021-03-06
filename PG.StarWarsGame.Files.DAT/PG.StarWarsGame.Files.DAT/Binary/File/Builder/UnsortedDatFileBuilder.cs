using System.Runtime.CompilerServices;
using PG.Commons.Binary.File.Builder;
using PG.StarWarsGame.Files.DAT.Binary.File.Type.Definition;
using PG.StarWarsGame.Files.DAT.Holder;

[assembly: InternalsVisibleTo("PG.StarWarsGame.Files.DAT.Test")]

namespace PG.StarWarsGame.Files.DAT.Binary.File.Builder
{
    internal class UnsortedDatFileBuilder : ADatFileBuilder, IBinaryFileBuilder<DatFile, UnsortedDatFileHolder>
    {
        public UnsortedDatFileBuilder() : base()
        {
        }

        public DatFile FromBytes(byte[] byteStream)
        {
            return FromBytesInternal(byteStream);
        }

        public DatFile FromHolder(UnsortedDatFileHolder holder)
        {
            return FromHolderInternal(holder.Content);
        }
    }
}
