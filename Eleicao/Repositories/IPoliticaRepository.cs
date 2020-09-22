using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eleicao.Repositories
{
    interface IPoliticaRepository
    {
        public IList<PoliticaRepository> ListarCandidatos();
        public PoliticaRepository BuscaCandidato();
        public void InserirCandidato();
    }
}
