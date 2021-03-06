﻿using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CS.CoffeePoint.Models;
using CS.CoffePoint.Business.Repositories;

namespace CS.CoffeePoint.Services
{
    public class PlaceService : IPlaceService
    {
        private readonly IPlaceRepository _placeRepo;
        private readonly IMapper _mapper;

        public PlaceService(IPlaceRepository placeRepo, IMapper mapper)
        {
            _placeRepo = placeRepo;
            _mapper = mapper;
        }

        public IList<PlaceModel> GetList()
        {
            var result = _placeRepo.GetList();

            return result.Select(x => _mapper.Map<PlaceModel>(x)).ToList();
        }
    }
}
