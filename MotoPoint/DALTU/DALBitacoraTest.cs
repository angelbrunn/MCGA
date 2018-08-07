using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DALTU
{
    [TestClass]
    public class DALBitacoraTest
    {
        SIS.DATOS.DALBitacora dalBitacora = new SIS.DATOS.DALBitacora();

       [TestMethod]
        public void Test_ObtenerUltimoId()
        {
            int ultimoId;
            ultimoId = dalBitacora.ObtenerUltimoId();

            Assert.IsNotNull(ultimoId);

        }
    }
}
