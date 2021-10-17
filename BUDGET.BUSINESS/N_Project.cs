using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUDGET.DATA;
using BUDGET.ENTITIES;

namespace BUDGET.BUSINESS
{
    public class N_Project
    {
        D_Project oData = new D_Project();
        public List<E_ProjectJoinInitiative> ListandoProject(string buscar)
        {
            return oData.ListarProjects(buscar);
        }
        public int GetInitiative(string stInitiative)
        {
            return oData.GetIdInitiative(stInitiative);
        }
        public void InsertandoProject(E_Project oProject)
        {
            oData.InsertarProject(oProject);
        }
        public void EditarProjecT(E_Project oProject)
        {
            oData.EditarProject(oProject);
        }
        public void EliminarProject(E_Project oProject)
        {
            oData.EliminarProject(oProject);
        }
        public List<E_Project> getProyectoPorIniciativa(string idInitiative)
        {
          return  oData.getProjectPorIdInitiative(idInitiative);
        }
        /// <summary>
        /// Devuelve true si un proyecto está asocaido a un POs
        /// </summary>
        /// <param name="idProject"></param>
        /// <returns></returns>
        public bool ProjectAsocidoAPos(int idProject)
        {
            bool bAsocaido = false;


            return bAsocaido;
        }
    }
}
