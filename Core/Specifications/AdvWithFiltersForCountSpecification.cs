using Core.Entities;

namespace Core.Specifications
{
    public class AdvWithFiltersForCountSpecification: BaseSpecification<Adv>
    {
        public AdvWithFiltersForCountSpecification(AdvSpecParams advParams)
            : base(x =>
                (string.IsNullOrEmpty(advParams.Search) || x.ClientOrderGiver.ToLower()
                        .Contains(advParams.Search)) &&                 
                (!advParams.VnRetrofitTypeId.HasValue || x.VnRetrofitTypeId == advParams.VnRetrofitTypeId) 
            )
        {
        }
    }
}