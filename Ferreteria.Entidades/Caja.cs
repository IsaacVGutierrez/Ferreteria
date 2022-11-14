﻿namespace Ferreteria.Entidades
{
    public class Caja
    {
        private int idCaja;

        private string tipoComprobante;

        private int Cant_Cobrar;  //para validar en un metodo la cantidad total que se va a cobrar segun el precio

        private bool Entrega_Comprobante;




        public int IdCaja
        {
            get { return idCaja; }
            set { idCaja = value; }

        }
        public string TipoComprobante
        {
            get { return tipoComprobante; }
            set { tipoComprobante = value; }
        }

        public bool EntregaComprobante
        {
            get { return Entrega_Comprobante; }
            set { Entrega_Comprobante = value; }
        }

        public Caja() { }



        public Caja(string tipoComprob, bool entregaComprob)
        {
          
            tipoComprobante =          tipoComprob;         /* CAMBIAR NOMRES EN AZUL */
            Entrega_Comprobante =      entregaComprob;


        }
    }
}
