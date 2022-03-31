using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TuPlan.Models
{
    public class LogErrores
    {
        #region Properties
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime TimeStamp { get; set; }
        #endregion

        #region Constructor
        public LogErrores(string descripcion, DateTime timeStamp)
        {
            Descripcion = descripcion;
            TimeStamp = timeStamp;
        }
        #endregion
    }
}