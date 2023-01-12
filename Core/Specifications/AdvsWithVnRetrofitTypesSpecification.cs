using Core.Entities;

namespace Core.Specifications
{
    public class AdvsWithVnRetrofitTypesSpecification : BaseSpecification<Adv>
    {
        public AdvsWithVnRetrofitTypesSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.VnRetrofitType);
        }
        public AdvsWithVnRetrofitTypesSpecification(AdvSpecParams advParams) 
        : base(x =>
                (string.IsNullOrEmpty(advParams.Search) || x.ClientOrderGiver.ToLower()
                        .Contains(advParams.Search)) &&                 
                (!advParams.VnRetrofitTypeId.HasValue || x.VnRetrofitTypeId == advParams.VnRetrofitTypeId) 
            )
        {
            AddInclude(x => x.VnRetrofitType);
            AddOrderBy(x => x.ClientOrderGiver);
            ApplyPaging(advParams.PageSize * (advParams.PageIndex -1),
            advParams.PageSize);

            if (!string.IsNullOrEmpty(advParams.Sort))
            {
                switch (advParams.Sort)
                {
                    case "IdAsc":
                        AddOrderBy(a => a.Id);
                        break;
                    case "IdDesc":
                        AddOrderByDescending(a => a.Id);
                        break;
                    default:
                        AddOrderBy(n => n.ClientOrderGiver);
                        break;
                }
            }
        }
    }
}