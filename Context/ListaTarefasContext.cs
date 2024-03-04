using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trilha_net_api_desafio.Models;
using Microsoft.EntityFrameworkCore;


namespace trilha_net_api_desafio.Context
{
    public class ListaTarefasContext : DbContext
    {
        public ListaTarefasContext(DbContextOptions<ListaTarefasContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}