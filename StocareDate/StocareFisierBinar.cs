using AdministrareClienti;
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace StocareDate
{
    
    public class StocareFisierBinar : IStocareData
    {
        static void Main(string[] args)
        {
        }
        string numeFisier { get; set; }
        public StocareFisierBinar(string numeFisiser)
        {
            this.numeFisier = numeFisiser;
            Stream sBinFile = File.Open(numeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();

           
        }
        public void AddClienti(Client c)
        {
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                
                using (Stream sBinFile = File.Open(numeFisier, FileMode.Append, FileAccess.Write))
                {
                  
                    b.Serialize(sBinFile, c);
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        public List<Client> GetClienti()
        {
            List<Client> clienti = new List<Client>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

             
                using (Stream sBinFile = File.Open(numeFisier, FileMode.Open))
                {
                    while (sBinFile.Position < sBinFile.Length)
                    {
                     
                        clienti.Add((Client)b.Deserialize(sBinFile));
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return clienti;
        }

        public void UpdateClienti(Client clientModificat)
        {
           
            List<Client> clienti = GetClienti();

           
            for (int i= 0; i < clienti.Count; i++)
            {
                if(clienti[i].Id == clientModificat.Id)
                {
                    clienti[i] = clientModificat;
                }
            }

            
            try
            {
                BinaryFormatter b = new BinaryFormatter();

              
                using (Stream sBinFile = File.Open(numeFisier, FileMode.Truncate, FileAccess.Write))
                {
                    foreach(Client c in clienti)
                    {
                       
                        b.Serialize(sBinFile, c);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

        }
    }
}
