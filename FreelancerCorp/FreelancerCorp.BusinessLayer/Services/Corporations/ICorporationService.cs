﻿using FreelancerCorp.BusinessLayer.DTOs;
using FreelancerCorp.BusinessLayer.DTOs.Common;
using FreelancerCorp.BusinessLayer.DTOs.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerCorp.BusinessLayer.Services.Corporations
{
    public interface ICorporationService
    {
        Task<QueryResultDTO<CorporationDTO, CorporationFilterDTO>> ListCorporationsAsync(CorporationFilterDTO filter);

        Task<CorporationDTO> GetAsync(int entityId, bool withIncludes = true);

        int Create(CorporationDTO entityDto);

        Task Update(CorporationDTO entityDto);

        void Delete(int entityId);

        Task<QueryResultDTO<CorporationDTO, CorporationFilterDTO>> ListAllAsync();
    }
}
