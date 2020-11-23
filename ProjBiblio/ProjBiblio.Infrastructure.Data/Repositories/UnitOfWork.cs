using ProjBiblio.Domain.Interfaces;
using ProjBiblio.Infrastructure.Data.Context;

namespace ProjBiblio.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AutorRepository _autorRepo; 

        private LivroRepository _livroRepo;

        private CampanhaMarketingRepository _CampanhaMarketingRepo;

         private GeneroRepository _GeneroRepo;

        private BibliotecaDbContext _context;

        public IAutorRepository AutorRepository
        {
            get { 
                return _autorRepo = _autorRepo ?? new AutorRepository(_context);
            }
        }

        public ILivroRepository LivroRepository
        {
            get { 
                return _livroRepo = _livroRepo ?? new LivroRepository(_context);
            }
        }

         public ICampanhaMarketingRepository CampanhaMarketingRepository
        {
            get { 
                return _CampanhaMarketingRepo = _CampanhaMarketingRepo ?? new CampanhaMarketingRepository(_context);
            }
        }

        public IGeneroRepository GeneroRepository
        {
            get { 
                return _GeneroRepo = _GeneroRepo ?? new GeneroRepository(_context);
            }
        }
        public UnitOfWork(BibliotecaDbContext contexto)
        {
            _context = contexto;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}