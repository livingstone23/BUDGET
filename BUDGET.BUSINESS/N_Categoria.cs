﻿using BUDGET.DATA;
using BUDGET.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDGET.BUSINESS
{
    public class N_Categoria
    {
        D_Categoria objDato = new D_Categoria();

        public List<E_Categoria> ListandoCategoria(string buscar)
        {
            return objDato.ListaCategoria(buscar);
        }

        public void InsertandoCategoria(E_Categoria Categoria)
        {
            objDato.InsertarCategoria(Categoria);
        }

        public void EditandoCategoria(E_Categoria Categoria)
        {
            objDato.EditarCategoria(Categoria);
        }

        public void EliminandoCategoria(E_Categoria Categoria)
        {
            objDato.EliminarCategoria(Categoria);   
        }

    }

}
