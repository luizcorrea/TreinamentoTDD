using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using Moq;

namespace BusinessTest
{
    [TestClass]
    public class ProdutoTest
    {
        [TestMethod]
        public void Deve_Catalogar_Novo_Produto_Com_Sucesso()
        {
            var repositorio = new Mock<IRepositorioProduto>();
            repositorio.Setup(r => r.Salvar(It.IsAny<Produto>())).Returns(true);

            var produto = new Produto(repositorio.Object);
            produto.Nome = "iPhone 6S";
            Assert.IsTrue(produto.Catalogar());
        }

        [TestMethod]
        public void Deve_Retornar_False_Ao_Tentar_Catalogar_Um_Produto_Sem_Nome_Preenchido()
        {
            var repositorio = new Mock<IRepositorioProduto>();
            var produto = new Produto(repositorio.Object);
            Assert.IsFalse(produto.Catalogar());
        }

		  [TestMethod]
		  public void Teste_Unitario_Nova_Feature()
		  {
			  
		  }
    }
}
