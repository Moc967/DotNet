using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualizar(int id, Serie objeto)
        {
            listaSerie[id]= objeto;
        }
        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
            //Implementar envio de email para notificar o cliente
        }
        public void Inserir(Serie objeto)
        {
            listaSerie.Add(objeto);
        }
        public List<Serie> Listar()
        {
            return listaSerie;
        }
        public int ProximoId()
        {
            return listaSerie.Count;
        }
        public Serie RetornaPorID(int id)
        {
            return listaSerie[id];
        }
    }
}