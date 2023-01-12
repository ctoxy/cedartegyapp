using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Errors;
using API.Helpers;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ArtegyAdvsController : BaseApiController
    {
        private readonly IGenericRepository<Adv> _advsRepo;
        private readonly IGenericRepository<VnRetrofitType> _vnRetrofitTypeRepo;
        private readonly IMapper _mapper;
       
        public ArtegyAdvsController(IGenericRepository<Adv> advsRepo,
            IGenericRepository<VnRetrofitType> vnRetrofitTypeRepo,IMapper mapper)
        {
            _vnRetrofitTypeRepo = vnRetrofitTypeRepo;
            _advsRepo = advsRepo;
            _mapper = mapper; 
            
            
        }

        [HttpGet]
        public async Task<ActionResult<Pagination<AdvToReturnDto>>> GetAdvs(
            [FromQuery]AdvSpecParams advParams)
        {
            var spec = new AdvsWithVnRetrofitTypesSpecification(advParams);
            var countSpec = new AdvWithFiltersForCountSpecification(advParams);
            var totalItems = await _advsRepo.CountAsync(countSpec);

            var advs = await _advsRepo.ListAsync(spec);
            var data = _mapper
                .Map<IReadOnlyList<Adv>, IReadOnlyList<AdvToReturnDto>>(advs); ;
            
            return Ok(new Pagination<AdvToReturnDto>(advParams.PageIndex,
            advParams.PageSize, totalItems, data));
        }

        [HttpGet("{id}")]
        //permet a swagger de prendre en compte les requetes d erreur custom
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AdvToReturnDto>> GetAdv(int id)
        {
            var spec = new AdvsWithVnRetrofitTypesSpecification(id);
            var adv = await _advsRepo.GetEntityWithSpec(spec);

            if(adv == null) return NotFound(new ApiResponse(404));
            return _mapper.Map<Adv, AdvToReturnDto>(adv);
        }

        [HttpGet("vnretrofittypes")]
        public async Task<ActionResult<IReadOnlyList<VnRetrofitType>>> GetAdvVnRetrofiTypes()
        {
            var advvnretrofittypes = await _vnRetrofitTypeRepo.ListAllAsync();
            return Ok(advvnretrofittypes);
        }
    }
}