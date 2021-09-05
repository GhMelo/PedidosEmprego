using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using emprego.Models;

namespace emprego.Controllers
{
    public class pedidosController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"select * from pedido";
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

            public string Post(pedidos ped)
            {
                try
                {
                    string query = "insert into pedido(nome_produto,valor,data_vencimento) values ('"+ped.nome_produto+"','"+ped.valor+"','"+ped.data_vencimento+"')";
                    DataTable table = new DataTable();
                    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosDB"].ConnectionString))
                    using (var cmd = new SqlCommand(query, con))
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.Text;
                        da.Fill(table);
                    }
                    return "Adicionado com sucesso";
                }
                catch (Exception)
                {
                    return "nao deu certo";
                }
            }
            public string Put(pedidos ped)
            {
                try
                {
                    string query = "update pedido set nome_produto='" + ped.nome_produto + "',valor = '" + ped.valor + "',data_vencimento='" + ped.data_vencimento + "' where id='" + ped.Id + "'";
                    DataTable table = new DataTable();
                    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosDB"].ConnectionString))
                    using (var cmd = new SqlCommand(query, con))
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.Text;
                        da.Fill(table);
                    }
                    return "puttado com sucesso";
                }
                catch (Exception)
                {
                    return "nao deu certo";
                }
            }
            public string Delete(int id)
            {
                try
                {
                    string query = "delete from pedido where Id=" + id + "";
                    DataTable table = new DataTable();
                    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosDB"].ConnectionString))
                    using (var cmd = new SqlCommand(query, con))
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.Text;
                        da.Fill(table);
                    }
                    return "deletado com sucesso";
                }
                catch (Exception)
                {
                    return "nao deu certo";
                }
            }

            [Route("api/pedidos/gettudonome")]
            [HttpGet]
            public HttpResponseMessage getTudoNome()
            {
                
                    string query = "select nome_produto from pedido";
                    DataTable table = new DataTable();
                    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosDB"].ConnectionString))
                    using (var cmd = new SqlCommand(query, con))
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.Text;
                        da.Fill(table);
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, table);
                
                
            }
           [Route("api/pedidos/desconto10")]
           [HttpPut]
                        public HttpResponseMessage putDesconto10(pedidos ped)
                                    {
                         
                            string query = "update pedido set valor = valor*0.90 where id='" + ped.Id + "'";
                            DataTable table = new DataTable();
                            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosDB"].ConnectionString))
                            using (var cmd = new SqlCommand(query, con))
                            using (var da = new SqlDataAdapter(cmd))
                            {
                                cmd.CommandType = CommandType.Text;
                                da.Fill(table);
                            }
                        return Request.CreateResponse(HttpStatusCode.OK, table);


                          }
        [Route("api/pedidos/desconto25")]
        [HttpPut]
        public HttpResponseMessage putDesconto25(pedidos ped)
        {

            string query = "update pedido set valor = valor*0.75 where id='" + ped.Id + "'";
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);


        }
        [Route("api/pedidos/desconto50")]
        [HttpPut]
        public HttpResponseMessage putDesconto50(pedidos ped)
        {

            string query = "update pedido set valor = valor*0.50 where id='" + ped.Id + "'";
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);


        }
        [Route("api/pedidos/desconto75")]
        [HttpPut]
        public HttpResponseMessage putDesconto75(pedidos ped)
        {

            string query = "update pedido set valor = valor*0.25 where id='" + ped.Id + "'";
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["PedidosDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);


        }


    }
    }

