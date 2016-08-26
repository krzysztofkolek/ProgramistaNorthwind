using ProgramistaNorthwind.EF.Model;

namespace ProgramistaNorthwind.EF.Repository
{

    public partial class RegionRepository : BaseRepository<Region>
    {
        public RegionRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
