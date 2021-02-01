﻿using System.Threading.Tasks;
using Thenewboston.Common.Api.Models;
using Thenewboston.Validator.Api.Models;
using Thenewboston.Validator.Models;

namespace Thenewboston.Validator.Api
{
    internal interface IValidatorsService
    {
        Task<PaginatedResponseModel<ValidatorResponseModel>> GetAllValidatorsAsync(
            int offset,
            int limit);
    }
}
