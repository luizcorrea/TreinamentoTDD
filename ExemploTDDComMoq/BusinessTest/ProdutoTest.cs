using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;

namespace BusinessTest
{
    [TestClass]
    public class ProdutoTest
    {
        [TestMethod]
        public void Deve_Catalogar_Novo_Produto_Com_Sucesso()
        {
            var produto = new Produto();
            produto.Nome = "iPhone 6S";
            Assert.IsTrue(produto.Catalogar());
        }

        [TestMethod]
        public void Deve_Retornar_False_Ao_Tentar_Catalogar_Um_Produto_Sem_Nome_Preenchido()
        {
            var produto = new Produto();
            Assert.IsFalse(produto.Catalogar());
        }

        [TestMethod]
        public void Deve_Catalogar_Novo_Produto_Com_Sucesso_Injetando_Repositorio()
        {
            IRepositorioProduto repositorio;
            var produto = new Produto(repositorio);
            produto.Nome = "iPhone 6s";
            Assert.IsTrue(produto.Catalogar());
        }
    }
}
