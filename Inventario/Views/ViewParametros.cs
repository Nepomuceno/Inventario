using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using System;

namespace Sirius.Coletor.Views
{
    public partial class ViewParametros : Form
    {
        private readonly Form _formAntigo;

        public ViewParametros(Form formAntigo)
        {
            _formAntigo = formAntigo;
            InitializeComponent();
        }

  

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            _formAntigo.Show();
            Close();
        }

        private void btnGerarDadosDemo_Click(object sender, System.EventArgs e)
        {
            DadosDeDemonstracao();
        }

        private void DadosDeDemonstracao()
        {
            Filial fl;
            if (!Program.Banco.Filiais.Any())
            {
                Program.Banco.Filiais.Add(new Filial()
                {
                    Codigo = 1,
                    Nome = "Filial 1",
                    Depositos = new List<Deposito>
                    {
                        new Deposito()
                        {
                            Codigo = 11,
                            Nome = "Deposito 11",
                            Localizacoes = new List<Localizacao>
                            {
                                new Localizacao()
                                {
                                    Codigo = 111,
                                    Nome = "Localizacao 111",
                                    TipoLeitura = TipoLeitura.Indefinido
                                }
                            }
                        }
                    }
                });
            }
            fl = Program.Banco.Filiais.FirstOrDefault();

            Inventario inv;
            if (!Program.Banco.Inventarios.Any())
            {
                Program.Banco.Inventarios.Add(new Inventario()
                {
                    Codigo = 1,
                    CodigoContagem = 1,
                    DataInicio = DateTime.Now,
                    Filial = fl,
                    Nome = "Contagem de teste",
                    Leituras = new List<Leitura>(),
                    StatusInventario = StatusInventario.Aberto,
                    TipoInventario = TipoInventario.Contagem

                });
                inv = Program.Banco.Inventarios.FirstOrDefault();
            }
            if (!Program.Banco.Produtos.Any())
            {
                Program.Banco.Produtos = new Colecao<Produto>()
            {
                new Produto()
                {
                    Codigo = 1,
                    Descricao = "Produto 1 LI",
                    EANS = new List<string>
                    {
                        {"7896094999121"}
                    },
                    TipoLeitura = TipoLeitura.Indefinido
                },
                new Produto()
                {
                    Codigo = 2,
                    Descricao = "Produto 2 LM",
                    EANS = new List<string>
                    {
                        {"7896094901285"}
                    },
                    TipoLeitura = TipoLeitura.Multipla
                },
                new Produto()
                {
                    Codigo = 3,
                    Descricao = "Produto 3 LU",
                    EANS = new List<string>
                    {
                        {"7896094905450"}
                    },
                    TipoLeitura = TipoLeitura.Unica
                },
                new Produto()
                {
                    Codigo = 1,
                    Descricao = "Produto 4",
                    EANS = new List<string>
                    {
                        {"78960949"}
                    },
                    TipoLeitura = TipoLeitura.Indefinido
                }
            };
            }


        }
    }
}