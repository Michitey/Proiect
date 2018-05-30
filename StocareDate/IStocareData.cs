using AdministrareClienti;
using System.Collections;
using System.Collections.Generic;

namespace StocareDate
{
    
    public interface IStocareData
    {
       
        void AddClienti(Client c);
        List<Client> GetClienti();

        void UpdateClienti(Client c);
    }
}
