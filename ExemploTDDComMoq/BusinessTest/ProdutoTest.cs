using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessTest
{
    [TestClass]
    public class ProdutoTest
    {
        [TestMethod]
        public void Deve_Catalogar_Novo_Produto_Com_Sucesso()
        {
            var produto = new Produto();
            Assert.IsTrue(produto.Catalogar());
        }
    }
}
