using System;
using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MySql.EntityFrameworkCore.Extensions;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace BulkyBookWeb.Data
{
	public class ApplicationDBContext :DbContext
	{

        private readonly IConfiguration _configuration;


        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options, IConfiguration configuration) : base(options)
        {

            _configuration = configuration;
            //options.UseMySQL("server=localhost;database=bulky;user=root;");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Category> Categories { get; set; }
	}
}

