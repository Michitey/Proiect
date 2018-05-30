using System;
using System.Collections;
using AdministrareClienti;
using System.Windows.Forms;
using System.Collections.Generic;

namespace StocareDate
{
    
    public class StocareFisierText : IStocareData
    {
        RichTextBox rtbHelper;
        string numeFisier;
        public StocareFisierText(RichTextBox rtb, string numeFisier)
        {
            rtbHelper = rtb;
            this.numeFisier = numeFisier;
        }
        public void AddClienti(Client c)
        {
            rtbHelper.SaveFile(numeFisier);
        }

        public List<Client> GetClienti()
        {
            throw new Exception("Citirea din fisier 'rtf' nu este implementata");
        }

        public void UpdateClienti(Client c)
        {
            rtbHelper.SaveFile(numeFisier);
        }
    }
}
