﻿namespace DevEventsAPI.Entities
{
    public class Evento
    {
        public Evento( string titulo, string descricao, DateTime dataInicio, DateTime dataFim, string organizador, DateTime dataCriacao)
        {
           
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Organizador = organizador;
            DataCriacao = DateTime.Now;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Organizador { get; set; }
        public DateTime DataCriacao { get; set; }


        public void Update(string titulo, string descricao, DateTime dataInicio, DateTime dataFim)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

    }
}
