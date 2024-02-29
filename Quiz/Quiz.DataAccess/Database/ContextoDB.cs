using Quiz.DomainModel.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Text;

namespace Quiz.DataAccess.Database
{
    public class ContextoDB : DbContext
    {
        public ContextoDB() : base("QuizDB")
        {
            //if (base.Database.Exists())
            //    base.Database.Delete();
            //else
            //    base.Database.Create();
        }

        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("Varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
            //modelBuilder.Entity<Pergunta>().Property(x => x.Descricao.Max(100));
            modelBuilder.Properties().Configure(p => p.IsRequired());
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            StringBuilder _msg = new StringBuilder();
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors) // <-- Coloque um Breakpoint aqui para conferir os erros de validação.
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (DbUpdateException e)
            {
                foreach (var eve in e.Entries)
                {
                    _msg.AppendFormat("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entity.GetType().Name, eve.State);
                }
                throw new Exception(_msg.ToString());
            }
            catch (SqlException s)
            {
                Console.WriteLine("- Message: \"{0}\", Data: \"{1}\"",
                            s.Message, s.Data);
                throw;
            }
        }
    }
}
