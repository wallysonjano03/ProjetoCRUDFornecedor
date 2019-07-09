using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;


namespace ProjetoCRUDFornecedor
{
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();

            txt_pesquisa.Enabled = false;
            txt_cnpj.Enabled = false;
            txt_razao_social.Enabled = false;
            txt_nome.Enabled = false;
            txt_tel.Enabled = false;
            txt_cel.Enabled = false;
            txt_email.Enabled = false;
            txt_cep.Enabled = false;
            txt_cidade.Enabled = false;
            txt_endereco.Enabled = false;
            txt_num.Enabled = false;
            txt_bairro.Enabled = false;
        }
    
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProjetoCRUDfornecedor;Data Source=WALLYSON-PC\SQLEXPRESS";
        private string strSql = string.Empty;
        private void Fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            txt_pesquisa.Enabled = true;
            txt_cnpj.Enabled = true;
            txt_razao_social.Enabled = true;
            txt_nome.Enabled = true;
            txt_tel.Enabled = true;
            txt_cel.Enabled = true;
            txt_email.Enabled = true;
            txt_cep.Enabled = true;
            txt_cidade.Enabled = true;
            txt_endereco.Enabled = true;
            txt_num.Enabled = true;
            txt_bairro.Enabled = true;
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
          strSql = "insert into fornecedor (cnpj, razaosocial, nomefantasia, tel, cel, email, cep, cidade, endereco, numero, bairro) values (@cnpj, @razaosocial, @nomefantasia, @tel, @cel, @email, @cep, @cidade, @endereco, @numero, @bairro)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = txt_cnpj.Text;
            comando.Parameters.Add("@razaosocial", SqlDbType.VarChar).Value = txt_razao_social.Text;
            comando.Parameters.Add("@nomefantasia", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = txt_tel.Text;
            comando.Parameters.Add("@cel", SqlDbType.VarChar).Value = txt_cel.Text;
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@cep", SqlDbType.VarChar).Value = txt_cep.Text;
            comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txt_cidade.Text;
            comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txt_endereco.Text;
            comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = txt_num.Text;
            comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txt_bairro.Text;


            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO.");
            }
             //Trata a execução
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                 //fecha a conexão
                sqlCon.Close();
            }

            txt_pesquisa.Enabled = true;

            txt_pesquisa.Clear();
            txt_cnpj.Clear();
            txt_razao_social.Clear();
            txt_nome.Clear();
            txt_tel.Clear();
            txt_cel.Clear();
            txt_email.Clear();
            txt_cep.Clear();
            txt_cidade.Clear();
            txt_endereco.Clear();
            txt_num.Clear();
            txt_bairro.Clear();

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            strSql = "select * from fornecedor where nomefantasia=@pesquisa";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txt_pesquisa.Text;

            try
            {
                if (txt_pesquisa.Text == string.Empty)
                {
                    MessageBox.Show("VOCÊ NÃO DIGITOU UM NOME.");
                }
                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("ESTE NOME NÃO ESTÁ CADASTRADO");
                }
                dr.Read();

                txt_cnpj.Text = Convert.ToString(dr["cnpj"]);
                txt_razao_social.Text = Convert.ToString(dr["razaosocial"]);
                txt_nome.Text = Convert.ToString(dr["nomefantasia"]);
                txt_tel.Text = Convert.ToString(dr["tel"]);
                txt_cel.Text = Convert.ToString(dr["cel"]);
                txt_email.Text = Convert.ToString(dr["email"]);
                txt_cep.Text = Convert.ToString(dr["cep"]);
                txt_cidade.Text = Convert.ToString(dr["cidade"]);
                txt_endereco.Text = Convert.ToString(dr["endereco"]);
                txt_num.Text = Convert.ToString(dr["numero"]);
                txt_bairro.Text = Convert.ToString(dr["bairro"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            
            }

            txt_pesquisa.Clear();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

            strSql = "update fornecedor set cnpj=@cnpj, razaosocial=@razaosocial, nomefantasia=@nomefantasia, tel=@tel, cel=@cel, email=@email, cep=@cep, cidade=@cidade, endereco=@endereco, numero=@numero, bairro=@bairro";

            
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = txt_cnpj.Text;
            comando.Parameters.Add("@razaosocial", SqlDbType.VarChar).Value = txt_razao_social.Text;
            comando.Parameters.Add("@nomefantasia", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = txt_tel.Text;
            comando.Parameters.Add("@cel", SqlDbType.VarChar).Value = txt_cel.Text;
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@cep", SqlDbType.VarChar).Value = txt_cep.Text;
            comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txt_cidade.Text;
            comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txt_endereco.Text;
            comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = txt_num.Text;
            comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txt_bairro.Text;


            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO ALTERADO COM SUCESSO.");

            }
            finally {
                sqlCon.Close();
            }

            txt_pesquisa.Clear();
            txt_cnpj.Clear();
            txt_razao_social.Clear();
            txt_nome.Clear();
            txt_tel.Clear();
            txt_cel.Clear();
            txt_email.Clear();
            txt_cep.Clear();
            txt_cidade.Clear();
            txt_endereco.Clear();
            txt_num.Clear();
            txt_bairro.Clear();
        }

        private void Btn_apagar_Click(object sender, EventArgs e)
        {


            strSql = "delete from fornecedor where nomefantasia=@nomefantasia";


            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@nomefantasia", SqlDbType.VarChar).Value = txt_nome.Text;

            try {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("EXCLUSÃO DE CADASTRO FEITA COM SUCESSO");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                sqlCon.Close();
            }

            txt_pesquisa.Clear();
            txt_cnpj.Clear();
            txt_razao_social.Clear();
            txt_nome.Clear();
            txt_tel.Clear();
            txt_cel.Clear();
            txt_email.Clear();
            txt_cep.Clear();
            txt_cidade.Clear();
            txt_endereco.Clear();
            txt_num.Clear();
            txt_bairro.Clear();
        }
    }
}

