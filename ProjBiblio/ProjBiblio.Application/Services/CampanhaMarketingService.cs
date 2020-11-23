using System.Collections.Generic;
using AutoMapper;
using ProjBiblio.Application.InputModels;
using ProjBiblio.Application.Interfaces;
using ProjBiblio.Application.ViewModels;
using ProjBiblio.Domain.Entities;
using ProjBiblio.Domain.Interfaces;

namespace ProjBiblio.Application.Services
{
    public class CampanhaMarketingService : ICampanhaMarketingService
    {
        public IUnitOfWork _uow;
        public IMapper _mapper;

        public CampanhaMarketingService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public CampanhaMarketingListViewModel Get()
        {
            var CampanhaMarketings = this._uow.CampanhaMarketingRepository.Get();

            return new CampanhaMarketingListViewModel()
            {
                CampanhaMarketings =  _mapper.Map<IEnumerable<CampanhaMarketingViewModel>>(CampanhaMarketings)
            };
        }

        public CampanhaMarketingViewModel Get(int id)
        {
            var CampanhaMarketing = this._uow.CampanhaMarketingRepository.GetById(a => a.CampanhaMarketingID == id);
            return _mapper.Map<CampanhaMarketingViewModel>(CampanhaMarketing);
        }

        public CampanhaMarketingViewModel Post(CampanhaMarketingInputModel CampanhaMarketingInputModel)
        {
            var CampanhaMarketing = _mapper.Map<CampanhaMarketing>(CampanhaMarketingInputModel);

            _uow.CampanhaMarketingRepository.Add(CampanhaMarketing);
            _uow.Commit();

            return _mapper.Map<CampanhaMarketingViewModel>(CampanhaMarketing);
        }

        public CampanhaMarketingViewModel Put(int id, CampanhaMarketingInputModel CampanhaMarketingInputModel)
        {
            var CampanhaMarketing = _mapper.Map<CampanhaMarketing>(CampanhaMarketingInputModel);

            _uow.CampanhaMarketingRepository.Update(CampanhaMarketing);
            _uow.Commit();

            return _mapper.Map<CampanhaMarketingViewModel>(CampanhaMarketing);
        }

        public CampanhaMarketingViewModel Delete(int id)
        {
            var CampanhaMarketing = this._uow.CampanhaMarketingRepository.GetById(a => a.CampanhaMarketingID == id);

            if (CampanhaMarketing == null)
            {
                return null;
            }

            _uow.CampanhaMarketingRepository.Delete(CampanhaMarketing);
            _uow.Commit();

            return _mapper.Map<CampanhaMarketingViewModel>(CampanhaMarketing);
        }
    }
}