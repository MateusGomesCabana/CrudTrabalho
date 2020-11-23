using System.Collections.Generic;
using AutoMapper;
using ProjBiblio.Application.InputModels;
using ProjBiblio.Application.Interfaces;
using ProjBiblio.Application.ViewModels;
using ProjBiblio.Domain.Entities;
using ProjBiblio.Domain.Interfaces;

namespace ProjBiblio.Application.Services
{
    public class GeneroService : IGeneroService
    {
        public IUnitOfWork _uow;
        public IMapper _mapper;

        public GeneroService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public GeneroListViewModel Get()
        {
            var Generos = this._uow.GeneroRepository.Get();

            return new GeneroListViewModel()
            {
                Generos =  _mapper.Map<IEnumerable<GeneroViewModel>>(Generos)
            };
        }

        public GeneroViewModel Get(int id)
        {
            var Genero = this._uow.GeneroRepository.GetById(a => a.GeneroID == id);
            return _mapper.Map<GeneroViewModel>(Genero);
        }

        public GeneroViewModel Post(GeneroInputModel GeneroInputModel)
        {
            var Genero = _mapper.Map<Genero>(GeneroInputModel);

            _uow.GeneroRepository.Add(Genero);
            _uow.Commit();

            return _mapper.Map<GeneroViewModel>(Genero);
        }

        public GeneroViewModel Put(int id, GeneroInputModel GeneroInputModel)
        {
            var Genero = _mapper.Map<Genero>(GeneroInputModel);

            _uow.GeneroRepository.Update(Genero);
            _uow.Commit();

            return _mapper.Map<GeneroViewModel>(Genero);
        }

        public GeneroViewModel Delete(int id)
        {
            var Genero = this._uow.GeneroRepository.GetById(a => a.GeneroID == id);

            if (Genero == null)
            {
                return null;
            }

            _uow.GeneroRepository.Delete(Genero);
            _uow.Commit();

            return _mapper.Map<GeneroViewModel>(Genero);
        }
    }
}