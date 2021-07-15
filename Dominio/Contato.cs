using System;

namespace E_Agenda1._5._0.Dominio
{
    public class Contato
    {

        public int id { get; set; }
        public string nome { get; set; }
        public long telefone { get; set; }
        public string email { get; set; }
        public string empresa { get; set; }
        public string cargo { get; set; }

        public bool Validar(Contato contato)
        {
            int resultado = 0;
            if (contato.telefone < 9999999)
                resultado++;
            if (!(contato.email.Contains("@")) && contato.email.Contains("mail."))
                resultado++;
            if (contato.nome.Length == 0)
                resultado++;
            if (contato.empresa.Length == 0)
                resultado++;
            if (contato.cargo.Length == 0)
                resultado++;

            if (resultado != 0)
                return false;
            else
                return true;


        }

    }
}
